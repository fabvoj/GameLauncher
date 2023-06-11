namespace GameLauncher
{
    partial class Hry
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
            this.gamePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameName = new System.Windows.Forms.Label();
            this.gamePrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePicture
            // 
            this.gamePicture.BorderRadius = 5;
            this.gamePicture.ImageRotate = 0F;
            this.gamePicture.Location = new System.Drawing.Point(16, 16);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(248, 296);
            this.gamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.gamePicture.TabIndex = 0;
            this.gamePicture.TabStop = false;
            this.gamePicture.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // gameName
            // 
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameName.Location = new System.Drawing.Point(16, 326);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(248, 22);
            this.gameName.TabIndex = 1;
            this.gameName.Text = "Name";
            this.gameName.Click += new System.EventHandler(this.label1_Click);
            // 
            // gamePrice
            // 
            this.gamePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamePrice.Location = new System.Drawing.Point(18, 360);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(246, 23);
            this.gamePrice.TabIndex = 2;
            this.gamePrice.Text = "Price";
            // 
            // Hry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gamePicture);
            this.Name = "Hry";
            this.Size = new System.Drawing.Size(280, 394);
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox gamePicture;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label gamePrice;
    }
}
