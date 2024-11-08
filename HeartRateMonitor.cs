using System;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace VRChatHeartRateMonitor
{
    internal static class HeartRateMonitor
    {
        static Mutex _mutex = new Mutex(true, "{VRCHAT_HEART_RATE_MONITOR_UWU}");

        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                try
                {
                    string currentFilePath = Assembly.GetExecutingAssembly().Location;

                    string oldVersionDirectoryFilePath = args[0];
                    string oldVersionTmpDirectoryFilePath = args[1];
                    string newVersionTmpFilePath = args[2];

                    if (currentFilePath == newVersionTmpFilePath)
                    {
                        KillProcessByPath(oldVersionDirectoryFilePath);
                        File.Move(oldVersionDirectoryFilePath, oldVersionTmpDirectoryFilePath);
                        Process.Start(oldVersionTmpDirectoryFilePath, $"\"{oldVersionDirectoryFilePath}\" \"{oldVersionTmpDirectoryFilePath}\" \"{newVersionTmpFilePath}\"");
                    }
                    else if (currentFilePath == oldVersionTmpDirectoryFilePath)
                    {
                        KillProcessByPath(newVersionTmpFilePath);
                        File.Move(newVersionTmpFilePath, oldVersionDirectoryFilePath);
                        Process.Start(oldVersionDirectoryFilePath, $"\"{oldVersionDirectoryFilePath}\" \"{oldVersionTmpDirectoryFilePath}\" \"{newVersionTmpFilePath}\"");
                    }
                    else if (currentFilePath == oldVersionDirectoryFilePath)
                    {
                        KillProcessByPath(oldVersionTmpDirectoryFilePath);
                        File.Delete(oldVersionTmpDirectoryFilePath);

                        SuccessMessageBox("Application updated successfully!");

                        Process.Start(oldVersionDirectoryFilePath);
                    }

                    Application.Exit();
                }
                catch (Exception) 
                {
                    ErrorMessageBox("An error occurred during the update process. Please try again or download the application again from the official source!");
                }
            }
            else if (!DeviceHandler.CheckCompatibility().Result)
            {
                ErrorMessageBox("Application couldn't detect Bluetooth adapter with Low Energy devices compatibility!");
            }
            else if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                MainForm mainForm = new MainForm();

                if (!mainForm.IsDisposed)
                    Application.Run(mainForm);

                _mutex.ReleaseMutex();
            }
            else
            {
                ErrorMessageBox(GetAssemblyTitle() + " is already running!");
                return;
            }
        }

        public static void SuccessMessageBox(string message)
        {
            MessageBox.Show(message, GetAssemblyTitle() + " - SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ErrorMessageBox(string message)
        {
            MessageBox.Show(message, GetAssemblyTitle() + " - ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void InfoMessageBox(string message)
        {
            MessageBox.Show(message, GetAssemblyTitle() + " - INFORMATION", MessageBoxButtons.OK);
        }

        public static bool ActionMessageBox(string message)
        {
            return MessageBox.Show(message, GetAssemblyTitle() + " - ACTION REQUIRED", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static string GetAssemblyTitle()
        {
            var assembly = Assembly.GetExecutingAssembly();

            var titleAttribute = (AssemblyTitleAttribute)Attribute.GetCustomAttribute(assembly, typeof(AssemblyTitleAttribute));

            return (titleAttribute?.Title ?? "NONE") + " v" + GetAssemblyVersion();
        }

        public static string GetAssemblyVersion()
        {
            Version assemblyVersion = Assembly.GetExecutingAssembly().GetName().Version;

            return $"{assemblyVersion.Major}.{assemblyVersion.Minor}";
        }

        public static void KillProcessByPath(string fullPath)
        {
            string processName = Path.GetFileNameWithoutExtension(fullPath);

            var processes = Process.GetProcessesByName(processName);

            foreach (var process in processes)
            {
                if (string.Equals(process.MainModule.FileName, fullPath, StringComparison.OrdinalIgnoreCase))
                {
                    process.Kill();
                    process.WaitForExit();

                }
            }
        }
    }
}
