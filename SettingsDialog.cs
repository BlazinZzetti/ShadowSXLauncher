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
            Configuration.Instance.SaveSettings();
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
            Configuration.Instance.SaveSettings();
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
    }
}