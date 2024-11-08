namespace VRChatHeartRateMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelDeviceInfo = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelDevice = new System.Windows.Forms.Label();
            this.panelHeartRateDisplay = new System.Windows.Forms.Panel();
            this.labelBatteryLevel = new System.Windows.Forms.Label();
            this.labelHeartRateDisplay = new System.Windows.Forms.Label();
            this.pictureBoxHeartRateDisplay = new System.Windows.Forms.PictureBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.panelWebServer = new System.Windows.Forms.Panel();
            this.buttonWebServerPortInfo = new System.Windows.Forms.Button();
            this.textBoxWebServerPort = new System.Windows.Forms.TextBox();
            this.labelWebServerPort = new System.Windows.Forms.Label();
            this.checkBoxUseWebServer = new System.Windows.Forms.CheckBox();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.buttonAvatarParameterInfo = new System.Windows.Forms.Button();
            this.textBoxAvatarParameter = new System.Windows.Forms.TextBox();
            this.labelAvatarParameter = new System.Windows.Forms.Label();
            this.checkBoxUseAvatar = new System.Windows.Forms.CheckBox();
            this.panelChatbox = new System.Windows.Forms.Panel();
            this.comboBoxChatboxAppearance = new System.Windows.Forms.ComboBox();
            this.labelChatboxAppearance = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxUseChatbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.panelInfoBottom = new System.Windows.Forms.Panel();
            this.linkLabelInfoProjectUrl = new System.Windows.Forms.LinkLabel();
            this.linkLabelInfoAuthorUrl = new System.Windows.Forms.LinkLabel();
            this.labelInfoAuthorName = new System.Windows.Forms.Label();
            this.labelInfoAppName = new System.Windows.Forms.Label();
            this.panelInfoTop = new System.Windows.Forms.Panel();
            this.pictureBoxInfoAuthor = new System.Windows.Forms.PictureBox();
            this.linkLabelFooterWebsite = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFooterDiscord = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panelHeartRateDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeartRateDisplay)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.panelWebServer.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            this.panelChatbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.panelInfoBottom.SuspendLayout();
            this.panelInfoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFooterDiscord)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabMain);
            this.tabControl.Controls.Add(this.tabSettings);
            this.tabControl.Controls.Add(this.tabInfo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(5, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(1419, 725);
            this.tabControl.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.Controls.Add(this.labelDeviceInfo);
            this.tabMain.Controls.Add(this.comboBoxDevices);
            this.tabMain.Controls.Add(this.buttonExecute);
            this.tabMain.Controls.Add(this.labelDevice);
            this.tabMain.Controls.Add(this.panelHeartRateDisplay);
            this.tabMain.Location = new System.Drawing.Point(4, 40);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3, 2, 5, 72);
            this.tabMain.Size = new System.Drawing.Size(1411, 681);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // labelDeviceInfo
            // 
            this.labelDeviceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeviceInfo.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            this.labelDeviceInfo.Location = new System.Drawing.Point(3, 371);
            this.labelDeviceInfo.Name = "labelDeviceInfo";
            this.labelDeviceInfo.Size = new System.Drawing.Size(1403, 48);
            this.labelDeviceInfo.TabIndex = 4;
            this.labelDeviceInfo.Text = "(Selected device will be used as default the next time the application is launche" +
    "d)";
            this.labelDeviceInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDevices.Font = new System.Drawing.Font("Cascadia Mono", 13F);
            this.comboBoxDevices.FormattingEnabled = true;
            this.comboBoxDevices.IntegralHeight = false;
            this.comboBoxDevices.ItemHeight = 22;
            this.comboBoxDevices.Location = new System.Drawing.Point(3, 341);
            this.comboBoxDevices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(1403, 30);
            this.comboBoxDevices.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.AutoSize = true;
            this.buttonExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Font = new System.Drawing.Font("Cascadia Mono", 20F);
            this.buttonExecute.Location = new System.Drawing.Point(3, 502);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(1403, 107);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "START";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelDevice
            // 
            this.labelDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDevice.Font = new System.Drawing.Font("Cascadia Mono", 14F);
            this.labelDevice.Location = new System.Drawing.Point(3, 269);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(1403, 72);
            this.labelDevice.TabIndex = 2;
            this.labelDevice.Text = "Select device from the list below:";
            // 
            // panelHeartRateDisplay
            // 
            this.panelHeartRateDisplay.Controls.Add(this.labelBatteryLevel);
            this.panelHeartRateDisplay.Controls.Add(this.labelHeartRateDisplay);
            this.panelHeartRateDisplay.Controls.Add(this.pictureBoxHeartRateDisplay);
            this.panelHeartRateDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeartRateDisplay.Location = new System.Drawing.Point(3, 2);
            this.panelHeartRateDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeartRateDisplay.Name = "panelHeartRateDisplay";
            this.panelHeartRateDisplay.Size = new System.Drawing.Size(1403, 267);
            this.panelHeartRateDisplay.TabIndex = 1;
            // 
            // labelBatteryLevel
            // 
            this.labelBatteryLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelBatteryLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBatteryLevel.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Bold);
            this.labelBatteryLevel.ForeColor = System.Drawing.Color.White;
            this.labelBatteryLevel.Location = new System.Drawing.Point(0, 0);
            this.labelBatteryLevel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelBatteryLevel.Name = "labelBatteryLevel";
            this.labelBatteryLevel.Padding = new System.Windows.Forms.Padding(157, 0, 0, 167);
            this.labelBatteryLevel.Size = new System.Drawing.Size(1403, 267);
            this.labelBatteryLevel.TabIndex = 6;
            this.labelBatteryLevel.Text = "⚡100%";
            this.labelBatteryLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHeartRateDisplay
            // 
            this.labelHeartRateDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeartRateDisplay.Font = new System.Drawing.Font("Cascadia Mono", 36F);
            this.labelHeartRateDisplay.ForeColor = System.Drawing.Color.White;
            this.labelHeartRateDisplay.Location = new System.Drawing.Point(0, 0);
            this.labelHeartRateDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.labelHeartRateDisplay.Name = "labelHeartRateDisplay";
            this.labelHeartRateDisplay.Padding = new System.Windows.Forms.Padding(13, 0, 0, 48);
            this.labelHeartRateDisplay.Size = new System.Drawing.Size(1403, 267);
            this.labelHeartRateDisplay.TabIndex = 8;
            this.labelHeartRateDisplay.Text = "69";
            this.labelHeartRateDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeartRateDisplay.Visible = false;
            // 
            // pictureBoxHeartRateDisplay
            // 
            this.pictureBoxHeartRateDisplay.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHeartRateDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxHeartRateDisplay.Image = global::VRChatHeartRateMonitor.Properties.Resources.heart;
            this.pictureBoxHeartRateDisplay.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxHeartRateDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxHeartRateDisplay.Name = "pictureBoxHeartRateDisplay";
            this.pictureBoxHeartRateDisplay.Size = new System.Drawing.Size(1403, 267);
            this.pictureBoxHeartRateDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeartRateDisplay.TabIndex = 1;
            this.pictureBoxHeartRateDisplay.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.panelWebServer);
            this.tabSettings.Controls.Add(this.checkBoxUseWebServer);
            this.tabSettings.Controls.Add(this.panelAvatar);
            this.tabSettings.Controls.Add(this.checkBoxUseAvatar);
            this.tabSettings.Controls.Add(this.panelChatbox);
            this.tabSettings.Controls.Add(this.buttonSave);
            this.tabSettings.Controls.Add(this.panel1);
            this.tabSettings.Controls.Add(this.label1);
            this.tabSettings.Location = new System.Drawing.Point(4, 40);
            this.tabSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 72);
            this.tabSettings.Size = new System.Drawing.Size(1411, 681);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            // 
            // panelWebServer
            // 
            this.panelWebServer.Controls.Add(this.buttonWebServerPortInfo);
            this.panelWebServer.Controls.Add(this.textBoxWebServerPort);
            this.panelWebServer.Controls.Add(this.labelWebServerPort);
            this.panelWebServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWebServer.Location = new System.Drawing.Point(3, 256);
            this.panelWebServer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelWebServer.Name = "panelWebServer";
            this.panelWebServer.Size = new System.Drawing.Size(1405, 72);
            this.panelWebServer.TabIndex = 9;
            // 
            // buttonWebServerPortInfo
            // 
            this.buttonWebServerPortInfo.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.buttonWebServerPortInfo.Location = new System.Drawing.Point(1312, -2);
            this.buttonWebServerPortInfo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonWebServerPortInfo.Name = "buttonWebServerPortInfo";
            this.buttonWebServerPortInfo.Size = new System.Drawing.Size(67, 60);
            this.buttonWebServerPortInfo.TabIndex = 9;
            this.buttonWebServerPortInfo.Text = "?";
            this.buttonWebServerPortInfo.UseVisualStyleBackColor = true;
            this.buttonWebServerPortInfo.Click += new System.EventHandler(this.buttonWebServerPortInfo_Click);
            // 
            // textBoxWebServerPort
            // 
            this.textBoxWebServerPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxWebServerPort.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxWebServerPort.Location = new System.Drawing.Point(907, 0);
            this.textBoxWebServerPort.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxWebServerPort.Name = "textBoxWebServerPort";
            this.textBoxWebServerPort.ReadOnly = true;
            this.textBoxWebServerPort.Size = new System.Drawing.Size(399, 23);
            this.textBoxWebServerPort.TabIndex = 6;
            // 
            // labelWebServerPort
            // 
            this.labelWebServerPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelWebServerPort.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelWebServerPort.Location = new System.Drawing.Point(0, 0);
            this.labelWebServerPort.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelWebServerPort.Name = "labelWebServerPort";
            this.labelWebServerPort.Padding = new System.Windows.Forms.Padding(21, 7, 0, 0);
            this.labelWebServerPort.Size = new System.Drawing.Size(907, 72);
            this.labelWebServerPort.TabIndex = 5;
            this.labelWebServerPort.Text = "Set port number for the web server:";
            // 
            // checkBoxUseWebServer
            // 
            this.checkBoxUseWebServer.AutoSize = true;
            this.checkBoxUseWebServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseWebServer.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseWebServer.Location = new System.Drawing.Point(3, 234);
            this.checkBoxUseWebServer.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxUseWebServer.Name = "checkBoxUseWebServer";
            this.checkBoxUseWebServer.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.checkBoxUseWebServer.Size = new System.Drawing.Size(1405, 22);
            this.checkBoxUseWebServer.TabIndex = 2;
            this.checkBoxUseWebServer.Text = "Local Web Server";
            this.checkBoxUseWebServer.UseVisualStyleBackColor = true;
            this.checkBoxUseWebServer.CheckedChanged += new System.EventHandler(this.checkBoxUseWebServer_CheckedChanged);
            // 
            // panelAvatar
            // 
            this.panelAvatar.Controls.Add(this.buttonAvatarParameterInfo);
            this.panelAvatar.Controls.Add(this.textBoxAvatarParameter);
            this.panelAvatar.Controls.Add(this.labelAvatarParameter);
            this.panelAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAvatar.Location = new System.Drawing.Point(3, 162);
            this.panelAvatar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(1405, 72);
            this.panelAvatar.TabIndex = 8;
            // 
            // buttonAvatarParameterInfo
            // 
            this.buttonAvatarParameterInfo.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.buttonAvatarParameterInfo.Location = new System.Drawing.Point(1312, -2);
            this.buttonAvatarParameterInfo.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAvatarParameterInfo.Name = "buttonAvatarParameterInfo";
            this.buttonAvatarParameterInfo.Size = new System.Drawing.Size(67, 60);
            this.buttonAvatarParameterInfo.TabIndex = 8;
            this.buttonAvatarParameterInfo.Text = "?";
            this.buttonAvatarParameterInfo.UseVisualStyleBackColor = true;
            this.buttonAvatarParameterInfo.Click += new System.EventHandler(this.AvatarParameterInfo_Click);
            // 
            // textBoxAvatarParameter
            // 
            this.textBoxAvatarParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxAvatarParameter.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxAvatarParameter.Location = new System.Drawing.Point(907, 0);
            this.textBoxAvatarParameter.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxAvatarParameter.Name = "textBoxAvatarParameter";
            this.textBoxAvatarParameter.ReadOnly = true;
            this.textBoxAvatarParameter.Size = new System.Drawing.Size(399, 23);
            this.textBoxAvatarParameter.TabIndex = 7;
            // 
            // labelAvatarParameter
            // 
            this.labelAvatarParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAvatarParameter.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelAvatarParameter.Location = new System.Drawing.Point(0, 0);
            this.labelAvatarParameter.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelAvatarParameter.Name = "labelAvatarParameter";
            this.labelAvatarParameter.Padding = new System.Windows.Forms.Padding(21, 7, 0, 0);
            this.labelAvatarParameter.Size = new System.Drawing.Size(907, 72);
            this.labelAvatarParameter.TabIndex = 4;
            this.labelAvatarParameter.Text = "Set avatar parameter name: /avatar/parameters/";
            // 
            // checkBoxUseAvatar
            // 
            this.checkBoxUseAvatar.AutoSize = true;
            this.checkBoxUseAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseAvatar.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseAvatar.Location = new System.Drawing.Point(3, 140);
            this.checkBoxUseAvatar.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxUseAvatar.Name = "checkBoxUseAvatar";
            this.checkBoxUseAvatar.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.checkBoxUseAvatar.Size = new System.Drawing.Size(1405, 22);
            this.checkBoxUseAvatar.TabIndex = 1;
            this.checkBoxUseAvatar.Text = "VRChat Avatar";
            this.checkBoxUseAvatar.UseVisualStyleBackColor = true;
            this.checkBoxUseAvatar.CheckedChanged += new System.EventHandler(this.checkBoxUseAvatar_CheckedChanged);
            // 
            // panelChatbox
            // 
            this.panelChatbox.Controls.Add(this.comboBoxChatboxAppearance);
            this.panelChatbox.Controls.Add(this.labelChatboxAppearance);
            this.panelChatbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatbox.Location = new System.Drawing.Point(3, 61);
            this.panelChatbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panelChatbox.Name = "panelChatbox";
            this.panelChatbox.Size = new System.Drawing.Size(1405, 79);
            this.panelChatbox.TabIndex = 12;
            // 
            // comboBoxChatboxAppearance
            // 
            this.comboBoxChatboxAppearance.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBoxChatboxAppearance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChatboxAppearance.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.comboBoxChatboxAppearance.FormattingEnabled = true;
            this.comboBoxChatboxAppearance.Items.AddRange(new object[] {
            "Type 1",
            "Type 2",
            "Type 3",
            "Type 4",
            "Type 5"});
            this.comboBoxChatboxAppearance.Location = new System.Drawing.Point(907, 0);
            this.comboBoxChatboxAppearance.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxChatboxAppearance.Name = "comboBoxChatboxAppearance";
            this.comboBoxChatboxAppearance.Size = new System.Drawing.Size(465, 25);
            this.comboBoxChatboxAppearance.TabIndex = 6;
            // 
            // labelChatboxAppearance
            // 
            this.labelChatboxAppearance.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChatboxAppearance.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelChatboxAppearance.Location = new System.Drawing.Point(0, 0);
            this.labelChatboxAppearance.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelChatboxAppearance.Name = "labelChatboxAppearance";
            this.labelChatboxAppearance.Padding = new System.Windows.Forms.Padding(21, 7, 0, 0);
            this.labelChatboxAppearance.Size = new System.Drawing.Size(907, 79);
            this.labelChatboxAppearance.TabIndex = 5;
            this.labelChatboxAppearance.Text = "Select the type of message appearance:";
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSave.Font = new System.Drawing.Font("Cascadia Mono", 20F);
            this.buttonSave.Location = new System.Drawing.Point(3, 502);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(1405, 107);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.checkBoxUseChatbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 22);
            this.panel1.TabIndex = 11;
            // 
            // checkBoxUseChatbox
            // 
            this.checkBoxUseChatbox.AutoSize = true;
            this.checkBoxUseChatbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseChatbox.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseChatbox.Location = new System.Drawing.Point(0, 0);
            this.checkBoxUseChatbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.checkBoxUseChatbox.Name = "checkBoxUseChatbox";
            this.checkBoxUseChatbox.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.checkBoxUseChatbox.Size = new System.Drawing.Size(1405, 22);
            this.checkBoxUseChatbox.TabIndex = 0;
            this.checkBoxUseChatbox.Text = "VRChat Chatbox";
            this.checkBoxUseChatbox.UseVisualStyleBackColor = true;
            this.checkBoxUseChatbox.CheckedChanged += new System.EventHandler(this.checkBoxUseChatbox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 14F);
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 12);
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Send capetured heart rate to:";
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.White;
            this.tabInfo.Controls.Add(this.panelInfoBottom);
            this.tabInfo.Controls.Add(this.panelInfoTop);
            this.tabInfo.Location = new System.Drawing.Point(4, 40);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 72);
            this.tabInfo.Size = new System.Drawing.Size(1411, 681);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            // 
            // panelInfoBottom
            // 
            this.panelInfoBottom.Controls.Add(this.linkLabelInfoProjectUrl);
            this.panelInfoBottom.Controls.Add(this.linkLabelInfoAuthorUrl);
            this.panelInfoBottom.Controls.Add(this.labelInfoAuthorName);
            this.panelInfoBottom.Controls.Add(this.labelInfoAppName);
            this.panelInfoBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInfoBottom.Location = new System.Drawing.Point(3, 380);
            this.panelInfoBottom.Name = "panelInfoBottom";
            this.panelInfoBottom.Size = new System.Drawing.Size(1405, 229);
            this.panelInfoBottom.TabIndex = 1;
            // 
            // linkLabelInfoProjectUrl
            // 
            this.linkLabelInfoProjectUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelInfoProjectUrl.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.linkLabelInfoProjectUrl.Location = new System.Drawing.Point(0, 155);
            this.linkLabelInfoProjectUrl.Name = "linkLabelInfoProjectUrl";
            this.linkLabelInfoProjectUrl.Size = new System.Drawing.Size(1405, 45);
            this.linkLabelInfoProjectUrl.TabIndex = 4;
            this.linkLabelInfoProjectUrl.TabStop = true;
            this.linkLabelInfoProjectUrl.Text = "https://github.com/RichardVirgosky/VRChat-Heart-Rate-Monitor";
            this.linkLabelInfoProjectUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelInfoProjectUrl.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelInfoProjectUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfoProjectUrl_LinkClicked);
            // 
            // linkLabelInfoAuthorUrl
            // 
            this.linkLabelInfoAuthorUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelInfoAuthorUrl.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.linkLabelInfoAuthorUrl.Location = new System.Drawing.Point(0, 110);
            this.linkLabelInfoAuthorUrl.Name = "linkLabelInfoAuthorUrl";
            this.linkLabelInfoAuthorUrl.Size = new System.Drawing.Size(1405, 45);
            this.linkLabelInfoAuthorUrl.TabIndex = 3;
            this.linkLabelInfoAuthorUrl.TabStop = true;
            this.linkLabelInfoAuthorUrl.Text = "https://virgosky.com";
            this.linkLabelInfoAuthorUrl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelInfoAuthorUrl.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabelInfoAuthorUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfoAuthorUrl_LinkClicked);
            // 
            // labelInfoAuthorName
            // 
            this.labelInfoAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfoAuthorName.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.labelInfoAuthorName.Location = new System.Drawing.Point(0, 65);
            this.labelInfoAuthorName.Name = "labelInfoAuthorName";
            this.labelInfoAuthorName.Size = new System.Drawing.Size(1405, 45);
            this.labelInfoAuthorName.TabIndex = 1;
            this.labelInfoAuthorName.Text = "Author: Richard Virgosky";
            this.labelInfoAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfoAppName
            // 
            this.labelInfoAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfoAppName.Font = new System.Drawing.Font("Cascadia Mono", 15F);
            this.labelInfoAppName.Location = new System.Drawing.Point(0, 0);
            this.labelInfoAppName.Name = "labelInfoAppName";
            this.labelInfoAppName.Size = new System.Drawing.Size(1405, 65);
            this.labelInfoAppName.TabIndex = 0;
            this.labelInfoAppName.Text = "VRChat HeartRate Monitor v0.0";
            this.labelInfoAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfoTop
            // 
            this.panelInfoTop.Controls.Add(this.pictureBoxInfoAuthor);
            this.panelInfoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoTop.Location = new System.Drawing.Point(3, 2);
            this.panelInfoTop.Name = "panelInfoTop";
            this.panelInfoTop.Size = new System.Drawing.Size(1405, 362);
            this.panelInfoTop.TabIndex = 0;
            // 
            // pictureBoxInfoAuthor
            // 
            this.pictureBoxInfoAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfoAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfoAuthor.Image")));
            this.pictureBoxInfoAuthor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInfoAuthor.Name = "pictureBoxInfoAuthor";
            this.pictureBoxInfoAuthor.Size = new System.Drawing.Size(1405, 362);
            this.pictureBoxInfoAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoAuthor.TabIndex = 0;
            this.pictureBoxInfoAuthor.TabStop = false;
            // 
            // linkLabelFooterWebsite
            // 
            this.linkLabelFooterWebsite.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabelFooterWebsite.AutoSize = true;
            this.linkLabelFooterWebsite.BackColor = System.Drawing.Color.White;
            this.linkLabelFooterWebsite.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.linkLabelFooterWebsite.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelFooterWebsite.Location = new System.Drawing.Point(812, 665);
            this.linkLabelFooterWebsite.Name = "linkLabelFooterWebsite";
            this.linkLabelFooterWebsite.Size = new System.Drawing.Size(224, 18);
            this.linkLabelFooterWebsite.TabIndex = 8;
            this.linkLabelFooterWebsite.TabStop = true;
            this.linkLabelFooterWebsite.Text = "Created by Richard Virgosky";
            this.linkLabelFooterWebsite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelFooterWebsite.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelFooterWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFooterWebsite_LinkClicked);
            // 
            // pictureBoxFooterDiscord
            // 
            this.pictureBoxFooterDiscord.BackColor = System.Drawing.Color.White;
            this.pictureBoxFooterDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFooterDiscord.Image = global::VRChatHeartRateMonitor.Properties.Resources.discord;
            this.pictureBoxFooterDiscord.Location = new System.Drawing.Point(21, 661);
            this.pictureBoxFooterDiscord.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBoxFooterDiscord.Name = "pictureBoxFooterDiscord";
            this.pictureBoxFooterDiscord.Size = new System.Drawing.Size(347, 57);
            this.pictureBoxFooterDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFooterDiscord.TabIndex = 9;
            this.pictureBoxFooterDiscord.TabStop = false;
            this.pictureBoxFooterDiscord.Click += new System.EventHandler(this.pictureBoxFooterDiscord_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1424, 730);
            this.Controls.Add(this.pictureBoxFooterDiscord);
            this.Controls.Add(this.linkLabelFooterWebsite);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRChat Heart Rate Monitor";
            this.tabControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.panelHeartRateDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeartRateDisplay)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.panelWebServer.ResumeLayout(false);
            this.panelWebServer.PerformLayout();
            this.panelAvatar.ResumeLayout(false);
            this.panelAvatar.PerformLayout();
            this.panelChatbox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.panelInfoBottom.ResumeLayout(false);
            this.panelInfoTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFooterDiscord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.PictureBox pictureBoxHeartRateDisplay;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Label labelDeviceInfo;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.Label labelHeartRateDisplay;
        private System.Windows.Forms.Panel panelHeartRateDisplay;
        private System.Windows.Forms.LinkLabel linkLabelFooterWebsite;
        private System.Windows.Forms.TextBox textBoxAvatarParameter;
        private System.Windows.Forms.TextBox textBoxWebServerPort;
        private System.Windows.Forms.Label labelWebServerPort;
        private System.Windows.Forms.Label labelAvatarParameter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxUseWebServer;
        private System.Windows.Forms.CheckBox checkBoxUseAvatar;
        private System.Windows.Forms.Panel panelWebServer;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAvatarParameterInfo;
        private System.Windows.Forms.Button buttonWebServerPortInfo;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxUseChatbox;
        private System.Windows.Forms.Panel panelChatbox;
        private System.Windows.Forms.Label labelChatboxAppearance;
        private System.Windows.Forms.ComboBox comboBoxChatboxAppearance;
        private System.Windows.Forms.Label labelBatteryLevel;
        private System.Windows.Forms.PictureBox pictureBoxFooterDiscord;
        private System.Windows.Forms.Panel panelInfoBottom;
        private System.Windows.Forms.LinkLabel linkLabelInfoProjectUrl;
        private System.Windows.Forms.LinkLabel linkLabelInfoAuthorUrl;
        private System.Windows.Forms.Label labelInfoAuthorName;
        private System.Windows.Forms.Label labelInfoAppName;
        private System.Windows.Forms.Panel panelInfoTop;
        private System.Windows.Forms.PictureBox pictureBoxInfoAuthor;
    }
}

