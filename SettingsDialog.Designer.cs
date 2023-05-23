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
            this.SuspendLayout();
            // 
            // ControllerSettingsButton
            // 
            this.ControllerSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ControllerSettingsButton.Location = new System.Drawing.Point(18, 180);
            this.ControllerSettingsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ControllerSettingsButton.Name = "ControllerSettingsButton";
            this.ControllerSettingsButton.Size = new System.Drawing.Size(294, 78);
            this.ControllerSettingsButton.TabIndex = 4;
            this.ControllerSettingsButton.Text = "Open Dolphin Interface";
            this.ControllerSettingsButton.UseVisualStyleBackColor = true;
            this.ControllerSettingsButton.Click += new System.EventHandler(this.ControllerSettingsButton_Click);
            // 
            // UiButtonDisplayComboBox
            // 
            this.UiButtonDisplayComboBox.FormattingEnabled = true;
            this.UiButtonDisplayComboBox.Location = new System.Drawing.Point(170, 89);
            this.UiButtonDisplayComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UiButtonDisplayComboBox.Name = "UiButtonDisplayComboBox";
            this.UiButtonDisplayComboBox.Size = new System.Drawing.Size(180, 28);
            this.UiButtonDisplayComboBox.TabIndex = 0;
            this.UiButtonDisplayComboBox.Text = "Steam Deck";
            this.UiButtonDisplayComboBox.SelectedValueChanged += new System.EventHandler(this.UiButtonDisplayComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "UI Buttons Display";
            // 
            // ShadowColorButton
            // 
            this.ShadowColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShadowColorButton.Location = new System.Drawing.Point(326, 180);
            this.ShadowColorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShadowColorButton.Name = "ShadowColorButton";
            this.ShadowColorButton.Size = new System.Drawing.Size(142, 78);
            this.ShadowColorButton.TabIndex = 5;
            this.ShadowColorButton.Text = "Customize Shadow Color\r\n";
            this.ShadowColorButton.UseVisualStyleBackColor = true;
            this.ShadowColorButton.Click += new System.EventHandler(this.ShadowColorButton_Click);
            // 
            // GlossAdjustmentComboBox
            // 
            this.GlossAdjustmentComboBox.FormattingEnabled = true;
            this.GlossAdjustmentComboBox.Location = new System.Drawing.Point(246, 131);
            this.GlossAdjustmentComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GlossAdjustmentComboBox.Name = "GlossAdjustmentComboBox";
            this.GlossAdjustmentComboBox.Size = new System.Drawing.Size(220, 28);
            this.GlossAdjustmentComboBox.TabIndex = 3;
            this.GlossAdjustmentComboBox.SelectedIndexChanged += new System.EventHandler(this.GlossAdjustmentComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(18, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Glossy Effecty on Characters";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "SX ROM Location";
            // 
            // RomLocationTextBox
            // 
            this.RomLocationTextBox.Location = new System.Drawing.Point(170, 9);
            this.RomLocationTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RomLocationTextBox.Name = "RomLocationTextBox";
            this.RomLocationTextBox.ReadOnly = true;
            this.RomLocationTextBox.Size = new System.Drawing.Size(250, 26);
            this.RomLocationTextBox.TabIndex = 10;
            // 
            // SetRomLocationButton
            // 
            this.SetRomLocationButton.Location = new System.Drawing.Point(430, 6);
            this.SetRomLocationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SetRomLocationButton.Name = "SetRomLocationButton";
            this.SetRomLocationButton.Size = new System.Drawing.Size(38, 35);
            this.SetRomLocationButton.TabIndex = 11;
            this.SetRomLocationButton.Text = "...";
            this.SetRomLocationButton.UseVisualStyleBackColor = true;
            this.SetRomLocationButton.Click += new System.EventHandler(this.SetRomLocationButton_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(18, 58);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dolphin Graphic Settings";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(486, 277);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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