﻿namespace GameLauncher
{
    partial class home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.downloadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pfpBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.homeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.storeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.libraryBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.logoImg = new Guna.UI2.WinForms.Guna2PictureBox();
            this.logoName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.kalendar = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
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
            this.guna2Panel1.Controls.Add(this.downloadBtn);
            this.guna2Panel1.Controls.Add(this.pfpBtn);
            this.guna2Panel1.Controls.Add(this.homeBtn);
            this.guna2Panel1.Controls.Add(this.storeBtn);
            this.guna2Panel1.Controls.Add(this.libraryBtn);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(200, 608);
            this.guna2Panel1.TabIndex = 0;
            // 
            // downloadBtn
            // 
            this.downloadBtn.Animated = true;
            this.downloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.downloadBtn.BorderColor = System.Drawing.Color.Transparent;
            this.downloadBtn.BorderRadius = 6;
            this.downloadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.downloadBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.downloadBtn.ForeColor = System.Drawing.Color.White;
            this.downloadBtn.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.downloadBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.downloadBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.downloadBtn.Image = global::GameLauncher.Properties.Resources.download;
            this.downloadBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.downloadBtn.Location = new System.Drawing.Point(12, 327);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(175, 45);
            this.downloadBtn.TabIndex = 12;
            this.downloadBtn.Text = "DOWNLOAD";
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_Click);
            // 
            // pfpBtn
            // 
            this.pfpBtn.AnimatedGIF = true;
            this.pfpBtn.BackColor = System.Drawing.Color.Transparent;
            this.pfpBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.pfpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pfpBtn.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.pfpBtn.Image = global::GameLauncher.Properties.Resources.man_pfp;
            this.pfpBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.pfpBtn.ImageRotate = 0F;
            this.pfpBtn.ImageSize = new System.Drawing.Size(50, 50);
            this.pfpBtn.Location = new System.Drawing.Point(76, 470);
            this.pfpBtn.Name = "pfpBtn";
            this.pfpBtn.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.pfpBtn.Size = new System.Drawing.Size(48, 48);
            this.pfpBtn.TabIndex = 10;
            this.pfpBtn.Click += new System.EventHandler(this.pfpBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Animated = true;
            this.homeBtn.BackColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.homeBtn.BorderRadius = 6;
            this.homeBtn.Checked = true;
            this.homeBtn.CheckedState.BorderColor = System.Drawing.Color.White;
            this.homeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.homeBtn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeBtn.CheckedState.ForeColor = System.Drawing.Color.White;
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
            this.homeBtn.Location = new System.Drawing.Point(12, 145);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(175, 45);
            this.homeBtn.TabIndex = 2;
            this.homeBtn.Text = "HOME";
            this.homeBtn.Click += new System.EventHandler(this.guna2Button2_Click);
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
            this.storeBtn.Location = new System.Drawing.Point(12, 205);
            this.storeBtn.Name = "storeBtn";
            this.storeBtn.Size = new System.Drawing.Size(175, 45);
            this.storeBtn.TabIndex = 3;
            this.storeBtn.Text = "STORE";
            this.storeBtn.Click += new System.EventHandler(this.guna2Button3_Click);
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
            this.libraryBtn.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.libraryBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.libraryBtn.Image = global::GameLauncher.Properties.Resources.library;
            this.libraryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.libraryBtn.Location = new System.Drawing.Point(12, 267);
            this.libraryBtn.Name = "libraryBtn";
            this.libraryBtn.Size = new System.Drawing.Size(175, 45);
            this.libraryBtn.TabIndex = 4;
            this.libraryBtn.Text = "LIBRARY";
            this.libraryBtn.Click += new System.EventHandler(this.libraryBtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Separator1.FillColor = System.Drawing.Color.White;
            this.guna2Separator1.Location = new System.Drawing.Point(285, 550);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(237, 10);
            this.guna2Separator1.TabIndex = 1;
            this.guna2Separator1.Click += new System.EventHandler(this.guna2Separator1_Click);
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
            this.guna2ControlBox3.TabIndex = 8;
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
            this.guna2ControlBox2.TabIndex = 7;
            this.guna2ControlBox2.UseTransparentBackground = true;
            this.guna2ControlBox2.Click += new System.EventHandler(this.guna2ControlBox2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(198, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(875, 556);
            this.flowLayoutPanel1.TabIndex = 11;
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BindingContainer = this.flowLayoutPanel1;
            this.guna2VScrollBar1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BorderRadius = 8;
            this.guna2VScrollBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(1055, 52);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 18;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(18, 556);
            this.guna2VScrollBar1.TabIndex = 0;
            this.guna2VScrollBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            // 
            // logoImg
            // 
            this.logoImg.Image = global::GameLauncher.Properties.Resources.eclipse_logo;
            this.logoImg.ImageRotate = 0F;
            this.logoImg.Location = new System.Drawing.Point(76, 60);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(48, 48);
            this.logoImg.TabIndex = 17;
            this.logoImg.TabStop = false;
            this.logoImg.Click += new System.EventHandler(this.logoImg_Click);
            // 
            // logoName
            // 
            this.logoName.BackColor = System.Drawing.Color.Transparent;
            this.logoName.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(73)))), ((int)(((byte)(236)))));
            this.logoName.Location = new System.Drawing.Point(24, 12);
            this.logoName.Name = "logoName";
            this.logoName.Size = new System.Drawing.Size(154, 42);
            this.logoName.TabIndex = 16;
            this.logoName.Text = "E C L I P S E";
            this.logoName.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.logoName.Click += new System.EventHandler(this.logoName_Click);
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
            this.kalendar.Location = new System.Drawing.Point(3, 574);
            this.kalendar.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.kalendar.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.kalendar.Name = "kalendar";
            this.kalendar.Size = new System.Drawing.Size(194, 22);
            this.kalendar.TabIndex = 18;
            this.kalendar.Value = new System.DateTime(2023, 6, 14, 0, 0, 0, 0);
            this.kalendar.ValueChanged += new System.EventHandler(this.kalendar_ValueChanged);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(196, 44);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(877, 10);
            this.guna2Separator2.TabIndex = 0;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(190, 50);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 558);
            this.guna2VSeparator1.TabIndex = 0;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(9)))), ((int)(((byte)(11)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2Button homeBtn;
        private Guna.UI2.WinForms.Guna2Button libraryBtn;
        private Guna.UI2.WinForms.Guna2Button storeBtn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton pfpBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2Button downloadBtn;
        private Guna.UI2.WinForms.Guna2PictureBox logoImg;
        private Guna.UI2.WinForms.Guna2HtmlLabel logoName;
        private Guna.UI2.WinForms.Guna2DateTimePicker kalendar;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
    }
}