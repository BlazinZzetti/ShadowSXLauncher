using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ShadowSXLauncher
{
    public partial class SettingsDialog : Form
    {
        
        private string dolphinPath
        {
            get { return Application.StartupPath + @"\Dolphin-x64"; }
        }

        private string customTexturesPath
        {
            get { return dolphinPath + @"\User\Load\Textures\GUPX8P"; }
        }

        private string sxResourcesPath
        {
            get { return Application.StartupPath + @"\ShadowSXResources"; }
        }
        
        private string sxResourcesCustomTexturesPath
        {
            get { return sxResourcesPath + @"\CustomTextures\GUPX8P"; }
        }

        public SettingsDialog()
        {
            InitializeComponent();
            
            //Unregister events to initialize settings.
            UiButtonDisplayComboBox.SelectedValueChanged -= UiButtonDisplayComboBox_SelectedValueChanged;
            GlossAdjustmentComboBox.SelectedIndexChanged -= GlossAdjustmentComboBox_SelectedIndexChanged;

            UiButtonDisplayComboBox.DataSource = Configuration.UiButtonStyles.Values.ToList(); 
            GlossAdjustmentComboBox.DataSource = Configuration.GlossAdjustmentOptions.Values.ToList();

            RomLocationTextBox.Text = Configuration.Instance.RomLocation;
            GlossAdjustmentComboBox.SelectedIndex = Configuration.Instance.GlossAdjustmentIndex;
            UiButtonDisplayComboBox.SelectedIndex = Configuration.Instance.UiButtonDisplayIndex;

            //Re-Register Events.
            UiButtonDisplayComboBox.SelectedValueChanged += UiButtonDisplayComboBox_SelectedValueChanged;
            GlossAdjustmentComboBox.SelectedIndexChanged += GlossAdjustmentComboBox_SelectedIndexChanged;
        }

        private void UiButtonDisplayComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Configuration.Instance.UiButtonDisplayIndex = UiButtonDisplayComboBox.SelectedIndex;
        }

        private void ControllerSettingsButton_Click(object sender, EventArgs e)
        {
            //Open Dolphin for now.  A modified Dolphin with shortcuts will be available later.
            if (Directory.Exists(dolphinPath))
            {
                Process.Start(dolphinPath + @"\Dolphin.exe");
            }
            else
            {
                MessageBox.Show("Could not find dolphin.exe. Please double check directory files.");
            }
        }

        private void ShadowColorButton_Click(object sender, EventArgs e)
        {
            var colorAdjuster = new ShadowColorAdjuster();
            colorAdjuster.ShowDialog();
        }
        
        private void GlossAdjustmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.GlossAdjustmentIndex = GlossAdjustmentComboBox.SelectedIndex;
        }

        private void SetRomLocationButton_Click(object sender, EventArgs e)
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
            RomLocationTextBox.Text = Configuration.Instance.RomLocation;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            Configuration.Instance.SaveSettings();
            UpdateCustomAssets();
        }
        
        private void UpdateCustomAssets()
        {
            // var gameSettings = new DolphinGameSettings(File.ReadAllText(gameSettingsFilePath));
            // var geckoEnabledSection = gameSettings.Sections["Gecko_Enabled"];
            // var modernUiString = "$SX - Modern UI Control";
            // var disableSkipCutsceneString = "$SX - Restore Original Cutscene Skip";
            // var raceModeString = "$SX - Enable Race Mode";
            //
            // #region Gecko Management
            //
            // if (geckoEnabledSection.Contains(modernUiString) != Configuration.Instance.UseModernUiControl)
            // {
            //     if (Configuration.Instance.UseModernUiControl)
            //     {
            //         //Add the time string needed to enable the feature.
            //         geckoEnabledSection.Add(modernUiString);
            //     }
            //     else
            //     {
            //         //Remove the string the enables the feature.
            //         var stringIndex = geckoEnabledSection.FindIndex(s=> s == modernUiString);
            //         geckoEnabledSection.RemoveAt(stringIndex);
            //     }
            //
            //     gameSettings.SaveSettings(gameSettingsFilePath);
            // }
            //
            // if (geckoEnabledSection.Contains(disableSkipCutsceneString) != Configuration.Instance.DisableSkipCutscenes)
            // {
            //     if (Configuration.Instance.DisableSkipCutscenes)
            //     {
            //         //Add the time string needed to enable the feature.
            //         geckoEnabledSection.Add(disableSkipCutsceneString);
            //     }
            //     else
            //     {
            //         //Remove the string the enables the feature.
            //         var stringIndex = geckoEnabledSection.FindIndex(s=> s == disableSkipCutsceneString);
            //         geckoEnabledSection.RemoveAt(stringIndex);
            //     }
            //
            //     gameSettings.SaveSettings(gameSettingsFilePath);
            // }
            //
            // if (geckoEnabledSection.Contains(raceModeString) != Configuration.Instance.RaceMode)
            // {
            //     if (Configuration.Instance.RaceMode)
            //     {
            //         //Add the time string needed to enable the feature.
            //         geckoEnabledSection.Add(raceModeString);
            //     }
            //     else
            //     {
            //         //Remove the string the enables the feature.
            //         var stringIndex = geckoEnabledSection.FindIndex(s=> s == raceModeString);
            //         geckoEnabledSection.RemoveAt(stringIndex);
            //     }
            //
            //     gameSettings.SaveSettings(gameSettingsFilePath);
            // }
            //
            // #endregion

            #region UI Display Textures

            if (Directory.Exists(customTexturesPath + @"\Buttons"))
            {
                Directory.Delete(customTexturesPath + @"\Buttons", true);
            }

            var buttonAssetsFolder =
                Configuration.UiButtonStyles.Keys.ToArray()[Configuration.Instance.UiButtonDisplayIndex];
            if (!string.IsNullOrEmpty(buttonAssetsFolder))
            {
                var newButtonFilePath = sxResourcesCustomTexturesPath + @"\Buttons\" + buttonAssetsFolder;
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
                var removeGlossFilePath = sxResourcesCustomTexturesPath + @"\GlossAdjustment\" + glossAssetsFolder;
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