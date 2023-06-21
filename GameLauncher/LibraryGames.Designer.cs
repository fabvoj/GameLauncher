namespace GameLauncher
{
    partial class LibraryGames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryGames));
            this.gamePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameTitle = new System.Windows.Forms.Label();
            this.gamePrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // gamePicture
            // 
            this.gamePicture.BorderRadius = 20;
            this.gamePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamePicture.FillColor = System.Drawing.Color.Transparent;
            this.gamePicture.Image = ((System.Drawing.Image)(resources.GetObject("gamePicture.Image")));
            this.gamePicture.ImageRotate = 0F;
            this.gamePicture.Location = new System.Drawing.Point(5, 7);
            this.gamePicture.Margin = new System.Windows.Forms.Padding(2);
            this.gamePicture.Name = "gamePicture";
            this.gamePicture.Size = new System.Drawing.Size(196, 261);
            this.gamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamePicture.TabIndex = 1;
            this.gamePicture.TabStop = false;
            this.gamePicture.Click += new System.EventHandler(this.LibraryGames_Click);
            this.gamePicture.MouseEnter += new System.EventHandler(this.LibraryGames_MouseEnter);
            this.gamePicture.MouseLeave += new System.EventHandler(this.LibraryGames_MouseLeave);
            // 
            // gameTitle
            // 
            this.gameTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameTitle.ForeColor = System.Drawing.Color.White;
            this.gameTitle.Location = new System.Drawing.Point(4, 278);
            this.gameTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(198, 46);
            this.gameTitle.TabIndex = 2;
            this.gameTitle.Text = "label1";
            this.gameTitle.Click += new System.EventHandler(this.LibraryGames_Click);
            this.gameTitle.MouseEnter += new System.EventHandler(this.LibraryGames_MouseEnter);
            this.gameTitle.MouseLeave += new System.EventHandler(this.LibraryGames_MouseLeave);
            // 
            // gamePrice
            // 
            this.gamePrice.AutoSize = true;
            this.gamePrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamePrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamePrice.ForeColor = System.Drawing.Color.White;
            this.gamePrice.Location = new System.Drawing.Point(4, 330);
            this.gamePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(38, 15);
            this.gamePrice.TabIndex = 3;
            this.gamePrice.Text = "label2";
            this.gamePrice.Click += new System.EventHandler(this.LibraryGames_Click);
            this.gamePrice.MouseEnter += new System.EventHandler(this.LibraryGames_MouseEnter);
            this.gamePrice.MouseLeave += new System.EventHandler(this.LibraryGames_MouseLeave);
            // 
            // LibraryGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.gamePicture);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LibraryGames";
            this.Size = new System.Drawing.Size(207, 366);
            this.Click += new System.EventHandler(this.LibraryGames_Click);
            this.MouseEnter += new System.EventHandler(this.LibraryGames_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.LibraryGames_MouseLeave);
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
