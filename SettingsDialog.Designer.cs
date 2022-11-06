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
            this.ControllerSettingsButton = new System.Windows.Forms.Button();
            this.ModernUIControlCheckBox = new System.Windows.Forms.CheckBox();
            this.UiButtonDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShadowColorButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CutsceneSkipCheckBox = new System.Windows.Forms.CheckBox();
            this.GlossAdjustmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ControllerSettingsButton
            // 
            this.ControllerSettingsButton.Location = new System.Drawing.Point(12, 111);
            this.ControllerSettingsButton.Name = "ControllerSettingsButton";
            this.ControllerSettingsButton.Size = new System.Drawing.Size(196, 51);
            this.ControllerSettingsButton.TabIndex = 4;
            this.ControllerSettingsButton.Text = "Open Dolphin Interface";
            this.ControllerSettingsButton.UseVisualStyleBackColor = true;
            this.ControllerSettingsButton.Click += new System.EventHandler(this.ControllerSettingsButton_Click);
            // 
            // ModernUIControlCheckBox
            // 
            this.ModernUIControlCheckBox.Location = new System.Drawing.Point(12, 30);
            this.ModernUIControlCheckBox.Name = "ModernUIControlCheckBox";
            this.ModernUIControlCheckBox.Size = new System.Drawing.Size(193, 24);
            this.ModernUIControlCheckBox.TabIndex = 1;
            this.ModernUIControlCheckBox.Text = "Use Modern UI Control (Xbox Style)";
            this.ModernUIControlCheckBox.UseVisualStyleBackColor = true;
            this.ModernUIControlCheckBox.CheckedChanged += new System.EventHandler(this.ModernUIControlCheckBox_CheckedChanged);
            // 
            // UiButtonDisplayComboBox
            // 
            this.UiButtonDisplayComboBox.FormattingEnabled = true;
            this.UiButtonDisplayComboBox.Location = new System.Drawing.Point(113, 6);
            this.UiButtonDisplayComboBox.Name = "UiButtonDisplayComboBox";
            this.UiButtonDisplayComboBox.Size = new System.Drawing.Size(121, 21);
            this.UiButtonDisplayComboBox.TabIndex = 0;
            this.UiButtonDisplayComboBox.Text = "Steam Deck";
            this.UiButtonDisplayComboBox.SelectedValueChanged += new System.EventHandler(this.UiButtonDisplayComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "UI Buttons Display";
            // 
            // ShadowColorButton
            // 
            this.ShadowColorButton.Enabled = false;
            this.ShadowColorButton.Location = new System.Drawing.Point(214, 111);
            this.ShadowColorButton.Name = "ShadowColorButton";
            this.ShadowColorButton.Size = new System.Drawing.Size(95, 51);
            this.ShadowColorButton.TabIndex = 5;
            this.ShadowColorButton.Text = "Customize Shadow Color\r\n";
            this.ShadowColorButton.UseVisualStyleBackColor = true;
            this.ShadowColorButton.Click += new System.EventHandler(this.ShadowColorButton_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.AnyColor = true;
            this.colorDialog1.FullOpen = true;
            // 
            // CutsceneSkipCheckBox
            // 
            this.CutsceneSkipCheckBox.Location = new System.Drawing.Point(12, 60);
            this.CutsceneSkipCheckBox.Name = "CutsceneSkipCheckBox";
            this.CutsceneSkipCheckBox.Size = new System.Drawing.Size(193, 24);
            this.CutsceneSkipCheckBox.TabIndex = 2;
            this.CutsceneSkipCheckBox.Text = "Always allow skipping Cutscenes";
            this.CutsceneSkipCheckBox.UseVisualStyleBackColor = true;
            this.CutsceneSkipCheckBox.CheckedChanged += new System.EventHandler(this.CutsceneSkipCheckBox_CheckedChanged);
            // 
            // GlossAdjustmentComboBox
            // 
            this.GlossAdjustmentComboBox.FormattingEnabled = true;
            this.GlossAdjustmentComboBox.Location = new System.Drawing.Point(161, 84);
            this.GlossAdjustmentComboBox.Name = "GlossAdjustmentComboBox";
            this.GlossAdjustmentComboBox.Size = new System.Drawing.Size(148, 21);
            this.GlossAdjustmentComboBox.TabIndex = 3;
            this.GlossAdjustmentComboBox.SelectedIndexChanged += new System.EventHandler(this.GlossAdjustmentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glossy Effecty on Characters";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 173);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox GlossAdjustmentComboBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.CheckBox CutsceneSkipCheckBox;

        private System.Windows.Forms.ColorDialog colorDialog1;

        private System.Windows.Forms.Button ControllerSettingsButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox UiButtonDisplayComboBox;

        private System.Windows.Forms.CheckBox ModernUIControlCheckBox;

        private System.Windows.Forms.Button ShadowColorButton;

        #endregion
    }
}