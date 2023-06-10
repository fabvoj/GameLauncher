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
    public partial class login : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        MySqlCommand command;
        MySqlDataReader mdr;

        public static string userEmail;

        public login()
        {
            InitializeComponent();
        }

 
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                txtEmail.BorderColor = Color.Red;
                txtPassword.BorderColor = Color.Red;
                MessageBox.Show("Please input both Email and Password", "Error");
            }

            else
            {
                connection.Open();
                string selectQuery = "SELECT * FROM loginform.userinfo WHERE Email = '" + txtEmail.Text + "' AND Password = '" + txtPassword.Text + "';";
                command = new MySqlCommand(selectQuery, connection);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                    string Query = "update loginform.userinfo set LastLogin='" + DateTimePicker1.Value + "' where Email='" + this.txtEmail.Text + "';";
                    MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                    MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                    MySqlDataReader MyReader2;
                    MyConn2.Open();
                    MyReader2 = MyCommand2.ExecuteReader();
                    while (MyReader2.Read())
                    {
                    }
                    MyConn2.Close();

                    txtEmail.BorderColor= Color.LimeGreen;
                    txtPassword.BorderColor = Color.LimeGreen;
                    MessageBox.Show("Login Successful!");


                    userEmail = txtEmail.Text;
                    this.Hide();
                    home frm2 = new home();
                    frm2.ShowDialog();

                }
                else
                {
                    txtEmail.BorderColor= Color.Red;
                    txtPassword.BorderColor= Color.Red;
                    MessageBox.Show("Incorrect Login Information! Try again.");
                }

                connection.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sendcode frmcode = new sendcode();
            frmcode.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            register frm3 = new register();
            frm3.ShowDialog();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if(shwPass.Checked == true)
            {
                txtPassword.PasswordChar = default;
            }
            else if(shwPass.Checked == false)
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void logoName_Click(object sender, EventArgs e)
        {

        }

        private void logoImg_Click(object sender, EventArgs e)
        {

        }
    }
}
