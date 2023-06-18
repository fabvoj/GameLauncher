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
using MySql.Data.MySqlClient;

namespace GameLauncher
{
    public partial class changeUsername : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string qryUsername;
        public changeUsername()
        {
            InitializeComponent();
        }

        private void changeUsername_Load(object sender, EventArgs e)
        {
            con.Open();
            string qry = "SELECT Username FROM userinfo WHERE Email='" + login.userEmail + "';";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qryUsername = (string)reader["Username"];
                changeUsernameBtn.Text = qryUsername;
            }
            con.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void changeUsernameBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            string forbidden_user = @"^[a-zA-Z0-9_]+$";

            if (!(Regex.IsMatch(changeUsernameBtn.Text, forbidden_user)))
            {
                changeUsernameBtn.BorderColor = Color.Red;
                MessageBox.Show("Invalid characters in Username!");
            }

            else
            {
                con.Open();
                string qry = "UPDATE userinfo SET Username='" + changeUsernameBtn.Text + "' WHERE Email='" + login.userEmail + "';";
                MySqlCommand cmd = new MySqlCommand(qry, con);

                MySqlDataReader reader = null;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                con.Close();

                MessageBox.Show("Username succesfully changed!");
            }
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
