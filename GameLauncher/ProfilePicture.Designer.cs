namespace GameLauncher
{
    partial class ProfilePicture
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pfpPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pfpPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pfpPicture
            // 
            this.pfpPicture.ImageRotate = 0F;
            this.pfpPicture.Location = new System.Drawing.Point(13, 12);
            this.pfpPicture.Name = "pfpPicture";
            this.pfpPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pfpPicture.Size = new System.Drawing.Size(125, 125);
            this.pfpPicture.TabIndex = 0;
            this.pfpPicture.TabStop = false;
            this.pfpPicture.Click += new System.EventHandler(this.pfpPicture_Click);
            // 
            // ProfilePicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pfpPicture);
            this.Name = "ProfilePicture";
            ((System.ComponentModel.ISupportInitialize)(this.pfpPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox pfpPicture;
    }
}
