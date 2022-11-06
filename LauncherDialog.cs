using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowSXLauncher
{
    public partial class LauncherDialog : Form
    {
        private string sxPath
        {
            get { return Application.ExecutablePath.Replace(@"\ShadowSXLauncher.exe", ""); }
        }

        private string dolphinPath
        {
            get { return sxPath + @"\Dolphin-x64"; }
        }
        
        private string romDirectoryPath
        {
            get { return sxPath + @"\ShadowData"; }
        }
        
        private string savePath
        {
            get { return dolphinPath + @"\User\GC\USA\Card A"; }
        }
        
        private string gameSettingsFilePath
        {
            get { return dolphinPath + @"\User\GameSettings\GUPE8P.ini"; }
        }

        private string customTexturesPath
        {
            get { return dolphinPath + @"\User\Load\Textures\GUPE8P"; }
        }

        private string sxResorucesCustomTexturesPath
        {
            get { return sxPath + @"\ShadowSXResources\CustomTextures\GUPE8P"; }
        }
        
        public LauncherDialog()
        {
            InitializeComponent();
            Configuration.Instance.LoadSettings();
        }

        private void RunNoGUIButton_Click(object sender, EventArgs e)
        {
            UpdateCustomAssets();
            if (Directory.Exists(dolphinPath))
            {
                if (Directory.Exists(romDirectoryPath))
                {
                    Process.Start("\"" + dolphinPath + @"\Dolphin.exe" + "\"", @" -b " + "\"" + romDirectoryPath + @"\ShadowTheHedgehog.iso" + "\"");
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("ROM file not found.  Please double check directory files.");
                }
            }
            else
            {
                MessageBox.Show("Could not find dolphin.exe. Please double check directory files.");
            }
        }
        
        private void OpenFileLocationButton_Click(object sender, EventArgs e)
        {
            Process.Start(sxPath);
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
        
        private void UpdateCustomAssets()
        {
            var gameSettings = new DolphinGameSettings(File.ReadAllText(gameSettingsFilePath));
            var geckoEnabledSection = gameSettings.Sections["Gecko_Enabled"];
            var modernUiString = "$SX - Modern UI Control";
            var skipCutsceneString = "$SX - Allow Cutscene Skip Always";

            #region Gecko Management

            if (geckoEnabledSection.Contains(modernUiString) != Configuration.Instance.UseModernUiControl)
            {
                if (Configuration.Instance.UseModernUiControl)
                {
                    //Add the time string needed to enable the feature.
                    geckoEnabledSection.Add(modernUiString);
                }
                else
                {
                    //Remove the string the enables the feature.
                    var stringIndex = geckoEnabledSection.FindIndex(s=> s == modernUiString);
                    geckoEnabledSection.RemoveAt(stringIndex);
                }

                gameSettings.SaveSettings(gameSettingsFilePath);
            }
            
            if (geckoEnabledSection.Contains(skipCutsceneString) != Configuration.Instance.SkipCutscenes)
            {
                if (Configuration.Instance.SkipCutscenes)
                {
                    //Add the time string needed to enable the feature.
                    geckoEnabledSection.Add(skipCutsceneString);
                }
                else
                {
                    //Remove the string the enables the feature.
                    var stringIndex = geckoEnabledSection.FindIndex(s=> s == skipCutsceneString);
                    geckoEnabledSection.RemoveAt(stringIndex);
                }

                gameSettings.SaveSettings(gameSettingsFilePath);
            }

            #endregion

            #region UI Display Textures

            if (Directory.Exists(customTexturesPath + @"\Buttons"))
            {
                Directory.Delete(customTexturesPath + @"\Buttons", true);
            }

            var buttonAssetsFolder =
                Configuration.UiButtonStyles.Keys.ToArray()[Configuration.Instance.UiButtonDisplayIndex];
            if (!string.IsNullOrEmpty(buttonAssetsFolder))
            {
                var newButtonFilePath = sxResorucesCustomTexturesPath + @"\Buttons\" + buttonAssetsFolder;
                var newButtonUiFiles = Directory.EnumerateFiles(newButtonFilePath);
                
                Directory.CreateDirectory(customTexturesPath + @"\Buttons");
                
                foreach (var buttonFile in newButtonUiFiles)
                {
                    File.Copy(buttonFile, customTexturesPath + @"\Buttons" + buttonFile.Replace(newButtonFilePath, ""));
                }
            }

            #endregion
            
            #region Gloss Removal

            if (Directory.Exists(customTexturesPath + @"\GlossAdjustment"))
            {
                Directory.Delete(customTexturesPath + @"\GlossAdjustment", true);
            }

            var glossAssetsFolder = 
                Configuration.GlossAdjustmentOptions.Keys.ToArray()[Configuration.Instance.GlossAdjustmentIndex];
            if (!string.IsNullOrEmpty(glossAssetsFolder))
            {
                var removeGlossFilePath = sxResorucesCustomTexturesPath + @"\GlossAdjustment\" + glossAssetsFolder;
                var removeGlossFiles = Directory.EnumerateFiles(removeGlossFilePath);
                
                Directory.CreateDirectory(customTexturesPath + @"\GlossAdjustment");
                
                foreach (var removeGlossFile in removeGlossFiles)
                {
                    File.Copy(removeGlossFile, customTexturesPath + @"\GlossAdjustment" + removeGlossFile.Replace(removeGlossFilePath, ""));
                }
            }

            #endregion
        }
    }
}