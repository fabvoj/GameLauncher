using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using MySql.Data.MySqlClient;

namespace GameLauncher
{
    public partial class resetpass : Form
    {
        /*static readonly string server = "127.0.0.1";
        static readonly string port = "3306";
        static readonly string user = "root";
        static readonly string pass = "";
        public static string connection_str = "server='" + server + "'; user='" + user +"'; password='" + pass +"'";
        */
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        string email = sendcode.to;
        public resetpass()
        {
            InitializeComponent();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm4 = new login();
            frm4.ShowDialog();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            if (changeNewPass.Text == changeConfirm.Text)
            {
                string password = changeConfirm.Text;
                connection.Open();
                string q = "UPDATE loginform.userinfo SET Password = '" + password + "' WHERE Email='" + email + "'";
                MySqlCommand cmd = new MySqlCommand(q, connection
                    );


                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Password Succesfully Changed");
            }
            else if (changeNewPass.Text != changeConfirm.Text)
            {
                changeNewPass.BorderColor = Color.Red; 
                changeConfirm.BorderColor = Color.Red; 
                MessageBox.Show("Sorry, New Password and Confirmed Password doesn't match.");
            }
        }

        private void changeNewPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeConfirm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
