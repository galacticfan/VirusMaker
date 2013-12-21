namespace VirusMaker
{
    partial class DeleteStartupDialog
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dltFilesBtn = new System.Windows.Forms.Button();
            this.virusNameInput = new System.Windows.Forms.TextBox();
            this.deleteVirusName_RB = new System.Windows.Forms.RadioButton();
            this.removeAll_RB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(137, 106);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "This dialog allows you to delete previous \r\n\'viruses\' from a computer\'s startup f" +
    "older.";
            // 
            // dltFilesBtn
            // 
            this.dltFilesBtn.Location = new System.Drawing.Point(12, 106);
            this.dltFilesBtn.Name = "dltFilesBtn";
            this.dltFilesBtn.Size = new System.Drawing.Size(116, 23);
            this.dltFilesBtn.TabIndex = 0;
            this.dltFilesBtn.Text = "Delete Files";
            this.dltFilesBtn.UseVisualStyleBackColor = true;
            this.dltFilesBtn.Click += new System.EventHandler(this.dltFilesBtn_Click);
            // 
            // virusNameInput
            // 
            this.virusNameInput.Location = new System.Drawing.Point(119, 44);
            this.virusNameInput.Name = "virusNameInput";
            this.virusNameInput.Size = new System.Drawing.Size(93, 20);
            this.virusNameInput.TabIndex = 3;
            // 
            // deleteVirusName_RB
            // 
            this.deleteVirusName_RB.AutoSize = true;
            this.deleteVirusName_RB.Location = new System.Drawing.Point(15, 38);
            this.deleteVirusName_RB.Name = "deleteVirusName_RB";
            this.deleteVirusName_RB.Size = new System.Drawing.Size(98, 30);
            this.deleteVirusName_RB.TabIndex = 4;
            this.deleteVirusName_RB.TabStop = true;
            this.deleteVirusName_RB.Text = "Delete a virus \r\nby the name of:";
            this.deleteVirusName_RB.UseVisualStyleBackColor = true;
            // 
            // removeAll_RB
            // 
            this.removeAll_RB.AutoSize = true;
            this.removeAll_RB.Location = new System.Drawing.Point(15, 70);
            this.removeAll_RB.Name = "removeAll_RB";
            this.removeAll_RB.Size = new System.Drawing.Size(177, 30);
            this.removeAll_RB.TabIndex = 4;
            this.removeAll_RB.TabStop = true;
            this.removeAll_RB.Text = "Remove all VBScript and Batch \r\nfiles from the sartup folder.";
            this.removeAll_RB.UseVisualStyleBackColor = true;
            // 
            // DeleteStartupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(226, 137);
            this.Controls.Add(this.removeAll_RB);
            this.Controls.Add(this.deleteVirusName_RB);
            this.Controls.Add(this.virusNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dltFilesBtn);
            this.Controls.Add(this.cancelBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeleteStartupDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Delete Startup Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button dltFilesBtn;
        private System.Windows.Forms.TextBox virusNameInput;
        private System.Windows.Forms.RadioButton deleteVirusName_RB;
        private System.Windows.Forms.RadioButton removeAll_RB;
    }
}