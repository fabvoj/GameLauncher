using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class register2 : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string defaultPfp;
        public static int closeForm;
        public register2()
        {
            InitializeComponent();
        }

        private void register2_Load(object sender, EventArgs e)
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

            if (labelTerms.Checked == false)
            {
                labelTerms.ForeColor = Color.Red;
                labelTerms.UncheckedState.FillColor = Color.Red;
                labelTerms.UncheckedState.BorderColor = Color.Red;
                MessageBox.Show("Please accept our Terms and Conditions");

                labelTerms.ForeColor = Color.White;
                return;
            }

            if (txtPassword.TextLength < 7 || txtCPassword.TextLength < 7)
            {
                txtPassword.BorderColor = Color.Red;
                txtCPassword.BorderColor = Color.Red;
                MessageBox.Show("Password too short!", "Error");
                return;
            }

            if (!(Regex.IsMatch(txtUsername.Text, forbidden_user)))
            {
                txtUsername.BorderColor = Color.Red;
                MessageBox.Show("Invalid characters in Username!");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM userinfo WHERE Username = '" + txtUsername.Text + "'", connection);

                bool userExists = false;
                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows)
                    {
                        MessageBox.Show("Username not available!");
                    }

                if (!(userExists))
                {

                    if (register1.newAccGender == "Male")
                    {
                        defaultPfp = "man-pfp.jpg";
                    }

                    else if (register1.newAccGender == "Female")
                    {
                        defaultPfp = "woman-pfp.jpg";
                    }
                    else if (register1.newAccGender == "Other")
                    {
                        defaultPfp = "other-pfp.jpg";
                    }

                    string iquery = "UPDATE userinfo SET Username='" + txtUsername.Text + "', Password='" + txtPassword.Text + "' WHERE Email='" + register1.newEmail + "'";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    /*MailMessage mail = new MailMessage("eclipse.gethelp@gmail.com", register1.newEmail, "Registration in Eclipse", "Thank you for your registration at Eclipse, at eclipse we appreciate every user that register at us and helps create Eclipse a better place for everyone! We hope you will enjoy your time with us and we wish you a good day!");
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
                    closeForm = 1;

                    this.Hide();
                }
            }
        }
    }
}
