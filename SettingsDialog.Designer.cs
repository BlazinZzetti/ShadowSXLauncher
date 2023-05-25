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
            this.UiButtonDisplayComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShadowColorButton = new System.Windows.Forms.Button();
            this.GlossAdjustmentComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RomLocationTextBox = new System.Windows.Forms.TextBox();
            this.SetRomLocationButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ControllerSettingsButton
            // 
            this.ControllerSettingsButton.Location = new System.Drawing.Point(12, 117);
            this.ControllerSettingsButton.Name = "ControllerSettingsButton";
            this.ControllerSettingsButton.Size = new System.Drawing.Size(147, 51);
            this.ControllerSettingsButton.TabIndex = 4;
            this.ControllerSettingsButton.Text = "Open Dolphin Interface";
            this.ControllerSettingsButton.UseVisualStyleBackColor = true;
            this.ControllerSettingsButton.Click += new System.EventHandler(this.ControllerSettingsButton_Click);
            // 
            // UiButtonDisplayComboBox
            // 
            this.UiButtonDisplayComboBox.FormattingEnabled = true;
            this.UiButtonDisplayComboBox.Location = new System.Drawing.Point(113, 58);
            this.UiButtonDisplayComboBox.Name = "UiButtonDisplayComboBox";
            this.UiButtonDisplayComboBox.Size = new System.Drawing.Size(121, 21);
            this.UiButtonDisplayComboBox.TabIndex = 0;
            this.UiButtonDisplayComboBox.Text = "Steam Deck";
            this.UiButtonDisplayComboBox.SelectedValueChanged += new System.EventHandler(this.UiButtonDisplayComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "UI Buttons Display";
            // 
            // ShadowColorButton
            // 
            this.ShadowColorButton.Location = new System.Drawing.Point(165, 117);
            this.ShadowColorButton.Name = "ShadowColorButton";
            this.ShadowColorButton.Size = new System.Drawing.Size(147, 51);
            this.ShadowColorButton.TabIndex = 5;
            this.ShadowColorButton.Text = "Customize Shadow Color\r\n";
            this.ShadowColorButton.UseVisualStyleBackColor = true;
            this.ShadowColorButton.Click += new System.EventHandler(this.ShadowColorButton_Click);
            // 
            // GlossAdjustmentComboBox
            // 
            this.GlossAdjustmentComboBox.FormattingEnabled = true;
            this.GlossAdjustmentComboBox.Location = new System.Drawing.Point(164, 85);
            this.GlossAdjustmentComboBox.Name = "GlossAdjustmentComboBox";
            this.GlossAdjustmentComboBox.Size = new System.Drawing.Size(148, 21);
            this.GlossAdjustmentComboBox.TabIndex = 3;
            this.GlossAdjustmentComboBox.SelectedIndexChanged += new System.EventHandler(this.GlossAdjustmentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glossy Effecty on Characters";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "SX ROM Location";
            // 
            // RomLocationTextBox
            // 
            this.RomLocationTextBox.Location = new System.Drawing.Point(113, 6);
            this.RomLocationTextBox.Name = "RomLocationTextBox";
            this.RomLocationTextBox.ReadOnly = true;
            this.RomLocationTextBox.Size = new System.Drawing.Size(168, 20);
            this.RomLocationTextBox.TabIndex = 10;
            // 
            // SetRomLocationButton
            // 
            this.SetRomLocationButton.Location = new System.Drawing.Point(287, 4);
            this.SetRomLocationButton.Name = "SetRomLocationButton";
            this.SetRomLocationButton.Size = new System.Drawing.Size(25, 23);
            this.SetRomLocationButton.TabIndex = 11;
            this.SetRomLocationButton.Text = "...";
            this.SetRomLocationButton.UseVisualStyleBackColor = true;
            this.SetRomLocationButton.Click += new System.EventHandler(this.SetRomLocationButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dolphin Graphic Settings";
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Location = new System.Drawing.Point(12, 174);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(300, 29);
            this.SaveSettingsButton.TabIndex = 14;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SetRomLocationButton);
            this.Controls.Add(this.RomLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GlossAdjustmentComboBox);
            this.Controls.Add(this.ShadowColorButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UiButtonDisplayComboBox);
            this.Controls.Add(this.ControllerSettingsButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SaveSettingsButton;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button SetRomLocationButton;

        private System.Windows.Forms.TextBox RomLocationTextBox;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox GlossAdjustmentComboBox;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button ControllerSettingsButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox UiButtonDisplayComboBox;

        private System.Windows.Forms.Button ShadowColorButton;

        #endregion
    }
}