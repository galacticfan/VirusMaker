namespace VirusMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.otherOptionsGroup = new System.Windows.Forms.GroupBox();
            this.timeToWait_Value = new System.Windows.Forms.NumericUpDown();
            this.copyToStartup_Label = new System.Windows.Forms.CheckBox();
            this.readOnly_CB = new System.Windows.Forms.CheckBox();
            this.shutdownComp_CB = new System.Windows.Forms.CheckBox();
            this.customCode = new System.Windows.Forms.TextBox();
            this.fileVisibility = new System.Windows.Forms.ComboBox();
            this.customCode_Label = new System.Windows.Forms.Label();
            this.timeToWait_Label = new System.Windows.Forms.Label();
            this.fileVisibility_Label = new System.Windows.Forms.Label();
            this.potHarmfullGroup = new System.Windows.Forms.GroupBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.dltMyDocuments_CB = new System.Windows.Forms.CheckBox();
            this.disableTaskMng_CB = new System.Windows.Forms.CheckBox();
            this.justForfunGroup = new System.Windows.Forms.GroupBox();
            this.spamErrorMsg_Label = new System.Windows.Forms.Label();
            this.spamErrorTitle_Label = new System.Windows.Forms.Label();
            this.spamErrorMsg_Input = new System.Windows.Forms.TextBox();
            this.spamErrorTitle_Input = new System.Windows.Forms.TextBox();
            this.spamError_Label = new System.Windows.Forms.Label();
            this.bombDesktop_CB = new System.Windows.Forms.CheckBox();
            this.minimiseWindows_CB = new System.Windows.Forms.CheckBox();
            this.openCloseCD_CB = new System.Windows.Forms.CheckBox();
            this.swapMouseBtn_CB = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.virusName_Label = new System.Windows.Forms.Label();
            this.saveLocation_Label = new System.Windows.Forms.Label();
            this.virusName = new System.Windows.Forms.TextBox();
            this.saveLocation_Display = new System.Windows.Forms.TextBox();
            this.msgLog_Label = new System.Windows.Forms.Label();
            this.msgLog = new System.Windows.Forms.TextBox();
            this.createVirusBtn = new System.Windows.Forms.Button();
            this.saveLocationBtn = new System.Windows.Forms.Button();
            this.dltLastSaveBtn = new System.Windows.Forms.Button();
            this.clearSettingsBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.otherOptionsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToWait_Value)).BeginInit();
            this.potHarmfullGroup.SuspendLayout();
            this.justForfunGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.otherOptionsGroup);
            this.splitContainer1.Panel1.Controls.Add(this.potHarmfullGroup);
            this.splitContainer1.Panel1.Controls.Add(this.justForfunGroup);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.virusName_Label);
            this.splitContainer1.Panel2.Controls.Add(this.saveLocation_Label);
            this.splitContainer1.Panel2.Controls.Add(this.virusName);
            this.splitContainer1.Panel2.Controls.Add(this.saveLocation_Display);
            this.splitContainer1.Panel2.Controls.Add(this.msgLog_Label);
            this.splitContainer1.Panel2.Controls.Add(this.msgLog);
            this.splitContainer1.Panel2.Controls.Add(this.createVirusBtn);
            this.splitContainer1.Panel2.Controls.Add(this.saveLocationBtn);
            this.splitContainer1.Panel2.Controls.Add(this.dltLastSaveBtn);
            this.splitContainer1.Panel2.Controls.Add(this.clearSettingsBtn);
            this.splitContainer1.Size = new System.Drawing.Size(584, 339);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // otherOptionsGroup
            // 
            this.otherOptionsGroup.Controls.Add(this.timeToWait_Value);
            this.otherOptionsGroup.Controls.Add(this.copyToStartup_Label);
            this.otherOptionsGroup.Controls.Add(this.readOnly_CB);
            this.otherOptionsGroup.Controls.Add(this.shutdownComp_CB);
            this.otherOptionsGroup.Controls.Add(this.customCode);
            this.otherOptionsGroup.Controls.Add(this.fileVisibility);
            this.otherOptionsGroup.Controls.Add(this.customCode_Label);
            this.otherOptionsGroup.Controls.Add(this.timeToWait_Label);
            this.otherOptionsGroup.Controls.Add(this.fileVisibility_Label);
            this.otherOptionsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherOptionsGroup.Location = new System.Drawing.Point(7, 217);
            this.otherOptionsGroup.Name = "otherOptionsGroup";
            this.otherOptionsGroup.Size = new System.Drawing.Size(386, 117);
            this.otherOptionsGroup.TabIndex = 2;
            this.otherOptionsGroup.TabStop = false;
            this.otherOptionsGroup.Text = "Other Options:";
            // 
            // timeToWait_Value
            // 
            this.timeToWait_Value.Location = new System.Drawing.Point(89, 39);
            this.timeToWait_Value.Name = "timeToWait_Value";
            this.timeToWait_Value.Size = new System.Drawing.Size(35, 20);
            this.timeToWait_Value.TabIndex = 5;
            // 
            // copyToStartup_Label
            // 
            this.copyToStartup_Label.AutoSize = true;
            this.copyToStartup_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyToStartup_Label.Location = new System.Drawing.Point(6, 93);
            this.copyToStartup_Label.Name = "copyToStartup_Label";
            this.copyToStartup_Label.Size = new System.Drawing.Size(155, 17);
            this.copyToStartup_Label.TabIndex = 0;
            this.copyToStartup_Label.Text = "Copy Virus to startup Folder";
            this.copyToStartup_Label.UseVisualStyleBackColor = true;
            // 
            // readOnly_CB
            // 
            this.readOnly_CB.AutoSize = true;
            this.readOnly_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readOnly_CB.Location = new System.Drawing.Point(5, 71);
            this.readOnly_CB.Name = "readOnly_CB";
            this.readOnly_CB.Size = new System.Drawing.Size(132, 17);
            this.readOnly_CB.TabIndex = 0;
            this.readOnly_CB.Text = "Make Virus Read Only";
            this.readOnly_CB.UseVisualStyleBackColor = true;
            // 
            // shutdownComp_CB
            // 
            this.shutdownComp_CB.AutoSize = true;
            this.shutdownComp_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shutdownComp_CB.Location = new System.Drawing.Point(7, 19);
            this.shutdownComp_CB.Name = "shutdownComp_CB";
            this.shutdownComp_CB.Size = new System.Drawing.Size(122, 17);
            this.shutdownComp_CB.TabIndex = 0;
            this.shutdownComp_CB.Text = "Shutdown Computer";
            this.shutdownComp_CB.UseVisualStyleBackColor = true;
            // 
            // customCode
            // 
            this.customCode.Location = new System.Drawing.Point(196, 33);
            this.customCode.Multiline = true;
            this.customCode.Name = "customCode";
            this.customCode.Size = new System.Drawing.Size(184, 54);
            this.customCode.TabIndex = 4;
            // 
            // fileVisibility
            // 
            this.fileVisibility.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileVisibility.FormattingEnabled = true;
            this.fileVisibility.Items.AddRange(new object[] {
            "Visible",
            "Hidden"});
            this.fileVisibility.Location = new System.Drawing.Point(260, 90);
            this.fileVisibility.Name = "fileVisibility";
            this.fileVisibility.Size = new System.Drawing.Size(120, 21);
            this.fileVisibility.TabIndex = 0;
            this.fileVisibility.Text = "Visible";
            // 
            // customCode_Label
            // 
            this.customCode_Label.AutoSize = true;
            this.customCode_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCode_Label.Location = new System.Drawing.Point(195, 19);
            this.customCode_Label.Name = "customCode_Label";
            this.customCode_Label.Size = new System.Drawing.Size(73, 13);
            this.customCode_Label.TabIndex = 3;
            this.customCode_Label.Text = "Custom Code:";
            // 
            // timeToWait_Label
            // 
            this.timeToWait_Label.AutoSize = true;
            this.timeToWait_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeToWait_Label.Location = new System.Drawing.Point(6, 41);
            this.timeToWait_Label.Name = "timeToWait_Label";
            this.timeToWait_Label.Size = new System.Drawing.Size(86, 13);
            this.timeToWait_Label.TabIndex = 3;
            this.timeToWait_Label.Text = "Seconds to wait:";
            // 
            // fileVisibility_Label
            // 
            this.fileVisibility_Label.AutoSize = true;
            this.fileVisibility_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileVisibility_Label.Location = new System.Drawing.Point(195, 93);
            this.fileVisibility_Label.Name = "fileVisibility_Label";
            this.fileVisibility_Label.Size = new System.Drawing.Size(65, 13);
            this.fileVisibility_Label.TabIndex = 3;
            this.fileVisibility_Label.Text = "File Visibility:";
            // 
            // potHarmfullGroup
            // 
            this.potHarmfullGroup.Controls.Add(this.checkBox7);
            this.potHarmfullGroup.Controls.Add(this.dltMyDocuments_CB);
            this.potHarmfullGroup.Controls.Add(this.disableTaskMng_CB);
            this.potHarmfullGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.potHarmfullGroup.Location = new System.Drawing.Point(7, 123);
            this.potHarmfullGroup.Name = "potHarmfullGroup";
            this.potHarmfullGroup.Size = new System.Drawing.Size(145, 88);
            this.potHarmfullGroup.TabIndex = 1;
            this.potHarmfullGroup.TabStop = false;
            this.potHarmfullGroup.Text = "Potentially Harmfull:";
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.Location = new System.Drawing.Point(7, 66);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(135, 17);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Text = "Delete \'My Documents\'";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // dltMyDocuments_CB
            // 
            this.dltMyDocuments_CB.AutoSize = true;
            this.dltMyDocuments_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dltMyDocuments_CB.Location = new System.Drawing.Point(7, 43);
            this.dltMyDocuments_CB.Name = "dltMyDocuments_CB";
            this.dltMyDocuments_CB.Size = new System.Drawing.Size(135, 17);
            this.dltMyDocuments_CB.TabIndex = 0;
            this.dltMyDocuments_CB.Text = "Delete \'My Documents\'";
            this.dltMyDocuments_CB.UseVisualStyleBackColor = true;
            // 
            // disableTaskMng_CB
            // 
            this.disableTaskMng_CB.AutoSize = true;
            this.disableTaskMng_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disableTaskMng_CB.Location = new System.Drawing.Point(7, 20);
            this.disableTaskMng_CB.Name = "disableTaskMng_CB";
            this.disableTaskMng_CB.Size = new System.Drawing.Size(129, 17);
            this.disableTaskMng_CB.TabIndex = 0;
            this.disableTaskMng_CB.Text = "Disable Taskmanager";
            this.disableTaskMng_CB.UseVisualStyleBackColor = true;
            // 
            // justForfunGroup
            // 
            this.justForfunGroup.Controls.Add(this.spamErrorMsg_Label);
            this.justForfunGroup.Controls.Add(this.spamErrorTitle_Label);
            this.justForfunGroup.Controls.Add(this.spamErrorMsg_Input);
            this.justForfunGroup.Controls.Add(this.spamErrorTitle_Input);
            this.justForfunGroup.Controls.Add(this.spamError_Label);
            this.justForfunGroup.Controls.Add(this.bombDesktop_CB);
            this.justForfunGroup.Controls.Add(this.minimiseWindows_CB);
            this.justForfunGroup.Controls.Add(this.openCloseCD_CB);
            this.justForfunGroup.Controls.Add(this.swapMouseBtn_CB);
            this.justForfunGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justForfunGroup.Location = new System.Drawing.Point(7, 6);
            this.justForfunGroup.Name = "justForfunGroup";
            this.justForfunGroup.Size = new System.Drawing.Size(386, 111);
            this.justForfunGroup.TabIndex = 0;
            this.justForfunGroup.TabStop = false;
            this.justForfunGroup.Text = "Just for Fun:";
            // 
            // spamErrorMsg_Label
            // 
            this.spamErrorMsg_Label.AutoSize = true;
            this.spamErrorMsg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spamErrorMsg_Label.Location = new System.Drawing.Point(160, 65);
            this.spamErrorMsg_Label.Name = "spamErrorMsg_Label";
            this.spamErrorMsg_Label.Size = new System.Drawing.Size(53, 13);
            this.spamErrorMsg_Label.TabIndex = 3;
            this.spamErrorMsg_Label.Text = "Message:";
            // 
            // spamErrorTitle_Label
            // 
            this.spamErrorTitle_Label.AutoSize = true;
            this.spamErrorTitle_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spamErrorTitle_Label.Location = new System.Drawing.Point(160, 37);
            this.spamErrorTitle_Label.Name = "spamErrorTitle_Label";
            this.spamErrorTitle_Label.Size = new System.Drawing.Size(30, 13);
            this.spamErrorTitle_Label.TabIndex = 3;
            this.spamErrorTitle_Label.Text = "Title:";
            // 
            // spamErrorMsg_Input
            // 
            this.spamErrorMsg_Input.Location = new System.Drawing.Point(219, 62);
            this.spamErrorMsg_Input.Multiline = true;
            this.spamErrorMsg_Input.Name = "spamErrorMsg_Input";
            this.spamErrorMsg_Input.Size = new System.Drawing.Size(161, 43);
            this.spamErrorMsg_Input.TabIndex = 2;
            // 
            // spamErrorTitle_Input
            // 
            this.spamErrorTitle_Input.Location = new System.Drawing.Point(196, 35);
            this.spamErrorTitle_Input.Name = "spamErrorTitle_Input";
            this.spamErrorTitle_Input.Size = new System.Drawing.Size(184, 20);
            this.spamErrorTitle_Input.TabIndex = 2;
            // 
            // spamError_Label
            // 
            this.spamError_Label.AutoSize = true;
            this.spamError_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spamError_Label.Location = new System.Drawing.Point(160, 19);
            this.spamError_Label.Name = "spamError_Label";
            this.spamError_Label.Size = new System.Drawing.Size(163, 13);
            this.spamError_Label.TabIndex = 1;
            this.spamError_Label.Text = "Spam With Error Messages:";
            // 
            // bombDesktop_CB
            // 
            this.bombDesktop_CB.AutoSize = true;
            this.bombDesktop_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bombDesktop_CB.Location = new System.Drawing.Point(6, 88);
            this.bombDesktop_CB.Name = "bombDesktop_CB";
            this.bombDesktop_CB.Size = new System.Drawing.Size(96, 17);
            this.bombDesktop_CB.TabIndex = 0;
            this.bombDesktop_CB.Text = "Bomb Desktop";
            this.bombDesktop_CB.UseVisualStyleBackColor = true;
            // 
            // minimiseWindows_CB
            // 
            this.minimiseWindows_CB.AutoSize = true;
            this.minimiseWindows_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimiseWindows_CB.Location = new System.Drawing.Point(6, 65);
            this.minimiseWindows_CB.Name = "minimiseWindows_CB";
            this.minimiseWindows_CB.Size = new System.Drawing.Size(127, 17);
            this.minimiseWindows_CB.TabIndex = 0;
            this.minimiseWindows_CB.Text = "Minimise All Windows";
            this.minimiseWindows_CB.UseVisualStyleBackColor = true;
            // 
            // openCloseCD_CB
            // 
            this.openCloseCD_CB.AutoSize = true;
            this.openCloseCD_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCloseCD_CB.Location = new System.Drawing.Point(6, 42);
            this.openCloseCD_CB.Name = "openCloseCD_CB";
            this.openCloseCD_CB.Size = new System.Drawing.Size(129, 17);
            this.openCloseCD_CB.TabIndex = 0;
            this.openCloseCD_CB.Text = "Open/Close CD Drive";
            this.openCloseCD_CB.UseVisualStyleBackColor = true;
            // 
            // swapMouseBtn_CB
            // 
            this.swapMouseBtn_CB.AutoSize = true;
            this.swapMouseBtn_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swapMouseBtn_CB.Location = new System.Drawing.Point(6, 19);
            this.swapMouseBtn_CB.Name = "swapMouseBtn_CB";
            this.swapMouseBtn_CB.Size = new System.Drawing.Size(127, 17);
            this.swapMouseBtn_CB.TabIndex = 0;
            this.swapMouseBtn_CB.Text = "Swap Mouse Buttons";
            this.swapMouseBtn_CB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(24, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "This application is designed\r\npurely for educational\r\nuse only.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // virusName_Label
            // 
            this.virusName_Label.AutoSize = true;
            this.virusName_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.virusName_Label.Location = new System.Drawing.Point(14, 39);
            this.virusName_Label.Name = "virusName_Label";
            this.virusName_Label.Size = new System.Drawing.Size(64, 13);
            this.virusName_Label.TabIndex = 7;
            this.virusName_Label.Text = "Virus Name:";
            // 
            // saveLocation_Label
            // 
            this.saveLocation_Label.AutoSize = true;
            this.saveLocation_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.saveLocation_Label.Location = new System.Drawing.Point(14, 159);
            this.saveLocation_Label.Name = "saveLocation_Label";
            this.saveLocation_Label.Size = new System.Drawing.Size(110, 13);
            this.saveLocation_Label.TabIndex = 7;
            this.saveLocation_Label.Text = "Current save location:";
            // 
            // virusName
            // 
            this.virusName.Location = new System.Drawing.Point(84, 36);
            this.virusName.Name = "virusName";
            this.virusName.Size = new System.Drawing.Size(86, 20);
            this.virusName.TabIndex = 6;
            // 
            // saveLocation_Display
            // 
            this.saveLocation_Display.Location = new System.Drawing.Point(16, 175);
            this.saveLocation_Display.Name = "saveLocation_Display";
            this.saveLocation_Display.Size = new System.Drawing.Size(155, 20);
            this.saveLocation_Display.TabIndex = 6;
            // 
            // msgLog_Label
            // 
            this.msgLog_Label.AutoSize = true;
            this.msgLog_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLog_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.msgLog_Label.Location = new System.Drawing.Point(14, 59);
            this.msgLog_Label.Name = "msgLog_Label";
            this.msgLog_Label.Size = new System.Drawing.Size(74, 13);
            this.msgLog_Label.TabIndex = 5;
            this.msgLog_Label.Text = "Message Log:";
            // 
            // msgLog
            // 
            this.msgLog.Location = new System.Drawing.Point(16, 75);
            this.msgLog.Multiline = true;
            this.msgLog.Name = "msgLog";
            this.msgLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgLog.Size = new System.Drawing.Size(159, 81);
            this.msgLog.TabIndex = 4;
            // 
            // createVirusBtn
            // 
            this.createVirusBtn.Location = new System.Drawing.Point(13, 249);
            this.createVirusBtn.Name = "createVirusBtn";
            this.createVirusBtn.Size = new System.Drawing.Size(160, 30);
            this.createVirusBtn.TabIndex = 1;
            this.createVirusBtn.Text = "Create Virus";
            this.createVirusBtn.UseVisualStyleBackColor = true;
            // 
            // saveLocationBtn
            // 
            this.saveLocationBtn.Location = new System.Drawing.Point(13, 202);
            this.saveLocationBtn.Name = "saveLocationBtn";
            this.saveLocationBtn.Size = new System.Drawing.Size(88, 41);
            this.saveLocationBtn.TabIndex = 0;
            this.saveLocationBtn.Text = "Configure Save Location";
            this.saveLocationBtn.UseVisualStyleBackColor = true;
            // 
            // dltLastSaveBtn
            // 
            this.dltLastSaveBtn.Location = new System.Drawing.Point(106, 202);
            this.dltLastSaveBtn.Name = "dltLastSaveBtn";
            this.dltLastSaveBtn.Size = new System.Drawing.Size(66, 41);
            this.dltLastSaveBtn.TabIndex = 0;
            this.dltLastSaveBtn.Text = "Delete Last File";
            this.dltLastSaveBtn.UseVisualStyleBackColor = true;
            // 
            // clearSettingsBtn
            // 
            this.clearSettingsBtn.Location = new System.Drawing.Point(12, 7);
            this.clearSettingsBtn.Name = "clearSettingsBtn";
            this.clearSettingsBtn.Size = new System.Drawing.Size(160, 23);
            this.clearSettingsBtn.TabIndex = 3;
            this.clearSettingsBtn.Text = "Clear Current Settings";
            this.clearSettingsBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::VirusMaker.Properties.Resources.virusMakerLogo;
            this.pictureBox1.Location = new System.Drawing.Point(300, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please note that this application\r\nic curretly in it\'s pre-release phase\r\nand in " +
    "the furture, more tools and \r\noptions might be added.\r\n";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 339);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Virus Maker (Pre-Release v0.1)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.otherOptionsGroup.ResumeLayout(false);
            this.otherOptionsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeToWait_Value)).EndInit();
            this.potHarmfullGroup.ResumeLayout(false);
            this.potHarmfullGroup.PerformLayout();
            this.justForfunGroup.ResumeLayout(false);
            this.justForfunGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button saveLocationBtn;
        private System.Windows.Forms.Button dltLastSaveBtn;
        private System.Windows.Forms.Button createVirusBtn;
        private System.Windows.Forms.Button clearSettingsBtn;
        private System.Windows.Forms.Label msgLog_Label;
        private System.Windows.Forms.TextBox msgLog;
        private System.Windows.Forms.TextBox saveLocation_Display;
        private System.Windows.Forms.Label saveLocation_Label;
        private System.Windows.Forms.Label virusName_Label;
        private System.Windows.Forms.TextBox virusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox justForfunGroup;
        private System.Windows.Forms.CheckBox minimiseWindows_CB;
        private System.Windows.Forms.CheckBox openCloseCD_CB;
        private System.Windows.Forms.CheckBox swapMouseBtn_CB;
        private System.Windows.Forms.GroupBox potHarmfullGroup;
        private System.Windows.Forms.CheckBox bombDesktop_CB;
        private System.Windows.Forms.CheckBox dltMyDocuments_CB;
        private System.Windows.Forms.CheckBox disableTaskMng_CB;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.Label spamErrorTitle_Label;
        private System.Windows.Forms.TextBox spamErrorTitle_Input;
        private System.Windows.Forms.Label spamError_Label;
        private System.Windows.Forms.Label spamErrorMsg_Label;
        private System.Windows.Forms.TextBox spamErrorMsg_Input;
        private System.Windows.Forms.GroupBox otherOptionsGroup;
        private System.Windows.Forms.ComboBox fileVisibility;
        private System.Windows.Forms.Label fileVisibility_Label;
        private System.Windows.Forms.TextBox customCode;
        private System.Windows.Forms.Label customCode_Label;
        private System.Windows.Forms.NumericUpDown timeToWait_Value;
        private System.Windows.Forms.CheckBox shutdownComp_CB;
        private System.Windows.Forms.Label timeToWait_Label;
        private System.Windows.Forms.CheckBox readOnly_CB;
        private System.Windows.Forms.CheckBox copyToStartup_Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

