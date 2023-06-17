using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace GameLauncher
{
    public partial class register_info : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string defaultPfp;

        public register_info()
        {
            InitializeComponent();
        }

        private void register_info_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void logoImg_Click(object sender, EventArgs e)
        {

        }

        private void logoName_Click(object sender, EventArgs e)
        {

        }

        private void registerProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void stepLabel_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void txtCPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCPass_Click(object sender, EventArgs e)
        {

        }

        private void labelTerms_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MySqlConnection connection2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
            connection2.Open();
            string deleteUserqry = "DELETE FROM userinfo WHERE Email='"+register_bio.newEmail+"';";
            MySqlCommand removedUser = new MySqlCommand(deleteUserqry, connection2);
            removedUser.ExecuteScalar();

            this.Hide();
            login frm4 = new login();
            frm4.ShowDialog();

            connection2.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string forbidden_user = @"^[a-zA-Z0-9_]+$";
            if (txtPassword.Text != txtCPassword.Text)
            {
                txtPassword.BorderColor = Color.Red;
                txtCPassword.BorderColor = Color.Red;
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCPassword.Text))
            {
                txtUsername.BorderColor = Color.Red;
                txtPassword.BorderColor = Color.Red;
                txtCPassword.BorderColor = Color.Red;
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            if(labelTerms.Checked == false)
            {
                labelTerms.ForeColor = Color.Red;
                labelTerms.UncheckedState.FillColor = Color.Red;
                labelTerms.UncheckedState.BorderColor = Color.Red;
                MessageBox.Show("Please accept our Terms and Conditions");

                labelTerms.ForeColor = Color.White;
                labelTerms.UncheckedState.FillColor = default;
                labelTerms.UncheckedState.BorderColor = default;
            }

            if (txtPassword.TextLength < 7 ||txtCPassword.TextLength < 7)
            {
                txtPassword.BorderColor = Color.Red;
                txtCPassword.BorderColor = Color.Red;
                MessageBox.Show("Password too short!", "Error");
                return;
            }

            if(!(Regex.IsMatch(txtUsername.Text, forbidden_user)))
            {
                txtUsername.BorderColor= Color.Red;
                MessageBox.Show("Invalid characters in Username!");
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM userinfo WHERE Username = @UserName", connection);
                cmd1.Parameters.AddWithValue("@UserName", txtUsername.Text);

                bool userExists = false;
                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows)
                    {
                        MessageBox.Show("Username not available!");
                    }

                if (!(userExists))
                {

                    if(register_bio.newAccGender == "Male") 
                    { 
                        defaultPfp = "man-pfp.jpg";
                    }

                    else if (register_bio.newAccGender == "Female")
                    {
                        defaultPfp = "woman-pfp.jpg";
                    }
                    else if(register_bio.newAccGender == "Other")
                    {
                        defaultPfp = "other-pfp.jpg";
                    }
                    
                    string iquery = "UPDATE userinfo SET Username='" + txtUsername.Text + "', Password='" + txtPassword.Text + "', ProfilePic='" + defaultPfp + "' WHERE Email='" + register_bio.newEmail + "'";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    /*MailMessage mail = new MailMessage("eclipse.gethelp@gmail.com", register_bio.newEmail, "Registration in Eclipse", "Thank you for your registration at Eclipse, at eclipse we appreciate every user that register at us and helps create Eclipse a better place for everyone! We hope you will enjoy your time with us and we wish you a good day!");
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("eclipse.gethelp@gmail.com", "zpccpmcdvwovoprs");
                        smtp.EnableSsl = true;

                        smtp.Send(mail);                    toto sa odkomenti pred odovzdavanim nech to neposiela maily vzdy jak prijebane
                    }*/

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    txtUsername.BorderColor = Color.LimeGreen;
                    txtPassword.BorderColor = Color.LimeGreen;
                    txtCPassword.BorderColor = Color.LimeGreen;
                    MessageBox.Show("Account Succesfully Created!");

                    this.Hide();
                    login frm4 = new login();
                    frm4.ShowDialog();
                }
            }
        }
    }
}
