using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VirusMaker
{
    public partial class DeleteStartupDialog : Form
    {
        public DeleteStartupDialog()
        {
            InitializeComponent();
        }

        // GLOBALS
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\";

        // METHODS
        private void dltFilesBtn_Click(object sender, EventArgs e)
        {
            if (deleteVirusName_RB.Checked || removeAll_RB.Checked)
            {
                if (deleteVirusName_RB.Checked)
                {
                    try
                    {
                        string virusName = virusNameInput.Text;
                        string vbsFilePath = filePath + virusName + ".vbs";
                        string batFilePath = filePath + virusName + "_extra.bat";

                        if (virusNameInput.Text.Trim().Length > 0)
                        {
                            if (File.Exists(vbsFilePath) || File.Exists(batFilePath))
                            {
                                System.IO.File.Delete(vbsFilePath);
                                System.IO.File.Delete(batFilePath);
                                MessageBox.Show("Files successfully deleted.", "Successful Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide(); // hide dialog
                            }
                            else if (File.Exists(vbsFilePath) == false && File.Exists(batFilePath) == false)
                            {
                                DialogResult result = MessageBox.Show("Could not find any viruses under the name of " + virusName + ".", "File Does Not Exist", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                if (result == DialogResult.Retry)
                                {
                                    dltFilesBtn.PerformClick();
                                }
                            }
                        }
                        else if (virusNameInput.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("You haven't entered anything in the 'Virus Name' field.", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show("An error occured:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry)
                        {
                            dltFilesBtn.PerformClick();
                        }
                    }
                }
                else if (removeAll_RB.Checked)
                {
                    try
                    {
                        // Delete vbscript files
                        string[] vbsFiles = System.IO.Directory.GetFiles(filePath, "*.vbs");
                        foreach (string vbs in vbsFiles)
                        {
                            System.IO.File.Delete(vbs);
                        }
                        // Delete batch files
                        string[] batchFiles = System.IO.Directory.GetFiles(filePath, "*.bat");
                        foreach (string bat in batchFiles)
                        {
                            System.IO.File.Delete(bat);
                        }

                        MessageBox.Show("Files successfully deleted.", "Successful Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show("An error occured:" + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.Retry)
                        {
                            dltFilesBtn.PerformClick();
                        }
                    }
                }
            }
            else if (deleteVirusName_RB.Checked == false || removeAll_RB.Checked == false)
            {
                MessageBox.Show("You haven't selected an option.", "Invalid Submission", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Cancel button setup
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }     
    }
}
