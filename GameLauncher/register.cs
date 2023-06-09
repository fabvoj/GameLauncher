using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameLauncher
{
    public partial class register : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public register()
        {
            InitializeComponent();
        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }


        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelFName_Click(object sender, EventArgs e)
        {

        }

        private void labeblLName_Click(object sender, EventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {

        }

        private void labelBirthday_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void labelCPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                txtEmail.BorderColor = Color.Red;
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text != txtCPassword.Text)
            {
                txtPassword.BorderColor = Color.Red;
                txtCPassword.BorderColor = Color.Red;
                MessageBox.Show("Password doesn't match!", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(cboGender.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtCPassword.Text))
            {
                txtFName.BorderColor = Color.Red;
                txtLName.BorderColor = Color.Red;
                cboGender.BorderColor = Color.Red;
                txtEmail.BorderColor = Color.Red;
                txtUsername.BorderColor = Color.Red;
                txtPassword.BorderColor = Color.Red;
                txtCPassword.BorderColor = Color.Red;
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM loginform.userinfo WHERE Username = @UserName", connection),
                cmd2 = new MySqlCommand("SELECT * FROM loginform.userinfo WHERE Email = @UserEmail", connection);


                cmd1.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd2.Parameters.AddWithValue("@UserEmail", txtEmail.Text);

                bool userExists = false, mailExists = false;

                using (var dr1 = cmd1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username not available!");

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(userExists || mailExists))
                {
                    string defaultPfp = "GameLauncher/assets/pfp/default.jpg";
                    string iquery = "INSERT INTO loginform.userinfo(`ID`,`FirstName`,`LastName`,`Gender`,`Birthday`,`Email`,`Username`, `Password`, `ProfilePic`) VALUES (NULL, '" + txtFName.Text + "', '" + txtLName.Text + "', '" + cboGender.Text + "', '" + DateTimePicker1.Value.Date + "', '" + txtEmail.Text + "', '" + txtUsername.Text + "', '" + txtPassword.Text + "', '"+defaultPfp+"')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        // Show any error message.
                        MessageBox.Show(ex.Message);
                    }

                    txtFName.BorderColor = Color.LimeGreen;
                    txtLName.BorderColor = Color.LimeGreen;
                    cboGender.BorderColor = Color.LimeGreen;
                    txtEmail.BorderColor = Color.LimeGreen;
                    txtUsername.BorderColor = Color.LimeGreen;
                    txtPassword.BorderColor = Color.LimeGreen;
                    txtCPassword.BorderColor = Color.LimeGreen;
                    MessageBox.Show("Account Successfully Created!");

                }

                connection.Close();
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm4 = new login();
            frm4.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Mental Disorder");
        }
    }
}
