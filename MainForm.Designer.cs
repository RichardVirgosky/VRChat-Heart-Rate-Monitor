using System.Drawing;

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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.labelDeviceInfo = new System.Windows.Forms.Label();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.labelDevice = new System.Windows.Forms.Label();
            this.panelHeartRateDisplay = new System.Windows.Forms.Panel();
            this.labelBatteryLevel = new System.Windows.Forms.Label();
            this.labelHeartRateDisplay = new System.Windows.Forms.Label();
            this.pictureBoxHeartRateDisplay = new System.Windows.Forms.PictureBox();
            this.tabVRChatSettings = new System.Windows.Forms.TabPage();
            this.panelAvatar = new System.Windows.Forms.Panel();
            this.buttonAvatarParameterInfo = new System.Windows.Forms.Button();
            this.textBoxAvatarParameter = new System.Windows.Forms.TextBox();
            this.labelAvatarParameter = new System.Windows.Forms.Label();
            this.checkBoxUseAvatar = new System.Windows.Forms.CheckBox();
            this.panelChatbox = new System.Windows.Forms.Panel();
            this.buttonBoxChatboxTextInfo = new System.Windows.Forms.Button();
            this.textBoxChatboxText = new System.Windows.Forms.TextBox();
            this.labelChatboxText = new System.Windows.Forms.Label();
            this.buttonSaveVRChatSettings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxUseChatbox = new System.Windows.Forms.CheckBox();
            this.panelOsc = new System.Windows.Forms.Panel();
            this.buttonOscAddressInfo = new System.Windows.Forms.Button();
            this.textBoxOscAddress = new System.Windows.Forms.TextBox();
            this.labelOscInfo = new System.Windows.Forms.Label();
            this.labelOsc = new System.Windows.Forms.Label();
            this.tabWebServerSettings = new System.Windows.Forms.TabPage();
            this.textBoxWebServerHtml = new System.Windows.Forms.TextBox();
            this.panelWebServerHtml = new System.Windows.Forms.Panel();
            this.labelWebServerHtml = new System.Windows.Forms.Label();
            this.linkLabelWebServerTemplateInstruction = new System.Windows.Forms.LinkLabel();
            this.buttonSaveWebServerSettings = new System.Windows.Forms.Button();
            this.panelWebServer = new System.Windows.Forms.Panel();
            this.buttonWebServerPortInfo = new System.Windows.Forms.Button();
            this.textBoxWebServerPort = new System.Windows.Forms.TextBox();
            this.labelWebServerPort = new System.Windows.Forms.Label();
            this.checkBoxUseWebServer = new System.Windows.Forms.CheckBox();
            this.tabDiscordSettings = new System.Windows.Forms.TabPage();
            this.buttonSaveDiscordSettings = new System.Windows.Forms.Button();
            this.labelDiscordInfo = new System.Windows.Forms.Label();
            this.panelDiscordStateText = new System.Windows.Forms.Panel();
            this.textBoxDiscordStateText = new System.Windows.Forms.TextBox();
            this.labelDiscordStateText = new System.Windows.Forms.Label();
            this.panelDiscordIdleText = new System.Windows.Forms.Panel();
            this.textBoxDiscordIdleText = new System.Windows.Forms.TextBox();
            this.labelDiscordIdleText = new System.Windows.Forms.Label();
            this.panelDiscordActiveText = new System.Windows.Forms.Panel();
            this.textBoxDiscordActiveText = new System.Windows.Forms.TextBox();
            this.labelDiscordActiveText = new System.Windows.Forms.Label();
            this.checkBoxUseDiscord = new System.Windows.Forms.CheckBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.panelInfoBottom = new System.Windows.Forms.Panel();
            this.linkLabelInfoProjectUrl = new System.Windows.Forms.LinkLabel();
            this.linkLabelInfoAuthorUrl = new System.Windows.Forms.LinkLabel();
            this.labelInfoAuthorName = new System.Windows.Forms.Label();
            this.labelInfoAppName = new System.Windows.Forms.Label();
            this.panelInfoTop = new System.Windows.Forms.Panel();
            this.pictureBoxInfoAuthor = new System.Windows.Forms.PictureBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.pictureBoxFooterDiscord = new System.Windows.Forms.PictureBox();
            this.linkLabelFooterWebsite = new System.Windows.Forms.LinkLabel();
            this.tabs.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.panelHeartRateDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeartRateDisplay)).BeginInit();
            this.tabVRChatSettings.SuspendLayout();
            this.panelAvatar.SuspendLayout();
            this.panelChatbox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelOsc.SuspendLayout();
            this.tabWebServerSettings.SuspendLayout();
            this.panelWebServerHtml.SuspendLayout();
            this.panelWebServer.SuspendLayout();
            this.tabDiscordSettings.SuspendLayout();
            this.panelDiscordStateText.SuspendLayout();
            this.panelDiscordIdleText.SuspendLayout();
            this.panelDiscordActiveText.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.panelInfoBottom.SuspendLayout();
            this.panelInfoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoAuthor)).BeginInit();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFooterDiscord)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Visible = true;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabMain);
            this.tabs.Controls.Add(this.tabVRChatSettings);
            this.tabs.Controls.Add(this.tabWebServerSettings);
            this.tabs.Controls.Add(this.tabDiscordSettings);
            this.tabs.Controls.Add(this.tabInfo);
            this.tabs.Location = new System.Drawing.Point(2, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.ShowToolTips = true;
            this.tabs.Size = new System.Drawing.Size(532, 304);
            this.tabs.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.BackColor = System.Drawing.Color.White;
            this.tabMain.Controls.Add(this.labelDeviceInfo);
            this.tabMain.Controls.Add(this.comboBoxDevices);
            this.tabMain.Controls.Add(this.buttonExecute);
            this.tabMain.Controls.Add(this.labelDevice);
            this.tabMain.Controls.Add(this.panelHeartRateDisplay);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Margin = new System.Windows.Forms.Padding(1);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(1, 1, 2, 30);
            this.tabMain.Size = new System.Drawing.Size(524, 278);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            // 
            // labelDeviceInfo
            // 
            this.labelDeviceInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDeviceInfo.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            this.labelDeviceInfo.Location = new System.Drawing.Point(1, 173);
            this.labelDeviceInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelDeviceInfo.Name = "labelDeviceInfo";
            this.labelDeviceInfo.Size = new System.Drawing.Size(521, 20);
            this.labelDeviceInfo.TabIndex = 4;
            this.labelDeviceInfo.Text = "(Selected device will be used as default next time the application launches)";
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
            this.comboBoxDevices.Location = new System.Drawing.Point(1, 143);
            this.comboBoxDevices.Margin = new System.Windows.Forms.Padding(1);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(521, 30);
            this.comboBoxDevices.TabIndex = 0;
            // 
            // buttonExecute
            // 
            this.buttonExecute.AutoSize = true;
            this.buttonExecute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExecute.Enabled = false;
            this.buttonExecute.Font = new System.Drawing.Font("Cascadia Mono", 14F);
            this.buttonExecute.Location = new System.Drawing.Point(1, 203);
            this.buttonExecute.Margin = new System.Windows.Forms.Padding(1);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(521, 45);
            this.buttonExecute.TabIndex = 5;
            this.buttonExecute.Text = "Scanning for Bluetooth Devices...";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // labelDevice
            // 
            this.labelDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDevice.Font = new System.Drawing.Font("Cascadia Mono", 14F);
            this.labelDevice.Location = new System.Drawing.Point(1, 113);
            this.labelDevice.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(521, 30);
            this.labelDevice.TabIndex = 2;
            this.labelDevice.Text = "Select device from the list below:";
            // 
            // panelHeartRateDisplay
            // 
            this.panelHeartRateDisplay.Controls.Add(this.labelBatteryLevel);
            this.panelHeartRateDisplay.Controls.Add(this.labelHeartRateDisplay);
            this.panelHeartRateDisplay.Controls.Add(this.pictureBoxHeartRateDisplay);
            this.panelHeartRateDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeartRateDisplay.Location = new System.Drawing.Point(1, 1);
            this.panelHeartRateDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.panelHeartRateDisplay.Name = "panelHeartRateDisplay";
            this.panelHeartRateDisplay.Size = new System.Drawing.Size(521, 112);
            this.panelHeartRateDisplay.TabIndex = 1;
            // 
            // labelBatteryLevel
            // 
            this.labelBatteryLevel.BackColor = System.Drawing.Color.Transparent;
            this.labelBatteryLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBatteryLevel.Font = new System.Drawing.Font("Cascadia Mono", 10F, System.Drawing.FontStyle.Bold);
            this.labelBatteryLevel.ForeColor = System.Drawing.Color.White;
            this.labelBatteryLevel.Location = new System.Drawing.Point(0, 0);
            this.labelBatteryLevel.Name = "labelBatteryLevel";
            this.labelBatteryLevel.Padding = new System.Windows.Forms.Padding(59, 0, 0, 70);
            this.labelBatteryLevel.Size = new System.Drawing.Size(521, 112);
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
            this.labelHeartRateDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.labelHeartRateDisplay.Size = new System.Drawing.Size(521, 112);
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
            this.pictureBoxHeartRateDisplay.Size = new System.Drawing.Size(521, 112);
            this.pictureBoxHeartRateDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHeartRateDisplay.TabIndex = 1;
            this.pictureBoxHeartRateDisplay.TabStop = false;
            // 
            // tabVRChatSettings
            // 
            this.tabVRChatSettings.BackColor = System.Drawing.Color.White;
            this.tabVRChatSettings.Controls.Add(this.panelAvatar);
            this.tabVRChatSettings.Controls.Add(this.checkBoxUseAvatar);
            this.tabVRChatSettings.Controls.Add(this.panelChatbox);
            this.tabVRChatSettings.Controls.Add(this.buttonSaveVRChatSettings);
            this.tabVRChatSettings.Controls.Add(this.panel1);
            this.tabVRChatSettings.Controls.Add(this.panelOsc);
            this.tabVRChatSettings.Controls.Add(this.labelOsc);
            this.tabVRChatSettings.Location = new System.Drawing.Point(4, 22);
            this.tabVRChatSettings.Margin = new System.Windows.Forms.Padding(1);
            this.tabVRChatSettings.Name = "tabVRChatSettings";
            this.tabVRChatSettings.Padding = new System.Windows.Forms.Padding(1, 1, 1, 30);
            this.tabVRChatSettings.Size = new System.Drawing.Size(524, 278);
            this.tabVRChatSettings.TabIndex = 1;
            this.tabVRChatSettings.Text = "VRChat";
            // 
            // panelAvatar
            // 
            this.panelAvatar.Controls.Add(this.buttonAvatarParameterInfo);
            this.panelAvatar.Controls.Add(this.textBoxAvatarParameter);
            this.panelAvatar.Controls.Add(this.labelAvatarParameter);
            this.panelAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAvatar.Location = new System.Drawing.Point(1, 147);
            this.panelAvatar.Name = "panelAvatar";
            this.panelAvatar.Size = new System.Drawing.Size(522, 33);
            this.panelAvatar.TabIndex = 8;
            // 
            // buttonAvatarParameterInfo
            // 
            this.buttonAvatarParameterInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvatarParameterInfo.Font = new System.Drawing.Font("Cascadia Mono", 11F);
            this.buttonAvatarParameterInfo.Location = new System.Drawing.Point(497, 0);
            this.buttonAvatarParameterInfo.Name = "buttonAvatarParameterInfo";
            this.buttonAvatarParameterInfo.Size = new System.Drawing.Size(23, 23);
            this.buttonAvatarParameterInfo.TabIndex = 8;
            this.buttonAvatarParameterInfo.Text = "?";
            this.buttonAvatarParameterInfo.UseVisualStyleBackColor = true;
            this.buttonAvatarParameterInfo.Click += new System.EventHandler(this.buttonAvatarParameterInfo_Click);
            // 
            // textBoxAvatarParameter
            // 
            this.textBoxAvatarParameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvatarParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxAvatarParameter.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxAvatarParameter.Location = new System.Drawing.Point(348, 0);
            this.textBoxAvatarParameter.Name = "textBoxAvatarParameter";
            this.textBoxAvatarParameter.ReadOnly = true;
            this.textBoxAvatarParameter.Size = new System.Drawing.Size(150, 23);
            this.textBoxAvatarParameter.TabIndex = 7;
            // 
            // labelAvatarParameter
            // 
            this.labelAvatarParameter.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAvatarParameter.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelAvatarParameter.Location = new System.Drawing.Point(0, 0);
            this.labelAvatarParameter.Name = "labelAvatarParameter";
            this.labelAvatarParameter.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelAvatarParameter.Size = new System.Drawing.Size(348, 33);
            this.labelAvatarParameter.TabIndex = 4;
            this.labelAvatarParameter.Text = "Set avatar parameter name: /avatar/parameters/";
            // 
            // checkBoxUseAvatar
            // 
            this.checkBoxUseAvatar.AutoSize = true;
            this.checkBoxUseAvatar.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseAvatar.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseAvatar.Location = new System.Drawing.Point(1, 120);
            this.checkBoxUseAvatar.Name = "checkBoxUseAvatar";
            this.checkBoxUseAvatar.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.checkBoxUseAvatar.Size = new System.Drawing.Size(522, 27);
            this.checkBoxUseAvatar.TabIndex = 1;
            this.checkBoxUseAvatar.Text = "VRChat Avatar";
            this.checkBoxUseAvatar.UseVisualStyleBackColor = true;
            this.checkBoxUseAvatar.CheckedChanged += new System.EventHandler(this.checkBoxUseAvatar_CheckedChanged);
            // 
            // panelChatbox
            // 
            this.panelChatbox.Controls.Add(this.buttonBoxChatboxTextInfo);
            this.panelChatbox.Controls.Add(this.textBoxChatboxText);
            this.panelChatbox.Controls.Add(this.labelChatboxText);
            this.panelChatbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatbox.Location = new System.Drawing.Point(1, 87);
            this.panelChatbox.Name = "panelChatbox";
            this.panelChatbox.Size = new System.Drawing.Size(522, 33);
            this.panelChatbox.TabIndex = 12;
            // 
            // buttonBoxChatboxTextInfo
            // 
            this.buttonBoxChatboxTextInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBoxChatboxTextInfo.Font = new System.Drawing.Font("Cascadia Mono", 11F);
            this.buttonBoxChatboxTextInfo.Location = new System.Drawing.Point(497, 0);
            this.buttonBoxChatboxTextInfo.Name = "buttonBoxChatboxTextInfo";
            this.buttonBoxChatboxTextInfo.Size = new System.Drawing.Size(23, 23);
            this.buttonBoxChatboxTextInfo.TabIndex = 7;
            this.buttonBoxChatboxTextInfo.Text = "?";
            this.buttonBoxChatboxTextInfo.UseVisualStyleBackColor = true;
            this.buttonBoxChatboxTextInfo.Click += new System.EventHandler(this.buttonBoxChatboxTextInfo_Click);
            // 
            // textBoxChatboxText
            // 
            this.textBoxChatboxText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxChatboxText.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxChatboxText.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxChatboxText.Location = new System.Drawing.Point(288, 0);
            this.textBoxChatboxText.MaxLength = 128;
            this.textBoxChatboxText.Name = "textBoxChatboxText";
            this.textBoxChatboxText.ReadOnly = true;
            this.textBoxChatboxText.Size = new System.Drawing.Size(210, 23);
            this.textBoxChatboxText.TabIndex = 6;
            // 
            // labelChatboxText
            // 
            this.labelChatboxText.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelChatboxText.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelChatboxText.Location = new System.Drawing.Point(0, 0);
            this.labelChatboxText.Name = "labelChatboxText";
            this.labelChatboxText.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelChatboxText.Size = new System.Drawing.Size(288, 33);
            this.labelChatboxText.TabIndex = 5;
            this.labelChatboxText.Text = "Set chatbox message template text:";
            // 
            // buttonSaveVRChatSettings
            // 
            this.buttonSaveVRChatSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSaveVRChatSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSaveVRChatSettings.Font = new System.Drawing.Font("Cascadia Mono", 20F);
            this.buttonSaveVRChatSettings.Location = new System.Drawing.Point(1, 203);
            this.buttonSaveVRChatSettings.Name = "buttonSaveVRChatSettings";
            this.buttonSaveVRChatSettings.Size = new System.Drawing.Size(522, 45);
            this.buttonSaveVRChatSettings.TabIndex = 10;
            this.buttonSaveVRChatSettings.Text = "SAVE";
            this.buttonSaveVRChatSettings.UseVisualStyleBackColor = true;
            this.buttonSaveVRChatSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.checkBoxUseChatbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 27);
            this.panel1.TabIndex = 11;
            // 
            // checkBoxUseChatbox
            // 
            this.checkBoxUseChatbox.AutoSize = true;
            this.checkBoxUseChatbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseChatbox.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseChatbox.Location = new System.Drawing.Point(0, 0);
            this.checkBoxUseChatbox.Name = "checkBoxUseChatbox";
            this.checkBoxUseChatbox.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.checkBoxUseChatbox.Size = new System.Drawing.Size(522, 27);
            this.checkBoxUseChatbox.TabIndex = 0;
            this.checkBoxUseChatbox.Text = "VRChat Chatbox";
            this.checkBoxUseChatbox.UseVisualStyleBackColor = true;
            this.checkBoxUseChatbox.CheckedChanged += new System.EventHandler(this.checkBoxUseChatbox_CheckedChanged);
            // 
            // panelOsc
            // 
            this.panelOsc.Controls.Add(this.buttonOscAddressInfo);
            this.panelOsc.Controls.Add(this.textBoxOscAddress);
            this.panelOsc.Controls.Add(this.labelOscInfo);
            this.panelOsc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelOsc.Location = new System.Drawing.Point(1, 27);
            this.panelOsc.Name = "panelOsc";
            this.panelOsc.Size = new System.Drawing.Size(522, 33);
            this.panelOsc.TabIndex = 12;
            // 
            // buttonOscAddressInfo
            // 
            this.buttonOscAddressInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOscAddressInfo.Font = new System.Drawing.Font("Cascadia Mono", 11F);
            this.buttonOscAddressInfo.Location = new System.Drawing.Point(497, 0);
            this.buttonOscAddressInfo.Name = "buttonOscAddressInfo";
            this.buttonOscAddressInfo.Size = new System.Drawing.Size(23, 23);
            this.buttonOscAddressInfo.TabIndex = 9;
            this.buttonOscAddressInfo.Text = "?";
            this.buttonOscAddressInfo.UseVisualStyleBackColor = true;
            this.buttonOscAddressInfo.Click += new System.EventHandler(this.buttonOscAddressInfo_Click);
            // 
            // textBoxOscAddress
            // 
            this.textBoxOscAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOscAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxOscAddress.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxOscAddress.Location = new System.Drawing.Point(348, 0);
            this.textBoxOscAddress.Name = "textBoxOscAddress";
            this.textBoxOscAddress.ReadOnly = true;
            this.textBoxOscAddress.Size = new System.Drawing.Size(150, 23);
            this.textBoxOscAddress.TabIndex = 10;
            // 
            // labelOscInfo
            // 
            this.labelOscInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOscInfo.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelOscInfo.Location = new System.Drawing.Point(0, 0);
            this.labelOscInfo.Name = "labelOscInfo";
            this.labelOscInfo.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelOscInfo.Size = new System.Drawing.Size(348, 33);
            this.labelOscInfo.TabIndex = 5;
            this.labelOscInfo.Text = "(only when Chatbox or Avatar is used)";
            // 
            // labelOsc
            // 
            this.labelOsc.AutoSize = true;
            this.labelOsc.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOsc.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.labelOsc.Location = new System.Drawing.Point(1, 1);
            this.labelOsc.Name = "labelOsc";
            this.labelOsc.Padding = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.labelOsc.Size = new System.Drawing.Size(264, 26);
            this.labelOsc.TabIndex = 5;
            this.labelOsc.Text = "VRChat OSC IP address and port:";
            // 
            // tabWebServerSettings
            // 
            this.tabWebServerSettings.BackColor = System.Drawing.Color.White;
            this.tabWebServerSettings.Controls.Add(this.textBoxWebServerHtml);
            this.tabWebServerSettings.Controls.Add(this.panelWebServerHtml);
            this.tabWebServerSettings.Controls.Add(this.buttonSaveWebServerSettings);
            this.tabWebServerSettings.Controls.Add(this.panelWebServer);
            this.tabWebServerSettings.Controls.Add(this.checkBoxUseWebServer);
            this.tabWebServerSettings.Location = new System.Drawing.Point(4, 22);
            this.tabWebServerSettings.Margin = new System.Windows.Forms.Padding(1);
            this.tabWebServerSettings.Name = "tabWebServerSettings";
            this.tabWebServerSettings.Padding = new System.Windows.Forms.Padding(1, 1, 1, 30);
            this.tabWebServerSettings.Size = new System.Drawing.Size(524, 278);
            this.tabWebServerSettings.TabIndex = 3;
            this.tabWebServerSettings.Text = "Web Server";
            // 
            // textBoxWebServerHtml
            // 
            this.textBoxWebServerHtml.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWebServerHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxWebServerHtml.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxWebServerHtml.Location = new System.Drawing.Point(1, 74);
            this.textBoxWebServerHtml.MaxLength = 16383;
            this.textBoxWebServerHtml.Multiline = true;
            this.textBoxWebServerHtml.Name = "textBoxWebServerHtml";
            this.textBoxWebServerHtml.ReadOnly = true;
            this.textBoxWebServerHtml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxWebServerHtml.Size = new System.Drawing.Size(522, 129);
            this.textBoxWebServerHtml.TabIndex = 8;
            this.textBoxWebServerHtml.WordWrap = false;
            // 
            // panelWebServerHtml
            // 
            this.panelWebServerHtml.BackColor = System.Drawing.Color.Transparent;
            this.panelWebServerHtml.Controls.Add(this.labelWebServerHtml);
            this.panelWebServerHtml.Controls.Add(this.linkLabelWebServerTemplateInstruction);
            this.panelWebServerHtml.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWebServerHtml.Location = new System.Drawing.Point(1, 52);
            this.panelWebServerHtml.Name = "panelWebServerHtml";
            this.panelWebServerHtml.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelWebServerHtml.Size = new System.Drawing.Size(522, 22);
            this.panelWebServerHtml.TabIndex = 13;
            // 
            // labelWebServerHtml
            // 
            this.labelWebServerHtml.AutoSize = true;
            this.labelWebServerHtml.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelWebServerHtml.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.labelWebServerHtml.Location = new System.Drawing.Point(8, 0);
            this.labelWebServerHtml.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelWebServerHtml.Name = "labelWebServerHtml";
            this.labelWebServerHtml.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelWebServerHtml.Size = new System.Drawing.Size(120, 21);
            this.labelWebServerHtml.TabIndex = 12;
            this.labelWebServerHtml.Text = "HTML template:";
            // 
            // linkLabelWebServerTemplateInstruction
            // 
            this.linkLabelWebServerTemplateInstruction.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabelWebServerTemplateInstruction.AutoSize = true;
            this.linkLabelWebServerTemplateInstruction.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabelWebServerTemplateInstruction.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            this.linkLabelWebServerTemplateInstruction.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelWebServerTemplateInstruction.Location = new System.Drawing.Point(269, 0);
            this.linkLabelWebServerTemplateInstruction.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.linkLabelWebServerTemplateInstruction.Name = "linkLabelWebServerTemplateInstruction";
            this.linkLabelWebServerTemplateInstruction.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.linkLabelWebServerTemplateInstruction.Size = new System.Drawing.Size(253, 23);
            this.linkLabelWebServerTemplateInstruction.TabIndex = 14;
            this.linkLabelWebServerTemplateInstruction.TabStop = true;
            this.linkLabelWebServerTemplateInstruction.Text = "Click here for templates and instructions";
            this.linkLabelWebServerTemplateInstruction.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelWebServerTemplateInstruction.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelWebServerTemplateInstruction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelWebServerTemplateInstruction_LinkClicked);
            // 
            // buttonSaveWebServerSettings
            // 
            this.buttonSaveWebServerSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSaveWebServerSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSaveWebServerSettings.Font = new System.Drawing.Font("Cascadia Mono", 20F);
            this.buttonSaveWebServerSettings.Location = new System.Drawing.Point(1, 203);
            this.buttonSaveWebServerSettings.Name = "buttonSaveWebServerSettings";
            this.buttonSaveWebServerSettings.Size = new System.Drawing.Size(522, 45);
            this.buttonSaveWebServerSettings.TabIndex = 11;
            this.buttonSaveWebServerSettings.Text = "SAVE";
            this.buttonSaveWebServerSettings.UseVisualStyleBackColor = true;
            this.buttonSaveWebServerSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // panelWebServer
            // 
            this.panelWebServer.BackColor = System.Drawing.Color.Transparent;
            this.panelWebServer.Controls.Add(this.buttonWebServerPortInfo);
            this.panelWebServer.Controls.Add(this.textBoxWebServerPort);
            this.panelWebServer.Controls.Add(this.labelWebServerPort);
            this.panelWebServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWebServer.Location = new System.Drawing.Point(1, 28);
            this.panelWebServer.Name = "panelWebServer";
            this.panelWebServer.Size = new System.Drawing.Size(522, 24);
            this.panelWebServer.TabIndex = 9;
            // 
            // buttonWebServerPortInfo
            // 
            this.buttonWebServerPortInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWebServerPortInfo.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.buttonWebServerPortInfo.Location = new System.Drawing.Point(497, 0);
            this.buttonWebServerPortInfo.Name = "buttonWebServerPortInfo";
            this.buttonWebServerPortInfo.Size = new System.Drawing.Size(23, 23);
            this.buttonWebServerPortInfo.TabIndex = 9;
            this.buttonWebServerPortInfo.Text = "?";
            this.buttonWebServerPortInfo.UseVisualStyleBackColor = true;
            this.buttonWebServerPortInfo.Click += new System.EventHandler(this.buttonWebServerPortInfo_Click);
            // 
            // textBoxWebServerPort
            // 
            this.textBoxWebServerPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWebServerPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxWebServerPort.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxWebServerPort.Location = new System.Drawing.Point(348, 0);
            this.textBoxWebServerPort.Name = "textBoxWebServerPort";
            this.textBoxWebServerPort.ReadOnly = true;
            this.textBoxWebServerPort.Size = new System.Drawing.Size(150, 23);
            this.textBoxWebServerPort.TabIndex = 6;
            // 
            // labelWebServerPort
            // 
            this.labelWebServerPort.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelWebServerPort.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelWebServerPort.Location = new System.Drawing.Point(0, 0);
            this.labelWebServerPort.Name = "labelWebServerPort";
            this.labelWebServerPort.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelWebServerPort.Size = new System.Drawing.Size(348, 24);
            this.labelWebServerPort.TabIndex = 5;
            this.labelWebServerPort.Text = "Set port number for the web server:";
            // 
            // checkBoxUseWebServer
            // 
            this.checkBoxUseWebServer.AutoSize = true;
            this.checkBoxUseWebServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseWebServer.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseWebServer.Location = new System.Drawing.Point(1, 1);
            this.checkBoxUseWebServer.Name = "checkBoxUseWebServer";
            this.checkBoxUseWebServer.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.checkBoxUseWebServer.Size = new System.Drawing.Size(522, 27);
            this.checkBoxUseWebServer.TabIndex = 2;
            this.checkBoxUseWebServer.Text = "Web Server";
            this.checkBoxUseWebServer.UseVisualStyleBackColor = true;
            this.checkBoxUseWebServer.CheckedChanged += new System.EventHandler(this.checkBoxUseWebServer_CheckedChanged);
            // 
            // tabDiscordSettings
            // 
            this.tabDiscordSettings.BackColor = System.Drawing.Color.White;
            this.tabDiscordSettings.Controls.Add(this.buttonSaveDiscordSettings);
            this.tabDiscordSettings.Controls.Add(this.labelDiscordInfo);
            this.tabDiscordSettings.Controls.Add(this.panelDiscordStateText);
            this.tabDiscordSettings.Controls.Add(this.labelDiscordStateText);
            this.tabDiscordSettings.Controls.Add(this.panelDiscordIdleText);
            this.tabDiscordSettings.Controls.Add(this.labelDiscordIdleText);
            this.tabDiscordSettings.Controls.Add(this.panelDiscordActiveText);
            this.tabDiscordSettings.Controls.Add(this.labelDiscordActiveText);
            this.tabDiscordSettings.Controls.Add(this.checkBoxUseDiscord);
            this.tabDiscordSettings.Location = new System.Drawing.Point(4, 22);
            this.tabDiscordSettings.Margin = new System.Windows.Forms.Padding(1);
            this.tabDiscordSettings.Name = "tabDiscordSettings";
            this.tabDiscordSettings.Padding = new System.Windows.Forms.Padding(1, 1, 1, 30);
            this.tabDiscordSettings.Size = new System.Drawing.Size(524, 278);
            this.tabDiscordSettings.TabIndex = 4;
            this.tabDiscordSettings.Text = "Discord";
            // 
            // buttonSaveDiscordSettings
            // 
            this.buttonSaveDiscordSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSaveDiscordSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSaveDiscordSettings.Font = new System.Drawing.Font("Cascadia Mono", 20F);
            this.buttonSaveDiscordSettings.Location = new System.Drawing.Point(1, 203);
            this.buttonSaveDiscordSettings.Name = "buttonSaveDiscordSettings";
            this.buttonSaveDiscordSettings.Size = new System.Drawing.Size(522, 45);
            this.buttonSaveDiscordSettings.TabIndex = 16;
            this.buttonSaveDiscordSettings.Text = "SAVE";
            this.buttonSaveDiscordSettings.UseVisualStyleBackColor = true;
            this.buttonSaveDiscordSettings.Click += new System.EventHandler(this.buttonSaveSettings_Click);
            // 
            // labelDiscordInfo
            // 
            this.labelDiscordInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDiscordInfo.Font = new System.Drawing.Font("Cascadia Mono", 8F);
            this.labelDiscordInfo.Location = new System.Drawing.Point(1, 172);
            this.labelDiscordInfo.Margin = new System.Windows.Forms.Padding(0);
            this.labelDiscordInfo.Name = "labelDiscordInfo";
            this.labelDiscordInfo.Size = new System.Drawing.Size(522, 20);
            this.labelDiscordInfo.TabIndex = 15;
            this.labelDiscordInfo.Text = "(Remember: HR in Discord Activity is updated every 15s)";
            this.labelDiscordInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelDiscordStateText
            // 
            this.panelDiscordStateText.BackColor = System.Drawing.Color.Transparent;
            this.panelDiscordStateText.Controls.Add(this.textBoxDiscordStateText);
            this.panelDiscordStateText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiscordStateText.Location = new System.Drawing.Point(1, 149);
            this.panelDiscordStateText.Name = "panelDiscordStateText";
            this.panelDiscordStateText.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.panelDiscordStateText.Size = new System.Drawing.Size(522, 23);
            this.panelDiscordStateText.TabIndex = 14;
            // 
            // textBoxDiscordStateText
            // 
            this.textBoxDiscordStateText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscordStateText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscordStateText.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxDiscordStateText.Location = new System.Drawing.Point(11, 0);
            this.textBoxDiscordStateText.MaxLength = 128;
            this.textBoxDiscordStateText.Name = "textBoxDiscordStateText";
            this.textBoxDiscordStateText.ReadOnly = true;
            this.textBoxDiscordStateText.Size = new System.Drawing.Size(500, 23);
            this.textBoxDiscordStateText.TabIndex = 8;
            // 
            // labelDiscordStateText
            // 
            this.labelDiscordStateText.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDiscordStateText.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelDiscordStateText.Location = new System.Drawing.Point(1, 124);
            this.labelDiscordStateText.Name = "labelDiscordStateText";
            this.labelDiscordStateText.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelDiscordStateText.Size = new System.Drawing.Size(522, 25);
            this.labelDiscordStateText.TabIndex = 13;
            this.labelDiscordStateText.Text = "State - HR value description:";
            // 
            // panelDiscordIdleText
            // 
            this.panelDiscordIdleText.BackColor = System.Drawing.Color.Transparent;
            this.panelDiscordIdleText.Controls.Add(this.textBoxDiscordIdleText);
            this.panelDiscordIdleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiscordIdleText.Location = new System.Drawing.Point(1, 101);
            this.panelDiscordIdleText.Name = "panelDiscordIdleText";
            this.panelDiscordIdleText.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.panelDiscordIdleText.Size = new System.Drawing.Size(522, 23);
            this.panelDiscordIdleText.TabIndex = 12;
            // 
            // textBoxDiscordIdleText
            // 
            this.textBoxDiscordIdleText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscordIdleText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscordIdleText.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxDiscordIdleText.Location = new System.Drawing.Point(11, 0);
            this.textBoxDiscordIdleText.MaxLength = 128;
            this.textBoxDiscordIdleText.Name = "textBoxDiscordIdleText";
            this.textBoxDiscordIdleText.ReadOnly = true;
            this.textBoxDiscordIdleText.Size = new System.Drawing.Size(500, 23);
            this.textBoxDiscordIdleText.TabIndex = 8;
            // 
            // labelDiscordIdleText
            // 
            this.labelDiscordIdleText.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDiscordIdleText.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelDiscordIdleText.Location = new System.Drawing.Point(1, 76);
            this.labelDiscordIdleText.Name = "labelDiscordIdleText";
            this.labelDiscordIdleText.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelDiscordIdleText.Size = new System.Drawing.Size(522, 25);
            this.labelDiscordIdleText.TabIndex = 11;
            this.labelDiscordIdleText.Text = "Details - Description when HR = 0:";
            // 
            // panelDiscordActiveText
            // 
            this.panelDiscordActiveText.BackColor = System.Drawing.Color.Transparent;
            this.panelDiscordActiveText.Controls.Add(this.textBoxDiscordActiveText);
            this.panelDiscordActiveText.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiscordActiveText.Location = new System.Drawing.Point(1, 53);
            this.panelDiscordActiveText.Name = "panelDiscordActiveText";
            this.panelDiscordActiveText.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.panelDiscordActiveText.Size = new System.Drawing.Size(522, 23);
            this.panelDiscordActiveText.TabIndex = 10;
            // 
            // textBoxDiscordActiveText
            // 
            this.textBoxDiscordActiveText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiscordActiveText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscordActiveText.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.textBoxDiscordActiveText.Location = new System.Drawing.Point(11, 0);
            this.textBoxDiscordActiveText.MaxLength = 128;
            this.textBoxDiscordActiveText.Name = "textBoxDiscordActiveText";
            this.textBoxDiscordActiveText.ReadOnly = true;
            this.textBoxDiscordActiveText.Size = new System.Drawing.Size(500, 23);
            this.textBoxDiscordActiveText.TabIndex = 8;
            // 
            // labelDiscordActiveText
            // 
            this.labelDiscordActiveText.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDiscordActiveText.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.labelDiscordActiveText.Location = new System.Drawing.Point(1, 28);
            this.labelDiscordActiveText.Name = "labelDiscordActiveText";
            this.labelDiscordActiveText.Padding = new System.Windows.Forms.Padding(8, 3, 0, 0);
            this.labelDiscordActiveText.Size = new System.Drawing.Size(522, 25);
            this.labelDiscordActiveText.TabIndex = 6;
            this.labelDiscordActiveText.Text = "Details - Description when HR > 0:";
            // 
            // checkBoxUseDiscord
            // 
            this.checkBoxUseDiscord.AutoSize = true;
            this.checkBoxUseDiscord.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxUseDiscord.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.checkBoxUseDiscord.Location = new System.Drawing.Point(1, 1);
            this.checkBoxUseDiscord.Name = "checkBoxUseDiscord";
            this.checkBoxUseDiscord.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.checkBoxUseDiscord.Size = new System.Drawing.Size(522, 27);
            this.checkBoxUseDiscord.TabIndex = 3;
            this.checkBoxUseDiscord.Text = "Discord Activity";
            this.checkBoxUseDiscord.UseVisualStyleBackColor = true;
            this.checkBoxUseDiscord.CheckedChanged += new System.EventHandler(this.checkBoxUseDiscord_CheckedChanged);
            // 
            // tabInfo
            // 
            this.tabInfo.BackColor = System.Drawing.Color.White;
            this.tabInfo.Controls.Add(this.panelInfoBottom);
            this.tabInfo.Controls.Add(this.panelInfoTop);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(1);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(1, 1, 1, 30);
            this.tabInfo.Size = new System.Drawing.Size(524, 278);
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
            this.panelInfoBottom.Location = new System.Drawing.Point(1, 152);
            this.panelInfoBottom.Margin = new System.Windows.Forms.Padding(1);
            this.panelInfoBottom.Name = "panelInfoBottom";
            this.panelInfoBottom.Size = new System.Drawing.Size(522, 96);
            this.panelInfoBottom.TabIndex = 1;
            // 
            // linkLabelInfoProjectUrl
            // 
            this.linkLabelInfoProjectUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelInfoProjectUrl.Font = new System.Drawing.Font("Cascadia Mono", 9F);
            this.linkLabelInfoProjectUrl.Location = new System.Drawing.Point(0, 65);
            this.linkLabelInfoProjectUrl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.linkLabelInfoProjectUrl.Name = "linkLabelInfoProjectUrl";
            this.linkLabelInfoProjectUrl.Size = new System.Drawing.Size(522, 19);
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
            this.linkLabelInfoAuthorUrl.Location = new System.Drawing.Point(0, 46);
            this.linkLabelInfoAuthorUrl.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.linkLabelInfoAuthorUrl.Name = "linkLabelInfoAuthorUrl";
            this.linkLabelInfoAuthorUrl.Size = new System.Drawing.Size(522, 19);
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
            this.labelInfoAuthorName.Location = new System.Drawing.Point(0, 27);
            this.labelInfoAuthorName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelInfoAuthorName.Name = "labelInfoAuthorName";
            this.labelInfoAuthorName.Size = new System.Drawing.Size(522, 19);
            this.labelInfoAuthorName.TabIndex = 1;
            this.labelInfoAuthorName.Text = "Author: Richard Virgosky";
            this.labelInfoAuthorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfoAppName
            // 
            this.labelInfoAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInfoAppName.Font = new System.Drawing.Font("Cascadia Mono", 15F);
            this.labelInfoAppName.Location = new System.Drawing.Point(0, 0);
            this.labelInfoAppName.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labelInfoAppName.Name = "labelInfoAppName";
            this.labelInfoAppName.Size = new System.Drawing.Size(522, 27);
            this.labelInfoAppName.TabIndex = 0;
            this.labelInfoAppName.Text = "VRChat HeartRate Monitor v0.0";
            this.labelInfoAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelInfoTop
            // 
            this.panelInfoTop.Controls.Add(this.pictureBoxInfoAuthor);
            this.panelInfoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfoTop.Location = new System.Drawing.Point(1, 1);
            this.panelInfoTop.Margin = new System.Windows.Forms.Padding(1);
            this.panelInfoTop.Name = "panelInfoTop";
            this.panelInfoTop.Size = new System.Drawing.Size(522, 152);
            this.panelInfoTop.TabIndex = 0;
            // 
            // pictureBoxInfoAuthor
            // 
            this.pictureBoxInfoAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxInfoAuthor.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfoAuthor.Image")));
            this.pictureBoxInfoAuthor.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxInfoAuthor.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBoxInfoAuthor.Name = "pictureBoxInfoAuthor";
            this.pictureBoxInfoAuthor.Size = new System.Drawing.Size(522, 152);
            this.pictureBoxInfoAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInfoAuthor.TabIndex = 0;
            this.pictureBoxInfoAuthor.TabStop = false;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.White;
            this.panelFooter.Controls.Add(this.pictureBoxFooterDiscord);
            this.panelFooter.Controls.Add(this.linkLabelFooterWebsite);
            this.panelFooter.Location = new System.Drawing.Point(4, 274);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(1);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Padding = new System.Windows.Forms.Padding(8, 0, 2, 0);
            this.panelFooter.Size = new System.Drawing.Size(526, 30);
            this.panelFooter.TabIndex = 0;
            // 
            // pictureBoxFooterDiscord
            // 
            this.pictureBoxFooterDiscord.BackColor = System.Drawing.Color.White;
            this.pictureBoxFooterDiscord.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFooterDiscord.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxFooterDiscord.Image = global::VRChatHeartRateMonitor.Properties.Resources.discord;
            this.pictureBoxFooterDiscord.Location = new System.Drawing.Point(8, 0);
            this.pictureBoxFooterDiscord.Name = "pictureBoxFooterDiscord";
            this.pictureBoxFooterDiscord.Size = new System.Drawing.Size(130, 30);
            this.pictureBoxFooterDiscord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFooterDiscord.TabIndex = 9;
            this.pictureBoxFooterDiscord.TabStop = false;
            this.pictureBoxFooterDiscord.Click += new System.EventHandler(this.pictureBoxFooterDiscord_Click);
            // 
            // linkLabelFooterWebsite
            // 
            this.linkLabelFooterWebsite.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.linkLabelFooterWebsite.AutoSize = true;
            this.linkLabelFooterWebsite.BackColor = System.Drawing.Color.White;
            this.linkLabelFooterWebsite.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLabelFooterWebsite.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            this.linkLabelFooterWebsite.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelFooterWebsite.Location = new System.Drawing.Point(300, 0);
            this.linkLabelFooterWebsite.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.linkLabelFooterWebsite.Name = "linkLabelFooterWebsite";
            this.linkLabelFooterWebsite.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.linkLabelFooterWebsite.Size = new System.Drawing.Size(224, 26);
            this.linkLabelFooterWebsite.TabIndex = 8;
            this.linkLabelFooterWebsite.TabStop = true;
            this.linkLabelFooterWebsite.Text = "Created by Richard Virgosky";
            this.linkLabelFooterWebsite.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.linkLabelFooterWebsite.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLabelFooterWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFooterWebsite_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 306);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.tabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VRChat Heart Rate Monitor";
            this.tabs.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.panelHeartRateDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeartRateDisplay)).EndInit();
            this.tabVRChatSettings.ResumeLayout(false);
            this.tabVRChatSettings.PerformLayout();
            this.panelAvatar.ResumeLayout(false);
            this.panelAvatar.PerformLayout();
            this.panelChatbox.ResumeLayout(false);
            this.panelChatbox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelOsc.ResumeLayout(false);
            this.panelOsc.PerformLayout();
            this.tabWebServerSettings.ResumeLayout(false);
            this.tabWebServerSettings.PerformLayout();
            this.panelWebServerHtml.ResumeLayout(false);
            this.panelWebServerHtml.PerformLayout();
            this.panelWebServer.ResumeLayout(false);
            this.panelWebServer.PerformLayout();
            this.tabDiscordSettings.ResumeLayout(false);
            this.tabDiscordSettings.PerformLayout();
            this.panelDiscordStateText.ResumeLayout(false);
            this.panelDiscordStateText.PerformLayout();
            this.panelDiscordIdleText.ResumeLayout(false);
            this.panelDiscordIdleText.PerformLayout();
            this.panelDiscordActiveText.ResumeLayout(false);
            this.panelDiscordActiveText.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.panelInfoBottom.ResumeLayout(false);
            this.panelInfoTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoAuthor)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFooterDiscord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TabPage tabVRChatSettings;
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
        private System.Windows.Forms.CheckBox checkBoxUseWebServer;
        private System.Windows.Forms.CheckBox checkBoxUseAvatar;
        private System.Windows.Forms.Panel panelAvatar;
        private System.Windows.Forms.Button buttonSaveVRChatSettings;
        private System.Windows.Forms.Button buttonAvatarParameterInfo;
        private System.Windows.Forms.Button buttonWebServerPortInfo;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Panel panelChatbox;
        private System.Windows.Forms.Panel panelOsc;
        private System.Windows.Forms.Label labelChatboxText;
        private System.Windows.Forms.Label labelOsc;
        private System.Windows.Forms.Label labelOscInfo;
        private System.Windows.Forms.Button buttonBoxChatboxTextInfo;
        private System.Windows.Forms.TextBox textBoxChatboxText;
        private System.Windows.Forms.Label labelBatteryLevel;
        private System.Windows.Forms.PictureBox pictureBoxFooterDiscord;
        private System.Windows.Forms.Panel panelInfoBottom;
        private System.Windows.Forms.LinkLabel linkLabelInfoProjectUrl;
        private System.Windows.Forms.LinkLabel linkLabelInfoAuthorUrl;
        private System.Windows.Forms.Label labelInfoAuthorName;
        private System.Windows.Forms.Label labelInfoAppName;
        private System.Windows.Forms.Panel panelInfoTop;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.PictureBox pictureBoxInfoAuthor;
        private System.Windows.Forms.TabPage tabWebServerSettings;
        private System.Windows.Forms.Panel panelWebServer;
        private System.Windows.Forms.TabPage tabDiscordSettings;
        private System.Windows.Forms.TextBox textBoxOscAddress;
        private System.Windows.Forms.Button buttonOscAddressInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxUseChatbox;
        private System.Windows.Forms.CheckBox checkBoxUseDiscord;
        private System.Windows.Forms.Label labelDiscordActiveText;
        private System.Windows.Forms.TextBox textBoxDiscordActiveText;
        private System.Windows.Forms.Panel panelDiscordActiveText;
        private System.Windows.Forms.Label labelDiscordStateText;
        private System.Windows.Forms.Panel panelDiscordIdleText;
        private System.Windows.Forms.TextBox textBoxDiscordIdleText;
        private System.Windows.Forms.Label labelDiscordIdleText;
        private System.Windows.Forms.Panel panelDiscordStateText;
        private System.Windows.Forms.TextBox textBoxDiscordStateText;
        private System.Windows.Forms.Label labelDiscordInfo;
        private System.Windows.Forms.Button buttonSaveWebServerSettings;
        private System.Windows.Forms.Button buttonSaveDiscordSettings;
        private System.Windows.Forms.Panel panelWebServerHtml;
        private System.Windows.Forms.Label labelWebServerHtml;
        private System.Windows.Forms.LinkLabel linkLabelWebServerTemplateInstruction;
        private System.Windows.Forms.TextBox textBoxWebServerHtml;
    }
}

