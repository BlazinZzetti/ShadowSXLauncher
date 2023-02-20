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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherDialog));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RunNoGUIButton = new System.Windows.Forms.Button();
            this.OpenFileLocationButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SaveFileButton = new System.Windows.Forms.Button();
            this.CreateRomButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShadowSXLauncher.Properties.Resources.S_SX_Launcher_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RunNoGUIButton
            // 
            this.RunNoGUIButton.Location = new System.Drawing.Point(16, 158);
            this.RunNoGUIButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RunNoGUIButton.Name = "RunNoGUIButton";
            this.RunNoGUIButton.Size = new System.Drawing.Size(396, 28);
            this.RunNoGUIButton.TabIndex = 1;
            this.RunNoGUIButton.Text = "Run Shadow SX";
            this.RunNoGUIButton.UseVisualStyleBackColor = true;
            this.RunNoGUIButton.Click += new System.EventHandler(this.RunNoGUIButton_Click);
            // 
            // OpenFileLocationButton
            // 
            this.OpenFileLocationButton.Location = new System.Drawing.Point(16, 229);
            this.OpenFileLocationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OpenFileLocationButton.Name = "OpenFileLocationButton";
            this.OpenFileLocationButton.Size = new System.Drawing.Size(396, 28);
            this.OpenFileLocationButton.TabIndex = 3;
            this.OpenFileLocationButton.Text = "Open Game Location\r\n";
            this.OpenFileLocationButton.UseVisualStyleBackColor = true;
            this.OpenFileLocationButton.Click += new System.EventHandler(this.OpenFileLocationButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(16, 300);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(396, 28);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // SaveFileButton
            // 
            this.SaveFileButton.Location = new System.Drawing.Point(16, 265);
            this.SaveFileButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveFileButton.Name = "SaveFileButton";
            this.SaveFileButton.Size = new System.Drawing.Size(396, 28);
            this.SaveFileButton.TabIndex = 4;
            this.SaveFileButton.Text = "Save File Management";
            this.SaveFileButton.UseVisualStyleBackColor = true;
            this.SaveFileButton.Click += new System.EventHandler(this.SaveFileButton_Click);
            // 
            // CreateRomButton
            // 
            this.CreateRomButton.Location = new System.Drawing.Point(16, 193);
            this.CreateRomButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CreateRomButton.Name = "CreateRomButton";
            this.CreateRomButton.Size = new System.Drawing.Size(396, 28);
            this.CreateRomButton.TabIndex = 6;
            this.CreateRomButton.Text = "Create Shadow SX Rom";
            this.CreateRomButton.UseVisualStyleBackColor = true;
            this.CreateRomButton.Click += new System.EventHandler(this.CreateRomButton_Click);
            // 
            // LauncherDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 342);
            this.Controls.Add(this.CreateRomButton);
            this.Controls.Add(this.SaveFileButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.OpenFileLocationButton);
            this.Controls.Add(this.RunNoGUIButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LauncherDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadow SX Launcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button CreateRomButton;

        private System.Windows.Forms.Button SaveFileButton;

        private System.Windows.Forms.Button RunNoGUIButton;
        private System.Windows.Forms.Button OpenFileLocationButton;
        private System.Windows.Forms.Button SettingsButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}