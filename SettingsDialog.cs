using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShadowSXLauncher
{
    public partial class SettingsDialog : Form
    {
        private string sxPath
        {
            get { return Application.ExecutablePath.Replace("ShadowSXLauncher.exe", ""); }
        }
        
        private string dolphinPath
        {
            get { return sxPath + @"\Dolphin-x64"; }
        }
        
        public SettingsDialog()
        {
            InitializeComponent();
            
            //Unregister events to initialize settings.
            ModernUIControlCheckBox.CheckedChanged -= ModernUIControlCheckBox_CheckedChanged;
            UiButtonDisplayComboBox.SelectedValueChanged -= UiButtonDisplayComboBox_SelectedValueChanged;
            CutsceneSkipCheckBox.CheckedChanged -= CutsceneSkipCheckBox_CheckedChanged;
            GlossAdjustmentComboBox.SelectedIndexChanged -= GlossAdjustmentComboBox_SelectedIndexChanged;
            RaceModeCheckBox.CheckedChanged -= RaceModeCheckBox_CheckedChanged;

            UiButtonDisplayComboBox.DataSource = Configuration.UiButtonStyles.Values.ToList(); 
            GlossAdjustmentComboBox.DataSource = Configuration.GlossAdjustmentOptions.Values.ToList(); 

            ModernUIControlCheckBox.Checked = Configuration.Instance.UseModernUiControl;
            CutsceneSkipCheckBox.Checked = Configuration.Instance.SkipCutscenes;
            GlossAdjustmentComboBox.SelectedIndex = Configuration.Instance.GlossAdjustmentIndex;
            UiButtonDisplayComboBox.SelectedIndex = Configuration.Instance.UiButtonDisplayIndex;
            RaceModeCheckBox.Checked = Configuration.Instance.RaceMode;
            
            //Re-Register Events.
            ModernUIControlCheckBox.CheckedChanged += ModernUIControlCheckBox_CheckedChanged;
            UiButtonDisplayComboBox.SelectedValueChanged += UiButtonDisplayComboBox_SelectedValueChanged;
            CutsceneSkipCheckBox.CheckedChanged += CutsceneSkipCheckBox_CheckedChanged;
            GlossAdjustmentComboBox.SelectedIndexChanged += GlossAdjustmentComboBox_SelectedIndexChanged;
            RaceModeCheckBox.CheckedChanged += RaceModeCheckBox_CheckedChanged;
        }

        private void ModernUIControlCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Instance.UseModernUiControl = ModernUIControlCheckBox.Checked;
            Configuration.Instance.SaveSettings();
        }

        private void UiButtonDisplayComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            Configuration.Instance.UiButtonDisplayIndex = UiButtonDisplayComboBox.SelectedIndex;
            Configuration.Instance.SaveSettings();
        }

        private void ControllerSettingsButton_Click(object sender, EventArgs e)
        {
            //Open Dolphin for now.  A modified Dolphin with shortcuts will be available later.
            if (Directory.Exists(dolphinPath))
            {
                Process.Start("\"" + dolphinPath + @"\Dolphin.exe" + "\"");
            }
            else
            {
                MessageBox.Show("Could not find dolphin.exe. Please double check directory files.");
            }
        }

        private void ShadowColorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void CutsceneSkipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Instance.SkipCutscenes = CutsceneSkipCheckBox.Checked;
            Configuration.Instance.SaveSettings();
        }

        private void GlossAdjustmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Configuration.Instance.GlossAdjustmentIndex = GlossAdjustmentComboBox.SelectedIndex;
            Configuration.Instance.SaveSettings();
        }

        private void RaceModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.Instance.RaceMode = RaceModeCheckBox.Checked;
            Configuration.Instance.SaveSettings();
        }
    }
}