﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShadowSXLauncher
{
    public partial class LauncherDialog : Form
    {
        private string dolphinPath
        {
            get { return Application.StartupPath + @"\Dolphin-x64"; }
        }
        
        private string savePath
        {
            get { return dolphinPath + @"\User\GC\USA\Card A"; }
        }
        
        // private string gameSettingsFilePath
        // {
        //     get { return dolphinPath + @"\User\GameSettings\GUPX8P.ini"; }
        // }
        
        private string sxResourcesPath
        {
            get { return Application.StartupPath + @"\ShadowSXResources"; }
        }
        
        private string sxResourcesISOPatchingPath
        {
            get { return sxResourcesPath + @"\PatchingFiles"; }
        }
        
        public LauncherDialog()
        {
            InitializeComponent();
            Configuration.Instance.LoadSettings();
        }

        private void RunNoGUIButton_Click(object sender, EventArgs e)
        {
            //Check if Rom Location has been set at all.
            if (string.IsNullOrEmpty(Configuration.Instance.RomLocation))
            {
                OpenRomDialog();
            }
            
            //Only continue if Rom Location has been set, in case it was not in the above code. 
            if (!string.IsNullOrEmpty(Configuration.Instance.RomLocation))
            {
                //Double check if the provided path has a file, if not re-prompt for a ROM.
                if (!File.Exists(Configuration.Instance.RomLocation))
                {
                    MessageBox.Show("ROM file not found. Please provide ROM location again.");
                    OpenRomDialog();
                }
                
                //At this point assume there is a correct ROM. Technically nothing stopping a user from
                //choosing whatever ROM they want to launch, but trying to account for that without additional
                //annoying checks and processes is not worth it.

                //Double check the .exe is found before attempting to run it.
                if (File.Exists(dolphinPath + @"\Dolphin.exe"))
                {
                    Process.Start("\"" + dolphinPath + @"\Dolphin.exe" + "\"",
                        @" -b " + "\"" + Configuration.Instance.RomLocation + "\"");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Could not find dolphin.exe. Please double check directory files.");
                }
            }
        }

        private void OpenRomDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                var romSelectionComplete = false;
                while (!romSelectionComplete)
                {
                    ofd.InitialDirectory = Application.StartupPath;
                    ofd.Filter = "ROM file (*.iso)|*.iso";
                    ofd.RestoreDirectory = true;

                    var selectedRom = "";
                    var dialogResult = ofd.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        selectedRom = ofd.FileName;
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        Configuration.Instance.RomLocation = string.Empty;
                        Configuration.Instance.SaveSettings();
                        romSelectionComplete = true;
                        continue;
                    }

                    if (File.Exists(selectedRom))
                    {
                        Configuration.Instance.RomLocation = selectedRom;
                        Configuration.Instance.SaveSettings();
                        romSelectionComplete = true;
                    }
                }
            }
        }

        private void OpenFileLocationButton_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(savePath))
            {
                Process.Start(savePath);
            }
            else
            {
                MessageBox.Show("Please launch game to generate the save directory.");
            }
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            var settingsDialog = new SettingsDialog();
            settingsDialog.ShowDialog();
        }

        private void CreateRomButton_Click(object sender, EventArgs e)
        {
            var xdeltaExePath = sxResourcesISOPatchingPath + @"\xdelta-3.1.0-x86_64.exe";
            var vcdiffPath = sxResourcesISOPatchingPath + @".\vcdiff\ShadowSX.vcdiff";
            var patchBatPath = sxResourcesISOPatchingPath + @"\Patch ISO.bat";
                    
            var allPatchFilesFound = File.Exists(xdeltaExePath);
            allPatchFilesFound &= File.Exists(vcdiffPath);
            allPatchFilesFound &= File.Exists(patchBatPath);
            
            if (allPatchFilesFound)
            {
                var gupe8pLocation = "";
                var patchedRomDestination = "";
                
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.InitialDirectory = Application.StartupPath;
                    ofd.Filter = "ROM file (*.iso)|*.iso";
                    ofd.RestoreDirectory = true;

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        gupe8pLocation = ofd.FileName;
                    }
                }

                if (!string.IsNullOrEmpty(gupe8pLocation))
                {
                    using (SaveFileDialog sfd = new SaveFileDialog())
                    {
                        sfd.InitialDirectory = gupe8pLocation;
                        sfd.FileName = "ShadowSX";
                        sfd.Filter = "ROM file (*.iso)|*.iso";
                        sfd.RestoreDirectory = true;

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            patchedRomDestination = sfd.FileName;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                    return;
                }
                
                //We can assume that gupe8pLocation is not empty or null. 
                if (!string.IsNullOrEmpty(patchedRomDestination))
                {
                    var batArguments = string.Format("\"{0}\" \"{1}\" \"{2}\" \"{3}\"", gupe8pLocation, patchedRomDestination,
                            xdeltaExePath, vcdiffPath);
                        
                    var processResult = Process.Start("\"" + patchBatPath + "\"", batArguments);
                    if (processResult != null)
                    {
                        processResult.WaitForExit();

                        switch (processResult.ExitCode)
                        {
                            case 0:
                                //MessageBox by default doesnt have alignment options. Hack it to look nice to avoid needing to create a new control dialog.
                                var messageResult = MessageBox.Show(
                                    "                           ROM Created Successfully." + Environment.NewLine + Environment.NewLine
                                    + "Would you like to set the location of this ROM as the " + Environment.NewLine
                                    + "location this launcher will use to launch the game?", "ROM Patch Successful",
                                    MessageBoxButtons.YesNo);

                                if (messageResult == DialogResult.Yes)
                                {
                                    Configuration.Instance.RomLocation = patchedRomDestination;
                                    Configuration.Instance.SaveSettings();
                                }

                                break;
                            default:
                                //MessageBox by default doesnt have alignment options. Hack it to look nice to avoid needing to create a new control dialog.
                                MessageBox.Show(
                                    "                           ROM Patching Failed. " + Environment.NewLine + Environment.NewLine
                                    + "Please ensure that provided paths are valid and that " + Environment.NewLine
                                    + "the Shadow ROM provided is a full size clean rip. " + Environment.NewLine + Environment.NewLine
                                    + "                   Expected ROM CRC32: F582CF1E", "ROM Patch Failed");
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ROM Patching failed to launch.");
                    }
                }
                else
                {
                    MessageBox.Show("Operation Cancelled");
                }
            }
            else
            {
                MessageBox.Show("One or more files needed to complete the ROM patching were missing.  " +
                                "Please double check directory files.");
            }
        }
    }
}