namespace ShadowSXLauncher
{
    partial class LauncherDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RunNoGUIButton = new System.Windows.Forms.Button();
            this.OpenFileLocationButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShadowSXLauncher.Properties.Resources.S_SX_Launcher_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RunNoGUIButton
            // 
            this.RunNoGUIButton.Location = new System.Drawing.Point(12, 128);
            this.RunNoGUIButton.Name = "RunNoGUIButton";
            this.RunNoGUIButton.Size = new System.Drawing.Size(297, 23);
            this.RunNoGUIButton.TabIndex = 1;
            this.RunNoGUIButton.Text = "Run Shadow SX";
            this.RunNoGUIButton.UseVisualStyleBackColor = true;
            this.RunNoGUIButton.Click += new System.EventHandler(this.RunNoGUIButton_Click);
            // 
            // OpenFileLocationButton
            // 
            this.OpenFileLocationButton.Location = new System.Drawing.Point(12, 157);
            this.OpenFileLocationButton.Name = "OpenFileLocationButton";
            this.OpenFileLocationButton.Size = new System.Drawing.Size(297, 23);
            this.OpenFileLocationButton.TabIndex = 3;
            this.OpenFileLocationButton.Text = "Open Game Location\r\n";
            this.OpenFileLocationButton.UseVisualStyleBackColor = true;
            this.OpenFileLocationButton.Click += new System.EventHandler(this.OpenFileLocationButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(12, 215);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(297, 23);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(12, 186);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(297, 23);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Save File Management";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // LauncherDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 248);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.OpenFileLocationButton);
            this.Controls.Add(this.RunNoGUIButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadow SX Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button SaveFileButton;

        private System.Windows.Forms.Button RunNoGUIButton;
        private System.Windows.Forms.Button OpenFileLocationButton;
        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}