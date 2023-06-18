﻿namespace GameLauncher
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gameCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.GameLogoInPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameDescription = new System.Windows.Forms.Label();
            this.gameLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gameDeveloper = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gameGenres = new System.Windows.Forms.Label();
            this.gameFeatures = new System.Windows.Forms.Label();
            this.gamePublisher = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gameRelease = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.gameLibrarybtn = new Guna.UI2.WinForms.Guna2Button();
            this.gamePrice = new Guna.UI2.WinForms.Guna2Button();
            this.gameName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameLogoInPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameCover
            // 
            this.gameCover.Image = ((System.Drawing.Image)(resources.GetObject("gameCover.Image")));
            this.gameCover.ImageRotate = 0F;
            this.gameCover.Location = new System.Drawing.Point(0, 0);
            this.gameCover.Name = "gameCover";
            this.gameCover.Size = new System.Drawing.Size(1135, 638);
            this.gameCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameCover.TabIndex = 0;
            this.gameCover.TabStop = false;
            // 
            // GameLogoInPicture
            // 
            this.GameLogoInPicture.BackColor = System.Drawing.Color.Transparent;
            this.GameLogoInPicture.FillColor = System.Drawing.Color.Transparent;
            this.GameLogoInPicture.Image = ((System.Drawing.Image)(resources.GetObject("GameLogoInPicture.Image")));
            this.GameLogoInPicture.ImageRotate = 0F;
            this.GameLogoInPicture.Location = new System.Drawing.Point(397, 123);
            this.GameLogoInPicture.Name = "GameLogoInPicture";
            this.GameLogoInPicture.Size = new System.Drawing.Size(340, 369);
            this.GameLogoInPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GameLogoInPicture.TabIndex = 1;
            this.GameLogoInPicture.TabStop = false;
            this.GameLogoInPicture.UseTransparentBackground = true;
            // 
            // gameDescription
            // 
            this.gameDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameDescription.ForeColor = System.Drawing.Color.White;
            this.gameDescription.Location = new System.Drawing.Point(17, 767);
            this.gameDescription.Name = "gameDescription";
            this.gameDescription.Size = new System.Drawing.Size(562, 606);
            this.gameDescription.TabIndex = 2;
            this.gameDescription.Text = "label1";
            this.gameDescription.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameLogo
            // 
            this.gameLogo.BackColor = System.Drawing.Color.Transparent;
            this.gameLogo.FillColor = System.Drawing.Color.Transparent;
            this.gameLogo.ImageRotate = 0F;
            this.gameLogo.Location = new System.Drawing.Point(29, 34);
            this.gameLogo.Name = "gameLogo";
            this.gameLogo.Size = new System.Drawing.Size(469, 333);
            this.gameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gameLogo.TabIndex = 3;
            this.gameLogo.TabStop = false;
            this.gameLogo.UseTransparentBackground = true;
            // 
            // gameDeveloper
            // 
            this.gameDeveloper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gameDeveloper.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameDeveloper.ForeColor = System.Drawing.Color.White;
            this.gameDeveloper.Location = new System.Drawing.Point(142, 452);
            this.gameDeveloper.Name = "gameDeveloper";
            this.gameDeveloper.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gameDeveloper.Size = new System.Drawing.Size(360, 31);
            this.gameDeveloper.TabIndex = 4;
            this.gameDeveloper.Text = "label2";
            this.gameDeveloper.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Developer";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 502);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(260, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Features";
            // 
            // gameGenres
            // 
            this.gameGenres.AutoSize = true;
            this.gameGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gameGenres.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameGenres.ForeColor = System.Drawing.Color.White;
            this.gameGenres.Location = new System.Drawing.Point(26, 417);
            this.gameGenres.Name = "gameGenres";
            this.gameGenres.Size = new System.Drawing.Size(35, 15);
            this.gameGenres.TabIndex = 9;
            this.gameGenres.Text = "zanre";
            // 
            // gameFeatures
            // 
            this.gameFeatures.AutoSize = true;
            this.gameFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gameFeatures.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameFeatures.ForeColor = System.Drawing.Color.White;
            this.gameFeatures.Location = new System.Drawing.Point(261, 417);
            this.gameFeatures.Name = "gameFeatures";
            this.gameFeatures.Size = new System.Drawing.Size(49, 15);
            this.gameFeatures.TabIndex = 10;
            this.gameFeatures.Text = "features";
            // 
            // gamePublisher
            // 
            this.gamePublisher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gamePublisher.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gamePublisher.ForeColor = System.Drawing.Color.White;
            this.gamePublisher.Location = new System.Drawing.Point(146, 502);
            this.gamePublisher.Name = "gamePublisher";
            this.gamePublisher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gamePublisher.Size = new System.Drawing.Size(356, 23);
            this.gamePublisher.TabIndex = 11;
            this.gamePublisher.Text = "pointer";
            this.gamePublisher.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 550);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Release date";
            // 
            // gameRelease
            // 
            this.gameRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gameRelease.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameRelease.ForeColor = System.Drawing.Color.White;
            this.gameRelease.Location = new System.Drawing.Point(187, 550);
            this.gameRelease.Name = "gameRelease";
            this.gameRelease.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gameRelease.Size = new System.Drawing.Size(315, 23);
            this.gameRelease.TabIndex = 13;
            this.gameRelease.Text = "release";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel1.Controls.Add(this.gameLibrarybtn);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label10);
            this.guna2Panel1.Controls.Add(this.gameRelease);
            this.guna2Panel1.Controls.Add(this.gamePrice);
            this.guna2Panel1.Controls.Add(this.gameLogo);
            this.guna2Panel1.Controls.Add(this.gamePublisher);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.gameDeveloper);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.gameFeatures);
            this.guna2Panel1.Controls.Add(this.gameGenres);
            this.guna2Panel1.Location = new System.Drawing.Point(608, 627);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(527, 715);
            this.guna2Panel1.TabIndex = 15;
            // 
            // gameLibrarybtn
            // 
            this.gameLibrarybtn.Animated = true;
            this.gameLibrarybtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gameLibrarybtn.BorderColor = System.Drawing.Color.Transparent;
            this.gameLibrarybtn.BorderRadius = 18;
            this.gameLibrarybtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gameLibrarybtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gameLibrarybtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gameLibrarybtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gameLibrarybtn.FillColor = System.Drawing.Color.DimGray;
            this.gameLibrarybtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gameLibrarybtn.ForeColor = System.Drawing.Color.White;
            this.gameLibrarybtn.IndicateFocus = true;
            this.gameLibrarybtn.Location = new System.Drawing.Point(37, 609);
            this.gameLibrarybtn.Name = "gameLibrarybtn";
            this.gameLibrarybtn.Size = new System.Drawing.Size(469, 65);
            this.gameLibrarybtn.TabIndex = 15;
            this.gameLibrarybtn.Text = "In library";
            this.gameLibrarybtn.Click += new System.EventHandler(this.gameLibrarybtn_Click);
            // 
            // gamePrice
            // 
            this.gamePrice.Animated = true;
            this.gamePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.gamePrice.BorderColor = System.Drawing.Color.Transparent;
            this.gamePrice.BorderRadius = 18;
            this.gamePrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gamePrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gamePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gamePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gamePrice.FillColor = System.Drawing.Color.Gray;
            this.gamePrice.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.gamePrice.ForeColor = System.Drawing.Color.White;
            this.gamePrice.IndicateFocus = true;
            this.gamePrice.Location = new System.Drawing.Point(37, 609);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(469, 65);
            this.gamePrice.TabIndex = 14;
            this.gamePrice.Text = "Buy now for ";
            this.gamePrice.Click += new System.EventHandler(this.gamePrice_Click);
            // 
            // gameName
            // 
            this.gameName.BackColor = System.Drawing.Color.Transparent;
            this.gameName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameName.ForeColor = System.Drawing.Color.White;
            this.gameName.Location = new System.Drawing.Point(15, 661);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(564, 106);
            this.gameName.TabIndex = 16;
            this.gameName.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.gameDescription);
            this.Controls.Add(this.GameLogoInPicture);
            this.Controls.Add(this.gameCover);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Game";
            this.Size = new System.Drawing.Size(1135, 1340);
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gameCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameLogoInPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameLogo)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox gameCover;
        private Guna.UI2.WinForms.Guna2PictureBox GameLogoInPicture;
        private System.Windows.Forms.Label gameDescription;
        private Guna.UI2.WinForms.Guna2PictureBox gameLogo;
        private System.Windows.Forms.Label gameDeveloper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gameGenres;
        private System.Windows.Forms.Label gameFeatures;
        private System.Windows.Forms.Label gamePublisher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label gameRelease;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button gamePrice;
        private System.Windows.Forms.Label gameName;
        private Guna.UI2.WinForms.Guna2Button gameLibrarybtn;
    }
}
