﻿using System;
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
                    string oldVersionTmpDirectoryFilePath = args[1];//unused, kept for compatibility with v0.1
                    string newVersionTmpFilePath = args[2];

                    if (currentFilePath == newVersionTmpFilePath && IsFileAvailable(oldVersionDirectoryFilePath, TimeSpan.FromSeconds(10)))
                    {
                        File.Delete(oldVersionDirectoryFilePath);
                        File.Copy(newVersionTmpFilePath, oldVersionDirectoryFilePath);

                        Process.Start(oldVersionDirectoryFilePath, $"\"{oldVersionDirectoryFilePath}\" \"{oldVersionTmpDirectoryFilePath}\" \"{newVersionTmpFilePath}\"");
                    }
                    else if (currentFilePath == oldVersionDirectoryFilePath && IsFileAvailable(newVersionTmpFilePath, TimeSpan.FromSeconds(10)))
                    {
                        File.Delete(newVersionTmpFilePath);

                        if (RegistryHelper.GetValue<string>("chatbox_text", null) == null)
                        {
                            string[] chatboxAppearanceTemplates = {
                                "♥",
                                "💖",
                                "💓",
                                "💔",
                                "💕",
                                "💘"
                            };

                            ushort chatboxAppearance = ushort.Parse(RegistryHelper.GetValue("chatbox_appearance", "0"));
                            RegistryHelper.SetValue("chatbox_text", chatboxAppearanceTemplates[chatboxAppearance] + " {HR} {I} (AVG {AVG})");

                            RegistryHelper.SetValue("web_server_html", "HR: {HR}\r\nInstruction:\r\nhttps://github.com/RichardVirgosky/VRChat-Heart-Rate-Monitor/blob/main/README_WEB_SERVER.md");
                            RegistryHelper.SetValue("discord_active_text", RegistryHelper.GetValue("discord_active_text", "AVG: {AVG} BPM").Replace("{0}", "{HR}"));
                            RegistryHelper.SetValue("discord_state_text", RegistryHelper.GetValue("discord_state_text", "HR: {HR} BPM").Replace("{0}", "{HR}"));

                            SuccessMessageBox(
                                "Application updated successfully!\n\n" +
                                "Here's what's new:\n" +
                                "• Improved device connectivity handling\n" +
                                "• Fully customizable chatbox template\n" +
                                "• Toggle to switch avatar parameter type between FLOAT and INT\n" +
                                "• Average Heart Rate available in Chatbox, Discord and Web Server\n" +
                                "• Added setup instructions for using Web Server with OBS and similar tools.\n\n" +
                                "👉 Make sure to check your settings, especially if you're a streamer!"
                            );
                        }
                        else 
                        {
                            SuccessMessageBox(
                                "Application updated successfully!\n\n" +
                                "You're now running the latest version.\n\n" +
                                "💬 Have questions or feedback?\n" +
                                "Join our Discord community to get help, share ideas, or report issues!\n\n" +
                                "👉 https://virgosky.com/dc"
                            );
                        }

                        RegistryHelper.SetValue("last_version", HeartRateMonitor.GetAssemblyVersion());

                        Process.Start(oldVersionDirectoryFilePath);
                    }
                    else
                    {
                        ErrorMessageBox("The update process couldn't be completed, try downloading the program manually from the project page on github!");
                    }
                }
                catch (Exception) 
                {
                    ErrorMessageBox("An error occurred during the update process. Please try again or download the application again from the official github soure!");
                }
            }
            else if (!DeviceHandler.CheckCompatibility().Result)
            {
                ErrorMessageBox("Application couldn't detect Bluetooth adapter with Low Energy devices compatibility!");
            }
            else if (_mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(true);

                MainForm mainForm = new MainForm();

                try
                {
                    if (!mainForm.IsDisposed)
                        Application.Run(mainForm);
                }
                catch (NullReferenceException){}

                _mutex.ReleaseMutex();
            }
            else
            {
                ErrorMessageBox(GetAssemblyTitle() + " is already running. If you recently closed it, please wait a moment for all background tasks to complete before reopening.");
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

        public static bool IsFileAvailable(string filePath, TimeSpan timeout)
        {
            DateTime endTime = DateTime.Now + timeout;

            while (DateTime.Now < endTime)
            {
                try
                {
                    using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        return true;
                }
                catch (IOException)
                {
                    Thread.Sleep(100);
                }
            }

            return false;
        }
    }
}
