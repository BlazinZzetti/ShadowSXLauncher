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
            get { return Application.ExecutablePath.Replace("ShadowSXLauncher.exe", ""); }
        }

        private string dolphinPath
        {
            get { return sxPath + @"\Dolphin-x64\Dolphin.exe"; }
        }
        private string romPath
        {
            get { return sxPath + @"\ShadowData\ShadowTheHedgehog.iso"; }
        }
        
        private string savePath
        {
            get { return sxPath + @"\Dolphin-x64\User\GC\USA\Card A"; }
        }
        
        private string gameSettingsFilePath
        {
            get { return sxPath + @"\Dolphin-x64\User\GameSettings\GUPE8P.ini"; }
        }

        private string customTexturesPath
        {
            get { return sxPath + @"\Dolphin-x64\User\Load\Textures\GUPE8P"; }
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
            Process.Start(dolphinPath, @" -b " + romPath);
            Application.Exit();
        }

        private void OpenDolphinButton_Click(object sender, EventArgs e)
        {
            UpdateCustomAssets();
            Process.Start(dolphinPath);
            Application.Exit();
        }

        private void OpenFileLocationButton_Click(object sender, EventArgs e)
        {
            Process.Start(sxPath);
        }

        private void SaveFileButton_Click(object sender, EventArgs e)
        {
            Process.Start(savePath);
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
        }
    }
}