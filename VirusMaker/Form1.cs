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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string applicationDirectory = Application.StartupPath;
            saveLocation_Display.Text = applicationDirectory + "\\output";
        }

        // GLOBALS
        string newLine = Environment.NewLine;

        // SAVE + DELETE BUTTONS
        private void saveLocationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog selectFileDialog = new FolderBrowserDialog();
                DialogResult result = selectFileDialog.ShowDialog();
                string folderName = selectFileDialog.SelectedPath;

                if (result == DialogResult.OK)
                {
                    saveLocation_Display.Text = folderName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msgLog.Text += "An error occured" + newLine;
            }
        }

        private void dltLastSaveBtn_Click(object sender, EventArgs e)
        {
            string virusFilePathBatch = saveLocation_Display.Text + "\\" + virusName.Text + "_extra.bat";
            string virusFilePathVBS = saveLocation_Display.Text + "\\" + virusName.Text + ".vbs";

            try
            {
                if (virusName.Text.Trim().Length > 0)
                {
                    if (File.Exists(virusFilePathVBS))
                    {
                        System.IO.File.Delete(virusFilePathVBS);
                        msgLog.Text += virusName.Text + ".vbs successfully deleted." + newLine;
                    }
                    else if (File.Exists(virusFilePathVBS) == false)
                    {
                        MessageBox.Show(virusFilePathVBS + " doesn't exist.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        msgLog.Text += virusName.Text + ".vbs doesn't exist." + newLine;
                    }
                    if (File.Exists(virusFilePathBatch))
                    {
                        System.IO.File.Delete(virusFilePathBatch);
                        msgLog.Text += virusName.Text + "_extra.bat successfully deleted." + newLine;
                    }
                    else if (File.Exists(virusFilePathBatch) == false)
                    {
                        MessageBox.Show(virusFilePathBatch + " doesn't exist.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        msgLog.Text += virusName.Text + "_extra.bat doesn't exist." + newLine;
                    }
                }
                else if (virusName.Text.Trim().Length == 0)
                {
                    DialogResult result = MessageBox.Show("Please enter the name of a previous virus.", "Virus Name Null", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.OK)
                    {
                        virusName.Select();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                msgLog.Text += "An error occured" + newLine;
            }
        }
    }
}
