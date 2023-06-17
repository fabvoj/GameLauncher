namespace GameLauncher
{
    partial class changeName
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.changeFNameBtn = new Guna.UI2.WinForms.Guna2TextBox();
            this.changeLNameBtn = new Guna.UI2.WinForms.Guna2TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.changeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(192, 55);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(411, 67);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Change your Name";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // changeFNameBtn
            // 
            this.changeFNameBtn.BorderColor = System.Drawing.Color.White;
            this.changeFNameBtn.BorderRadius = 6;
            this.changeFNameBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeFNameBtn.DefaultText = "";
            this.changeFNameBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeFNameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeFNameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeFNameBtn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeFNameBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.changeFNameBtn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeFNameBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeFNameBtn.ForeColor = System.Drawing.Color.White;
            this.changeFNameBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeFNameBtn.Location = new System.Drawing.Point(192, 169);
            this.changeFNameBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.changeFNameBtn.Name = "changeFNameBtn";
            this.changeFNameBtn.PasswordChar = '\0';
            this.changeFNameBtn.PlaceholderForeColor = System.Drawing.Color.White;
            this.changeFNameBtn.PlaceholderText = "";
            this.changeFNameBtn.SelectedText = "";
            this.changeFNameBtn.Size = new System.Drawing.Size(411, 64);
            this.changeFNameBtn.TabIndex = 1;
            this.changeFNameBtn.TextChanged += new System.EventHandler(this.changeFNameBtn_TextChanged);
            // 
            // changeLNameBtn
            // 
            this.changeLNameBtn.BorderColor = System.Drawing.Color.White;
            this.changeLNameBtn.BorderRadius = 6;
            this.changeLNameBtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.changeLNameBtn.DefaultText = "";
            this.changeLNameBtn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.changeLNameBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.changeLNameBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeLNameBtn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.changeLNameBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.changeLNameBtn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeLNameBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeLNameBtn.ForeColor = System.Drawing.Color.White;
            this.changeLNameBtn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeLNameBtn.Location = new System.Drawing.Point(192, 295);
            this.changeLNameBtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.changeLNameBtn.Name = "changeLNameBtn";
            this.changeLNameBtn.PasswordChar = '\0';
            this.changeLNameBtn.PlaceholderForeColor = System.Drawing.Color.White;
            this.changeLNameBtn.PlaceholderText = "";
            this.changeLNameBtn.SelectedText = "";
            this.changeLNameBtn.Size = new System.Drawing.Size(411, 64);
            this.changeLNameBtn.TabIndex = 2;
            this.changeLNameBtn.TextChanged += new System.EventHandler(this.changeLNameBtn_TextChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
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
            this.changeBtn.Location = new System.Drawing.Point(281, 435);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(243, 60);
            this.changeBtn.TabIndex = 7;
            this.changeBtn.Text = "CHANGE";
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // changeName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.changeLNameBtn);
            this.Controls.Add(this.changeFNameBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "changeName";
            this.Size = new System.Drawing.Size(872, 608);
            this.Load += new System.EventHandler(this.changeName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox changeFNameBtn;
        private Guna.UI2.WinForms.Guna2TextBox changeLNameBtn;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Guna.UI2.WinForms.Guna2Button changeBtn;
    }
}
