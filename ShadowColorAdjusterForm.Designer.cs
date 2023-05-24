namespace ShadowSXLauncher
{
    partial class ShadowColorAdjuster
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
            this.AccentColorPreview = new System.Windows.Forms.PictureBox();
            this.PreviewPicture = new System.Windows.Forms.PictureBox();
            this.SaveImage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MainColorPreview = new System.Windows.Forms.PictureBox();
            this.MainColorEditor = new Cyotek.Windows.Forms.ColorEditor();
            this.AccentColorEditor = new Cyotek.Windows.Forms.ColorEditor();
            ((System.ComponentModel.ISupportInitialize)(this.AccentColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // AccentColorPreview
            // 
            this.AccentColorPreview.BackColor = System.Drawing.Color.White;
            this.AccentColorPreview.Location = new System.Drawing.Point(321, 253);
            this.AccentColorPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AccentColorPreview.Name = "AccentColorPreview";
            this.AccentColorPreview.Size = new System.Drawing.Size(150, 154);
            this.AccentColorPreview.TabIndex = 3;
            this.AccentColorPreview.TabStop = false;
            // 
            // PreviewPicture
            // 
            this.PreviewPicture.Image = global::ShadowSXLauncher.Properties.Resources.ShadowPreviewBase;
            this.PreviewPicture.Location = new System.Drawing.Point(13, 14);
            this.PreviewPicture.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PreviewPicture.Name = "PreviewPicture";
            this.PreviewPicture.Size = new System.Drawing.Size(300, 400);
            this.PreviewPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PreviewPicture.TabIndex = 21;
            this.PreviewPicture.TabStop = false;
            // 
            // SaveImage
            // 
            this.SaveImage.Location = new System.Drawing.Point(13, 424);
            this.SaveImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveImage.Name = "SaveImage";
            this.SaveImage.Size = new System.Drawing.Size(300, 35);
            this.SaveImage.TabIndex = 23;
            this.SaveImage.Text = "Export Textures";
            this.SaveImage.UseVisualStyleBackColor = true;
            this.SaveImage.Click += new System.EventHandler(this.SaveImage_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(321, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 35);
            this.label7.TabIndex = 25;
            this.label7.Text = "Accent Color";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(321, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 35);
            this.label8.TabIndex = 45;
            this.label8.Text = "Main Color";
            // 
            // MainColorPreview
            // 
            this.MainColorPreview.BackColor = System.Drawing.Color.White;
            this.MainColorPreview.Location = new System.Drawing.Point(321, 54);
            this.MainColorPreview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainColorPreview.Name = "MainColorPreview";
            this.MainColorPreview.Size = new System.Drawing.Size(150, 154);
            this.MainColorPreview.TabIndex = 27;
            this.MainColorPreview.TabStop = false;
            // 
            // MainColorEditor
            // 
            this.MainColorEditor.Location = new System.Drawing.Point(480, 19);
            this.MainColorEditor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MainColorEditor.Name = "MainColorEditor";
            this.MainColorEditor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.MainColorEditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainColorEditor.ShowAlphaChannel = false;
            this.MainColorEditor.Size = new System.Drawing.Size(720, 189);
            this.MainColorEditor.TabIndex = 48;
            this.MainColorEditor.ColorChanged += new System.EventHandler(this.MainColorEditor_ColorChanged);
            // 
            // AccentColorEditor
            // 
            this.AccentColorEditor.Location = new System.Drawing.Point(480, 217);
            this.AccentColorEditor.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.AccentColorEditor.Name = "AccentColorEditor";
            this.AccentColorEditor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.AccentColorEditor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AccentColorEditor.ShowAlphaChannel = false;
            this.AccentColorEditor.Size = new System.Drawing.Size(720, 189);
            this.AccentColorEditor.TabIndex = 49;
            this.AccentColorEditor.ColorChanged += new System.EventHandler(this.AccentColorEditor_ColorChanged);
            // 
            // ShadowColorAdjuster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 470);
            this.Controls.Add(this.AccentColorEditor);
            this.Controls.Add(this.MainColorEditor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MainColorPreview);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SaveImage);
            this.Controls.Add(this.PreviewPicture);
            this.Controls.Add(this.AccentColorPreview);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShadowColorAdjuster";
            this.Text = "ShadowColorAdjuster";
            ((System.ComponentModel.ISupportInitialize)(this.AccentColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainColorPreview)).EndInit();
            this.ResumeLayout(false);
        }

        private Cyotek.Windows.Forms.ColorEditor AccentColorEditor;

        private Cyotek.Windows.Forms.ColorEditor MainColorEditor;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox MainColorPreview;

        private System.Windows.Forms.Button SaveImage;

        private System.Windows.Forms.PictureBox PreviewPicture;

        private System.Windows.Forms.PictureBox AccentColorPreview;

        #endregion
    }
}