using System;
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
        public static string objekt;
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
            objekt = "Home";
            highlight_show();
        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {
            objekt = "Name";
            highlight_show();
        }

        private void changeGenderBtn_Click(object sender, EventArgs e)
        {
            objekt = "Gender";
            highlight_show();
        }

        private void changeEmailBtn_Click(object sender, EventArgs e)
        {
            objekt = "Email";
            highlight_show();
        }

        private void changeUsernameBtn_Click(object sender, EventArgs e)
        {
            objekt = "Username";
            highlight_show();
        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {
            objekt = "Pass";
            highlight_show();
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
            home dom = new home();
            dom.ShowDialog();
        }

        private void highlight_show()
        {
            switch (objekt)
            {
                case "Home":
                    changeName1.Visible = false;
                    changeGender1.Visible = false;
                    changeEmail1.Visible = false;
                    changeUsername1.Visible = false;
                    changePass1.Visible = false;
                    if (changeGenderBtn.Checked == true || changeNameBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true)
                    {
                        changeGenderBtn.Checked = false;
                        changeNameBtn.Checked = false;
                        changeEmailBtn.Checked = false;
                        changeUsernameBtn.Checked = false;
                        changePassBtn.Checked = false;
                    }
                    changeHomeBtn.Checked = true;
                    break;

                case "Name":
                    changeName1.Visible = true;
                    changeGender1.Visible = false;
                    changeEmail1.Visible = false;
                    changeUsername1.Visible = false;
                    changePass1.Visible = false;
                    if (changeGenderBtn.Checked == true || changeHomeBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true)
                    {
                        changeGenderBtn.Checked = false;
                        changeHomeBtn.Checked = false;
                        changeEmailBtn.Checked = false;
                        changeUsernameBtn.Checked = false;
                        changePassBtn.Checked = false;
                    }
                    changeNameBtn.Checked = true;
                    break;

                case "Gender":
                    changeName1.Visible = false;
                    changeGender1.Visible = true;
                    changeEmail1.Visible = false;
                    changeUsername1.Visible = false;
                    changePass1.Visible = false;
                    if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true)
                    {
                        changeNameBtn.Checked = false;
                        changeHomeBtn.Checked = false;
                        changeEmailBtn.Checked = false;
                        changeUsernameBtn.Checked = false;
                        changePassBtn.Checked = false;
                    }
                    changeGenderBtn.Checked = true;
                    break;

                case "Email":
                    changeName1.Visible = false;
                    changeGender1.Visible = false;
                    changeEmail1.Visible = true;
                    changeUsername1.Visible = false;
                    changePass1.Visible = false;
                    if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeGenderBtn.Checked == true || changeUsernameBtn.Checked == true || changePassBtn.Checked == true)
                    {
                        changeNameBtn.Checked = false;
                        changeHomeBtn.Checked = false;
                        changeGenderBtn.Checked = false;
                        changeUsernameBtn.Checked = false;
                        changePassBtn.Checked = false;
                    }
                    changeEmailBtn.Checked = true;
                    break;

                case "Username":
                    changeName1.Visible = false;
                    changeGender1.Visible = false;
                    changeEmail1.Visible = false;
                    changeUsername1.Visible = true;
                    changePass1.Visible = false;
                    if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeGenderBtn.Checked == true || changeEmailBtn.Checked == true || changePassBtn.Checked == true)
                    {
                        changeNameBtn.Checked = false;
                        changeHomeBtn.Checked = false;
                        changeGenderBtn.Checked = false;
                        changeEmailBtn.Checked = false;
                        changePassBtn.Checked = false;
                    }
                    changeUsernameBtn.Checked = true;
                    break;

                case "Pass":
                    changeName1.Visible = false;
                    changeGender1.Visible = false;
                    changeEmail1.Visible = false;
                    changeUsername1.Visible = false;
                    changePass1.Visible = true;
                    if (changeNameBtn.Checked == true || changeHomeBtn.Checked == true || changeGenderBtn.Checked == true || changeEmailBtn.Checked == true || changeUsernameBtn.Checked == true)
                    {
                        changeNameBtn.Checked = false;
                        changeHomeBtn.Checked = false;
                        changeGenderBtn.Checked = false;
                        changeEmailBtn.Checked = false;
                        changeUsernameBtn.Checked = false;
                    }
                    changePassBtn.Checked = true;
                    break;
            }
        }
    }
}
