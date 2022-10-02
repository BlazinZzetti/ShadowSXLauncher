using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShadowSXLauncher
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            
            //Unregister events to initialize settings.
            ModernUIControlCheckBox.CheckedChanged -= ModernUIControlCheckBox_CheckedChanged;
            UiButtonDisplayComboBox.SelectedValueChanged -= UiButtonDisplayComboBox_SelectedValueChanged;

            UiButtonDisplayComboBox.DataSource = Configuration.UiButtonStyles.Values.ToList(); 

            ModernUIControlCheckBox.Checked = Configuration.Instance.UseModernUiControl;
            UiButtonDisplayComboBox.SelectedIndex = Configuration.Instance.UiButtonDisplayIndex;
            
            //Re-Register Events.
            ModernUIControlCheckBox.CheckedChanged += ModernUIControlCheckBox_CheckedChanged;
            UiButtonDisplayComboBox.SelectedValueChanged += UiButtonDisplayComboBox_SelectedValueChanged;
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
    }
}