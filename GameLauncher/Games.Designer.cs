namespace GameLauncher
{
    partial class Games
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
            this.gameTitle = new System.Windows.Forms.Label();
            this.gamePrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePicture
            // 
            this.gamePicture.BorderRadius = 10;
            this.gamePicture.FillColor = System.Drawing.Color.Transparent;
            this.gamePicture.ImageRotate = 0F;
            this.gamePicture.Location = new System.Drawing.Point(19, 26);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(210, 280);
            this.gamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePicture.TabIndex = 0;
            this.gamePicture.TabStop = false;
            this.gamePicture.Click += new System.EventHandler(this.gamePicture_Click);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameTitle.Location = new System.Drawing.Point(18, 320);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(41, 15);
            this.gameTitle.TabIndex = 1;
            this.gameTitle.Text = "label1";
            // 
            // gamePrice
            // 
            this.gamePrice.AutoSize = true;
            this.gamePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamePrice.Location = new System.Drawing.Point(20, 351);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(41, 15);
            this.gamePrice.TabIndex = 2;
            this.gamePrice.Text = "label2";
            this.gamePrice.Click += new System.EventHandler(this.gamePrice_Click);
            // 
            // Games
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.gamePicture);
            this.Name = "Games";
            this.Size = new System.Drawing.Size(250, 390);
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox gamePicture;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label gamePrice;
    }
}
