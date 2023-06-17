﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            changeHomeBtn.Checked = true;
            changeName1.Visible = false;
            changeGender1.Visible = false;
            changeEmail1.Visible = false;
            changeUsername1.Visible = false;
            changePass1.Visible = false;

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeHomeBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = false;
            changeGender1.Visible = false;
            changeEmail1.Visible = false;
            changeUsername1.Visible = false;
            changePass1.Visible = false;
            if (changeGenderBtn.Checked == true || changeNameBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true || changePfpBtn.Checked == true)
            {
                changeGenderBtn.Checked = false;
                changeNameBtn.Checked = false;
                changeEmailBtn.Checked = false;
                changeUsernameBtn.Checked = false;
                changePassBtn.Checked = false;
                changePfpBtn.Checked = false;
            }
            changeHomeBtn.Checked = true;
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = true;
            changeGender1.Visible = false;
            changeEmail1.Visible = false;
            changeUsername1.Visible = false;
            changePass1.Visible = false;
            if (changeGenderBtn.Checked == true || changeHomeBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true || changePfpBtn.Checked == true)
            {
                changeGenderBtn.Checked = false;
                changeHomeBtn.Checked = false;
                changeEmailBtn.Checked = false;
                changeUsernameBtn.Checked = false;
                changePassBtn.Checked = false;
                changePfpBtn.Checked = false;
            }
            changeNameBtn.Checked = true;
        }

        private void changeGenderBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = false;
            changeGender1.Visible = true;
            changeEmail1.Visible = false;
            changeUsername1.Visible = false;
            changePass1.Visible = false;
            if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true || changePfpBtn.Checked == true)
            {
                changeNameBtn.Checked = false;
                changeHomeBtn.Checked = false;
                changeEmailBtn.Checked = false;
                changeUsernameBtn.Checked = false;
                changePassBtn.Checked = false;
                changePfpBtn.Checked = false;
            }
            changeGenderBtn.Checked = true;
        }

        private void changeEmailBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = false;
            changeGender1.Visible = false;
            changeEmail1.Visible = true;
            changeUsername1.Visible = false;
            changePass1.Visible = false;
            if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeGenderBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true || changePfpBtn.Checked == true)
            {
                changeNameBtn.Checked = false;
                changeHomeBtn.Checked = false;
                changeGenderBtn.Checked = false;
                changeUsernameBtn.Checked = false;
                changePassBtn.Checked = false;
                changePfpBtn.Checked = false;
            }
            changeEmailBtn.Checked = true;
        }

        private void changeUsernameBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = false;
            changeGender1.Visible = false;
            changeEmail1.Visible = false;
            changeUsername1.Visible = true;
            changePass1.Visible = false;
            if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeGenderBtn.Checked == true || changeEmailBtn.Checked == true || changePassBtn.Checked == true || changePfpBtn.Checked == true)
            {
                changeNameBtn.Checked = false;
                changeHomeBtn.Checked = false;
                changeGenderBtn.Checked = false;
                changeEmailBtn.Checked = false;
                changePassBtn.Checked = false;
                changePfpBtn.Checked = false;
            }
            changeUsernameBtn.Checked = true;
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = false;
            changeGender1.Visible = false;
            changeEmail1.Visible = false;
            changeUsername1.Visible = false;
            changePass1.Visible = true;
            if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeGenderBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePfpBtn.Checked == true)
            {
                changeNameBtn.Checked = false;
                changeHomeBtn.Checked = false;
                changeGenderBtn.Checked = false;
                changeEmailBtn.Checked = false;
                changeUsernameBtn.Checked = false;
                changePfpBtn.Checked = false;
            }
            changePassBtn.Checked = true;
        }

        private void changePfpBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void changeBackBtn_Click(object sender, EventArgs e)
        {
            changeName1.Visible = false;
            changeGender1.Visible = false;
            changeEmail1.Visible = false;

            this.Hide();
            library bookroom = new library();
            bookroom.ShowDialog();
        }
    }
}