namespace GameLauncher
{
    partial class register_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register_info));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.registerProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.logoName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.logoImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator2 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.labelCPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.txtCPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.stepLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelTerms = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel2.BorderRadius = 6;
            this.guna2Panel2.Controls.Add(this.labelTerms);
            this.guna2Panel2.Controls.Add(this.stepLabel);
            this.guna2Panel2.Controls.Add(this.registerProgressBar);
            this.guna2Panel2.Controls.Add(this.logoName);
            this.guna2Panel2.Controls.Add(this.logoImg);
            this.guna2Panel2.Controls.Add(this.btnCreate);
            this.guna2Panel2.Controls.Add(this.guna2VSeparator2);
            this.guna2Panel2.Controls.Add(this.labelCPass);
            this.guna2Panel2.Controls.Add(this.labelPass);
            this.guna2Panel2.Controls.Add(this.labelUsername);
            this.guna2Panel2.Controls.Add(this.txtUsername);
            this.guna2Panel2.Controls.Add(this.btnLogout);
            this.guna2Panel2.Controls.Add(this.txtCPassword);
            this.guna2Panel2.Controls.Add(this.txtPassword);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Panel2.Location = new System.Drawing.Point(221, 49);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(646, 508);
            this.guna2Panel2.TabIndex = 32;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // registerProgressBar
            // 
            this.registerProgressBar.BorderColor = System.Drawing.Color.White;
            this.registerProgressBar.BorderRadius = 6;
            this.registerProgressBar.BorderThickness = 1;
            this.registerProgressBar.FillColor = System.Drawing.Color.Transparent;
            this.registerProgressBar.Location = new System.Drawing.Point(43, 450);
            this.registerProgressBar.Name = "registerProgressBar";
            this.registerProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.registerProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.registerProgressBar.Size = new System.Drawing.Size(154, 10);
            this.registerProgressBar.TabIndex = 30;
            this.registerProgressBar.Text = "guna2ProgressBar1";
            this.registerProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.registerProgressBar.Value = 50;
            this.registerProgressBar.ValueChanged += new System.EventHandler(this.registerProgressBar_ValueChanged);
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
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnCreate.BorderRadius = 6;
            this.btnCreate.BorderThickness = 1;
            this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.IndicateFocus = true;
            this.btnCreate.Location = new System.Drawing.Point(281, 435);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(131, 36);
            this.btnCreate.TabIndex = 26;
            this.btnCreate.Text = "CREATE ACCOUNT";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // guna2VSeparator2
            // 
            this.guna2VSeparator2.Location = new System.Drawing.Point(224, 0);
            this.guna2VSeparator2.Name = "guna2VSeparator2";
            this.guna2VSeparator2.Size = new System.Drawing.Size(10, 508);
            this.guna2VSeparator2.TabIndex = 24;
            this.guna2VSeparator2.Click += new System.EventHandler(this.guna2VSeparator2_Click);
            // 
            // labelCPass
            // 
            this.labelCPass.BackColor = System.Drawing.Color.Transparent;
            this.labelCPass.ForeColor = System.Drawing.Color.White;
            this.labelCPass.Location = new System.Drawing.Point(240, 259);
            this.labelCPass.Name = "labelCPass";
            this.labelCPass.Size = new System.Drawing.Size(87, 15);
            this.labelCPass.TabIndex = 19;
            this.labelCPass.Text = "Confirm Password";
            this.labelCPass.Click += new System.EventHandler(this.labelCPass_Click);
            // 
            // labelPass
            // 
            this.labelPass.BackColor = System.Drawing.Color.Transparent;
            this.labelPass.ForeColor = System.Drawing.Color.White;
            this.labelPass.Location = new System.Drawing.Point(273, 176);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(49, 15);
            this.labelPass.TabIndex = 23;
            this.labelPass.Text = "Password";
            this.labelPass.Click += new System.EventHandler(this.labelPass_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(273, 102);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(51, 15);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderColor = System.Drawing.Color.White;
            this.txtUsername.BorderRadius = 6;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(333, 92);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(284, 36);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
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
            this.btnLogout.Location = new System.Drawing.Point(486, 435);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 36);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "BACK TO LOGIN";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // txtCPassword
            // 
            this.txtCPassword.Animated = true;
            this.txtCPassword.BorderColor = System.Drawing.Color.White;
            this.txtCPassword.BorderRadius = 6;
            this.txtCPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCPassword.DefaultText = "";
            this.txtCPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.txtCPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCPassword.ForeColor = System.Drawing.Color.White;
            this.txtCPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCPassword.Location = new System.Drawing.Point(333, 249);
            this.txtCPassword.MaxLength = 50;
            this.txtCPassword.Name = "txtCPassword";
            this.txtCPassword.PasswordChar = '*';
            this.txtCPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCPassword.PlaceholderText = "Confirm Password";
            this.txtCPassword.SelectedText = "";
            this.txtCPassword.Size = new System.Drawing.Size(284, 36);
            this.txtCPassword.TabIndex = 7;
            this.txtCPassword.TextChanged += new System.EventHandler(this.txtCPassword_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 6;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(333, 167);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(284, 36);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.CustomIconSize = 8F;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(994, 12);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2ControlBox3.Size = new System.Drawing.Size(30, 22);
            this.guna2ControlBox3.TabIndex = 34;
            this.guna2ControlBox3.UseTransparentBackground = true;
            this.guna2ControlBox3.Click += new System.EventHandler(this.guna2ControlBox3_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.CustomIconSize = 8F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1030, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 22);
            this.guna2ControlBox2.TabIndex = 33;
            this.guna2ControlBox2.UseTransparentBackground = true;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // stepLabel
            // 
            this.stepLabel.BackColor = System.Drawing.Color.Transparent;
            this.stepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stepLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(95)))), ((int)(((byte)(236)))));
            this.stepLabel.Location = new System.Drawing.Point(393, 21);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(138, 44);
            this.stepLabel.TabIndex = 32;
            this.stepLabel.Text = "STEP 2";
            this.stepLabel.Click += new System.EventHandler(this.stepLabel_Click);
            // 
            // labelTerms
            // 
            this.labelTerms.AutoSize = true;
            this.labelTerms.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.labelTerms.CheckedState.BorderRadius = 6;
            this.labelTerms.CheckedState.BorderThickness = 1;
            this.labelTerms.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.labelTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTerms.ForeColor = System.Drawing.Color.White;
            this.labelTerms.Location = new System.Drawing.Point(281, 338);
            this.labelTerms.Name = "labelTerms";
            this.labelTerms.Size = new System.Drawing.Size(338, 22);
            this.labelTerms.TabIndex = 33;
            this.labelTerms.Text = "Do you agreee with our Terms and Conditions?";
            this.labelTerms.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelTerms.UncheckedState.BorderRadius = 6;
            this.labelTerms.UncheckedState.BorderThickness = 1;
            this.labelTerms.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.labelTerms.CheckedChanged += new System.EventHandler(this.labelTerms_CheckedChanged);
            // 
            // register_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2Panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "register_info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "register_info";
            this.Load += new System.EventHandler(this.register_info_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ProgressBar registerProgressBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel logoName;
        private Guna.UI2.WinForms.Guna2PictureBox logoImg;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator2;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelCPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2TextBox txtCPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel stepLabel;
        private Guna.UI2.WinForms.Guna2CheckBox labelTerms;
    }
}