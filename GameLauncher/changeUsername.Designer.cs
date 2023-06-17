namespace GameLauncher
{
    partial class changeUsername
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
            this.changeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.changeUsernameBtn = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.Animated = true;
            this.changeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.changeBtn.BorderRadius = 6;
            this.changeBtn.BorderThickness = 1;
            this.changeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.changeBtn.ForeColor = System.Drawing.Color.White;
            this.changeBtn.IndicateFocus = true;
            this.changeBtn.Location = new System.Drawing.Point(316, 366);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(243, 60);
            this.changeBtn.TabIndex = 13;
            this.changeBtn.Text = "CHANGE";
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // changeUsernameBtn
            // 
            this.changeUsernameBtn.Animated = true;
            this.changeUsernameBtn.BorderColor = System.Drawing.Color.White;
            this.changeUsernameBtn.BorderRadius = 6;
            this.changeUsernameBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeUsernameBtn.DefaultText = "";
            this.changeUsernameBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeUsernameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeUsernameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeUsernameBtn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeUsernameBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.changeUsernameBtn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeUsernameBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeUsernameBtn.ForeColor = System.Drawing.Color.White;
            this.changeUsernameBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeUsernameBtn.Location = new System.Drawing.Point(226, 227);
            this.changeUsernameBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.changeUsernameBtn.Name = "changeUsernameBtn";
            this.changeUsernameBtn.PasswordChar = '\0';
            this.changeUsernameBtn.PlaceholderForeColor = System.Drawing.Color.White;
            this.changeUsernameBtn.PlaceholderText = "";
            this.changeUsernameBtn.SelectedText = "";
            this.changeUsernameBtn.Size = new System.Drawing.Size(411, 64);
            this.changeUsernameBtn.TabIndex = 12;
            this.changeUsernameBtn.TextChanged += new System.EventHandler(this.changeUsernameBtn_TextChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(203, 114);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(497, 67);
            this.guna2HtmlLabel1.TabIndex = 11;
            this.guna2HtmlLabel1.Text = "Change your Username";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // changeUsername
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.changeUsernameBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "changeUsername";
            this.Size = new System.Drawing.Size(872, 608);
            this.Load += new System.EventHandler(this.changeUsername_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button changeBtn;
        private Guna.UI2.WinForms.Guna2TextBox changeUsernameBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
