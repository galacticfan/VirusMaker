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

        private void saveLocationBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectFileDialog = new FolderBrowserDialog();
            DialogResult result = selectFileDialog.ShowDialog();
            string folderName = selectFileDialog.SelectedPath;

            if (result == DialogResult.OK)
            {
                saveLocation_Display.Text = folderName;
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
                    }
                    else if (File.Exists(virusFilePathVBS) == false)
                    {
                        MessageBox.Show(virusFilePathVBS + " doesn't exist.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (File.Exists(virusFilePathBatch))
                    {
                        System.IO.File.Delete(virusFilePathBatch);
                    }
                    else if (File.Exists(virusFilePathBatch) == false)
                    {
                        MessageBox.Show(virusFilePathBatch + " doesn't exist.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
