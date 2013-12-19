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

        private void dltFilesBtn_Click(object sender, EventArgs e)
        {
            if (deleteVirusName_RB.Checked)
            {
                try
                {
                    string virusName = virusNameInput.Text;
                    System.IO.File.Delete(filePath + virusName + ".vbs");
                    System.IO.File.Delete(filePath + virusName + "_extra.bat");
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
    }
}
