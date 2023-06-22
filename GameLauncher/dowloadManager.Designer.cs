﻿namespace GameLauncher
{
    partial class dowloadManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dowloadManager));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.kalendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.logoImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logoName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pfpBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.storeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.libraryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VScrollBar2 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.guna2Panel1.Controls.Add(this.guna2VSeparator1);
            this.guna2Panel1.Controls.Add(this.kalendar);
            this.guna2Panel1.Controls.Add(this.logoImg);
            this.guna2Panel1.Controls.Add(this.logoName);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.pfpBtn);
            this.guna2Panel1.Controls.Add(this.homeBtn);
            this.guna2Panel1.Controls.Add(this.storeBtn);
            this.guna2Panel1.Controls.Add(this.libraryBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(300, 935);
            this.guna2Panel1.TabIndex = 12;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(290, 77);
            this.guna2VSeparator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(15, 858);
            this.guna2VSeparator1.TabIndex = 21;
            // 
            // kalendar
            // 
            this.kalendar.Checked = true;
            this.kalendar.CheckedState.ForeColor = System.Drawing.Color.White;
            this.kalendar.Enabled = false;
            this.kalendar.FillColor = System.Drawing.Color.Transparent;
            this.kalendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.kalendar.ForeColor = System.Drawing.Color.White;
            this.kalendar.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.kalendar.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.kalendar.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.kalendar.HoverState.ForeColor = System.Drawing.Color.White;
            this.kalendar.Location = new System.Drawing.Point(4, 883);
            this.kalendar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kalendar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.kalendar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.kalendar.Name = "kalendar";
            this.kalendar.Size = new System.Drawing.Size(291, 34);
            this.kalendar.TabIndex = 20;
            this.kalendar.Value = new System.DateTime(2023, 6, 14, 0, 0, 0, 0);
            // 
            // logoImg
            // 
            this.logoImg.Image = global::GameLauncher.Properties.Resources.eclipse_logo;
            this.logoImg.ImageRotate = 0F;
            this.logoImg.Location = new System.Drawing.Point(114, 92);
            this.logoImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(72, 74);
            this.logoImg.TabIndex = 19;
            this.logoImg.TabStop = false;
            // 
            // logoName
            // 
            this.logoName.BackColor = System.Drawing.Color.Transparent;
            this.logoName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.logoName.Location = new System.Drawing.Point(36, 18);
            this.logoName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(233, 62);
            this.logoName.TabIndex = 18;
            this.logoName.Text = "E C L I P S E";
            this.logoName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.Checked = true;
            this.guna2Button1.CheckedState.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::GameLauncher.Properties.Resources.download;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(18, 503);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(262, 69);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "DOWNLOAD";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1308, 874);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // pfpBtn
            // 
            this.pfpBtn.BackColor = System.Drawing.Color.Transparent;
            this.pfpBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pfpBtn.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.pfpBtn.Image = global::GameLauncher.Properties.Resources.man_pfp;
            this.pfpBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.pfpBtn.ImageRotate = 0F;
            this.pfpBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.pfpBtn.Location = new System.Drawing.Point(114, 723);
            this.pfpBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pfpBtn.Name = "pfpBtn";
            this.pfpBtn.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.pfpBtn.Size = new System.Drawing.Size(72, 74);
            this.pfpBtn.TabIndex = 12;
            this.pfpBtn.Click += new System.EventHandler(this.pfpBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Animated = true;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderRadius = 6;
            this.homeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.homeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.homeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.homeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.homeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.homeBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.homeBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = global::GameLauncher.Properties.Resources.home;
            this.homeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.homeBtn.Location = new System.Drawing.Point(18, 223);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(262, 69);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "HOME";
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // storeBtn
            // 
            this.storeBtn.Animated = true;
            this.storeBtn.BackColor = System.Drawing.Color.Transparent;
            this.storeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.storeBtn.BorderRadius = 6;
            this.storeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.storeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.storeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.storeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.storeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.storeBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.storeBtn.ForeColor = System.Drawing.Color.White;
            this.storeBtn.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.storeBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.storeBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.storeBtn.Image = global::GameLauncher.Properties.Resources.store;
            this.storeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.storeBtn.Location = new System.Drawing.Point(18, 315);
            this.storeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(262, 69);
            this.storeBtn.TabIndex = 3;
            this.storeBtn.Text = "STORE";
            this.storeBtn.Click += new System.EventHandler(this.storeBtn_Click);
            // 
            // libraryBtn
            // 
            this.libraryBtn.Animated = true;
            this.libraryBtn.BackColor = System.Drawing.Color.Transparent;
            this.libraryBtn.BorderColor = System.Drawing.Color.Transparent;
            this.libraryBtn.BorderRadius = 6;
            this.libraryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.libraryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.libraryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.libraryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.libraryBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.libraryBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.libraryBtn.ForeColor = System.Drawing.Color.White;
            this.libraryBtn.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.libraryBtn.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.libraryBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.libraryBtn.Image = global::GameLauncher.Properties.Resources.library;
            this.libraryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.libraryBtn.Location = new System.Drawing.Point(18, 411);
            this.libraryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.libraryBtn.Name = "libraryBtn";
            this.libraryBtn.Size = new System.Drawing.Size(262, 69);
            this.libraryBtn.TabIndex = 4;
            this.libraryBtn.Text = "LIBRARY";
            this.libraryBtn.Click += new System.EventHandler(this.libraryBtn_Click);
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
            this.guna2ControlBox3.Location = new System.Drawing.Point(1500, 18);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2ControlBox3.Size = new System.Drawing.Size(45, 34);
            this.guna2ControlBox3.TabIndex = 14;
            this.guna2ControlBox3.UseTransparentBackground = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.CustomIconSize = 8F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1554, 18);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 34);
            this.guna2ControlBox2.TabIndex = 13;
            this.guna2ControlBox2.UseTransparentBackground = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(300, 77);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1308, 858);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanel2;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1054, 50);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 558);
            this.guna2VScrollBar1.TabIndex = 0;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.SteelBlue;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(290, 68);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1318, 15);
            this.guna2Separator2.TabIndex = 22;
            // 
            // guna2VScrollBar2
            // 
            this.guna2VScrollBar2.AutoRoundedCorners = true;
            this.guna2VScrollBar2.BindingContainer = this.flowLayoutPanel2;
            this.guna2VScrollBar2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar2.BorderRadius = 12;
            this.guna2VScrollBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2VScrollBar2.InUpdate = false;
            this.guna2VScrollBar2.LargeChange = 10;
            this.guna2VScrollBar2.Location = new System.Drawing.Point(1582, 77);
            this.guna2VScrollBar2.Name = "guna2VScrollBar2";
            this.guna2VScrollBar2.ScrollbarSize = 26;
            this.guna2VScrollBar2.Size = new System.Drawing.Size(26, 858);
            this.guna2VScrollBar2.TabIndex = 0;
            this.guna2VScrollBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            // 
            // dowloadManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1608, 935);
            this.Controls.Add(this.guna2VScrollBar2);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2Separator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "dowloadManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dowloadManager";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton pfpBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button storeBtn;
        private Guna.UI2.WinForms.Guna2Button libraryBtn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2PictureBox logoImg;
        private Guna.UI2.WinForms.Guna2HtmlLabel logoName;
        private Guna.UI2.WinForms.Guna2DateTimePicker kalendar;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar2;
    }
}