using System.ComponentModel;

namespace ShadowSXLauncher
{
    partial class SettingsDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.ControllerSettingsButton = new System.Windows.Forms.Button();
            this.ModernUIControlCheckBox = new System.Windows.Forms.CheckBox();
            this.UiButtonDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShadowColorButton = new System.Windows.Forms.Button();
            this.CutsceneSkipCheckBox = new System.Windows.Forms.CheckBox();
            this.GlossAdjustmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RaceModeCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RomLocationTextBox = new System.Windows.Forms.TextBox();
            this.SetRomLocationButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ControllerSettingsButton
            // 
            this.ControllerSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ControllerSettingsButton.Location = new System.Drawing.Point(16, 278);
            this.ControllerSettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ControllerSettingsButton.Name = "ControllerSettingsButton";
            this.ControllerSettingsButton.Size = new System.Drawing.Size(261, 63);
            this.ControllerSettingsButton.TabIndex = 4;
            this.ControllerSettingsButton.Text = "Open Dolphin Interface";
            this.ControllerSettingsButton.UseVisualStyleBackColor = true;
            this.ControllerSettingsButton.Click += new System.EventHandler(this.ControllerSettingsButton_Click);
            // 
            // ModernUIControlCheckBox
            // 
            this.ModernUIControlCheckBox.Location = new System.Drawing.Point(20, 142);
            this.ModernUIControlCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModernUIControlCheckBox.Name = "ModernUIControlCheckBox";
            this.ModernUIControlCheckBox.Size = new System.Drawing.Size(257, 30);
            this.ModernUIControlCheckBox.TabIndex = 1;
            this.ModernUIControlCheckBox.Text = "Use Modern UI Control (Xbox Style)";
            this.ModernUIControlCheckBox.UseVisualStyleBackColor = true;
            this.ModernUIControlCheckBox.CheckedChanged += new System.EventHandler(this.ModernUIControlCheckBox_CheckedChanged);
            // 
            // UiButtonDisplayComboBox
            // 
            this.UiButtonDisplayComboBox.FormattingEnabled = true;
            this.UiButtonDisplayComboBox.Location = new System.Drawing.Point(151, 203);
            this.UiButtonDisplayComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UiButtonDisplayComboBox.Name = "UiButtonDisplayComboBox";
            this.UiButtonDisplayComboBox.Size = new System.Drawing.Size(160, 24);
            this.UiButtonDisplayComboBox.TabIndex = 0;
            this.UiButtonDisplayComboBox.Text = "Steam Deck";
            this.UiButtonDisplayComboBox.SelectedValueChanged += new System.EventHandler(this.UiButtonDisplayComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 207);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "UI Buttons Display";
            // 
            // ShadowColorButton
            // 
            this.ShadowColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowColorButton.Enabled = false;
            this.ShadowColorButton.Location = new System.Drawing.Point(289, 278);
            this.ShadowColorButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShadowColorButton.Name = "ShadowColorButton";
            this.ShadowColorButton.Size = new System.Drawing.Size(127, 63);
            this.ShadowColorButton.TabIndex = 5;
            this.ShadowColorButton.Text = "Customize Shadow Color\r\n";
            this.ShadowColorButton.UseVisualStyleBackColor = true;
            this.ShadowColorButton.Click += new System.EventHandler(this.ShadowColorButton_Click);
            // 
            // CutsceneSkipCheckBox
            // 
            this.CutsceneSkipCheckBox.Location = new System.Drawing.Point(20, 68);
            this.CutsceneSkipCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CutsceneSkipCheckBox.Name = "CutsceneSkipCheckBox";
            this.CutsceneSkipCheckBox.Size = new System.Drawing.Size(257, 30);
            this.CutsceneSkipCheckBox.TabIndex = 2;
            this.CutsceneSkipCheckBox.Text = "Restore Original Cutscene Skipping";
            this.CutsceneSkipCheckBox.UseVisualStyleBackColor = true;
            this.CutsceneSkipCheckBox.CheckedChanged += new System.EventHandler(this.CutsceneSkipCheckBox_CheckedChanged);
            // 
            // GlossAdjustmentComboBox
            // 
            this.GlossAdjustmentComboBox.FormattingEnabled = true;
            this.GlossAdjustmentComboBox.Location = new System.Drawing.Point(219, 236);
            this.GlossAdjustmentComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GlossAdjustmentComboBox.Name = "GlossAdjustmentComboBox";
            this.GlossAdjustmentComboBox.Size = new System.Drawing.Size(196, 24);
            this.GlossAdjustmentComboBox.TabIndex = 3;
            this.GlossAdjustmentComboBox.SelectedIndexChanged += new System.EventHandler(this.GlossAdjustmentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 240);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glossy Effecty on Characters";
            // 
            // RaceModeCheckBox
            // 
            this.RaceModeCheckBox.Location = new System.Drawing.Point(20, 105);
            this.RaceModeCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RaceModeCheckBox.Name = "RaceModeCheckBox";
            this.RaceModeCheckBox.Size = new System.Drawing.Size(315, 30);
            this.RaceModeCheckBox.TabIndex = 8;
            this.RaceModeCheckBox.Text = "Show Total IGT for Story Runs (Race Mode)";
            this.RaceModeCheckBox.UseVisualStyleBackColor = true;
            this.RaceModeCheckBox.CheckedChanged += new System.EventHandler(this.RaceModeCheckBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "SX ROM Location";
            // 
            // RomLocationTextBox
            // 
            this.RomLocationTextBox.Location = new System.Drawing.Point(151, 7);
            this.RomLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RomLocationTextBox.Name = "RomLocationTextBox";
            this.RomLocationTextBox.ReadOnly = true;
            this.RomLocationTextBox.Size = new System.Drawing.Size(223, 22);
            this.RomLocationTextBox.TabIndex = 10;
            // 
            // SetRomLocationButton
            // 
            this.SetRomLocationButton.Location = new System.Drawing.Point(383, 5);
            this.SetRomLocationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetRomLocationButton.Name = "SetRomLocationButton";
            this.SetRomLocationButton.Size = new System.Drawing.Size(33, 28);
            this.SetRomLocationButton.TabIndex = 11;
            this.SetRomLocationButton.Text = "...";
            this.SetRomLocationButton.UseVisualStyleBackColor = true;
            this.SetRomLocationButton.Click += new System.EventHandler(this.SetRomLocationButton_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "ROM Settings";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Graphic Settings";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(432, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SetRomLocationButton);
            this.Controls.Add(this.RomLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RaceModeCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GlossAdjustmentComboBox);
            this.Controls.Add(this.CutsceneSkipCheckBox);
            this.Controls.Add(this.ShadowColorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UiButtonDisplayComboBox);
            this.Controls.Add(this.ModernUIControlCheckBox);
            this.Controls.Add(this.ControllerSettingsButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button SetRomLocationButton;

        private System.Windows.Forms.TextBox RomLocationTextBox;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.CheckBox RaceModeCheckBox;

        private System.Windows.Forms.ComboBox GlossAdjustmentComboBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox CutsceneSkipCheckBox;

        private System.Windows.Forms.Button ControllerSettingsButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox UiButtonDisplayComboBox;

        private System.Windows.Forms.CheckBox ModernUIControlCheckBox;

        private System.Windows.Forms.Button ShadowColorButton;

        #endregion
    }
}