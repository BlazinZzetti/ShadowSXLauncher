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
            this.GraphicsSettingsButton = new System.Windows.Forms.Button();
            this.ShadowColorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ControllerSettingsButton
            // 
            this.ControllerSettingsButton.Location = new System.Drawing.Point(12, 71);
            this.ControllerSettingsButton.Name = "ControllerSettingsButton";
            this.ControllerSettingsButton.Size = new System.Drawing.Size(95, 51);
            this.ControllerSettingsButton.TabIndex = 0;
            this.ControllerSettingsButton.Text = "Controller Settings (Dolphin)";
            this.ControllerSettingsButton.UseVisualStyleBackColor = true;
            // 
            // ModernUIControlCheckBox
            // 
            this.ModernUIControlCheckBox.Location = new System.Drawing.Point(12, 12);
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
            this.UiButtonDisplayComboBox.Location = new System.Drawing.Point(113, 42);
            this.UiButtonDisplayComboBox.Name = "UiButtonDisplayComboBox";
            this.UiButtonDisplayComboBox.Size = new System.Drawing.Size(121, 21);
            this.UiButtonDisplayComboBox.TabIndex = 2;
            this.UiButtonDisplayComboBox.Text = "Steam Deck";
            this.UiButtonDisplayComboBox.SelectedValueChanged += new System.EventHandler(this.UiButtonDisplayComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "UI Buttons Display";
            // 
            // GraphicsSettingsButton
            // 
            this.GraphicsSettingsButton.Location = new System.Drawing.Point(113, 71);
            this.GraphicsSettingsButton.Name = "GraphicsSettingsButton";
            this.GraphicsSettingsButton.Size = new System.Drawing.Size(95, 51);
            this.GraphicsSettingsButton.TabIndex = 4;
            this.GraphicsSettingsButton.Text = "Graphics Settings (Dolphin)";
            this.GraphicsSettingsButton.UseVisualStyleBackColor = true;
            // 
            // ShadowColorButton
            // 
            this.ShadowColorButton.Location = new System.Drawing.Point(214, 71);
            this.ShadowColorButton.Name = "ShadowColorButton";
            this.ShadowColorButton.Size = new System.Drawing.Size(95, 51);
            this.ShadowColorButton.TabIndex = 5;
            this.ShadowColorButton.Text = "Customize Shadow Color\r\n";
            this.ShadowColorButton.UseVisualStyleBackColor = true;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(316, 130);
            this.Controls.Add(this.ShadowColorButton);
            this.Controls.Add(this.GraphicsSettingsButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UiButtonDisplayComboBox);
            this.Controls.Add(this.ModernUIControlCheckBox);
            this.Controls.Add(this.ControllerSettingsButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.Text = "Settings";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button ControllerSettingsButton;

        private System.Windows.Forms.Button GraphicsSettingsButton;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox UiButtonDisplayComboBox;

        private System.Windows.Forms.CheckBox ModernUIControlCheckBox;

        private System.Windows.Forms.Button ShadowColorButton;

        #endregion
    }
}