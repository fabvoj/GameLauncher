namespace GameLauncher
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.logoName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logoImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.register11 = new GameLauncher.register1();
            this.register21 = new GameLauncher.register2();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel1.BorderRadius = 6;
            this.guna2Panel1.Controls.Add(this.btnLogout);
            this.guna2Panel1.Controls.Add(this.register11);
            this.guna2Panel1.Controls.Add(this.register21);
            this.guna2Panel1.Controls.Add(this.logoName);
            this.guna2Panel1.Controls.Add(this.logoImg);
            this.guna2Panel1.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel1.Location = new System.Drawing.Point(221, 49);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(646, 508);
            this.guna2Panel1.TabIndex = 10;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // logoName
            // 
            this.logoName.BackColor = System.Drawing.Color.Transparent;
            this.logoName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.logoName.Location = new System.Drawing.Point(43, 271);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(154, 42);
            this.logoName.TabIndex = 28;
            this.logoName.Text = "E C L I P S E";
            this.logoName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoName.Click += new System.EventHandler(this.logoName_Click);
            // 
            // logoImg
            // 
            this.logoImg.Image = global::GameLauncher.Properties.Resources.eclipse_logo100x100;
            this.logoImg.ImageRotate = 0F;
            this.logoImg.Location = new System.Drawing.Point(68, 153);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(100, 100);
            this.logoImg.TabIndex = 27;
            this.logoImg.TabStop = false;
            this.logoImg.Click += new System.EventHandler(this.logoImg_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(224, 0);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 508);
            this.guna2VSeparator1.TabIndex = 24;
            this.guna2VSeparator1.Click += new System.EventHandler(this.guna2VSeparator1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Animated = true;
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnLogout.BorderRadius = 6;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IndicateFocus = true;
            this.btnLogout.Location = new System.Drawing.Point(56, 435);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 36);
            this.btnLogout.TabIndex = 38;
            this.btnLogout.Text = "BACK TO LOGIN";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // register11
            // 
            this.register11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.register11.Location = new System.Drawing.Point(241, 0);
            this.register11.Name = "register11";
            this.register11.Size = new System.Drawing.Size(405, 507);
            this.register11.TabIndex = 31;
            this.register11.Load += new System.EventHandler(this.register11_Load);
            // 
            // register21
            // 
            this.register21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.register21.Location = new System.Drawing.Point(240, 0);
            this.register21.Name = "register21";
            this.register21.Size = new System.Drawing.Size(412, 508);
            this.register21.TabIndex = 32;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel logoName;
        private Guna.UI2.WinForms.Guna2PictureBox logoImg;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private register1 register11;
        private register2 register21;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}