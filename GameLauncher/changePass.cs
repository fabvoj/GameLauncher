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
    public partial class changePass : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string qryPass;
        public changePass()
        {
            InitializeComponent();
        }

        private void changePass_Load(object sender, EventArgs e)
        {
            con.Open();
            string qry = "SELECT Password FROM userinfo WHERE Email='" + login.userEmail + "';";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qryPass = (string)reader["Password"];
            }
            con.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void changePassBtn_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void changeCPassBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (changeOPassBtn.Text == qryPass && changePassBtn.Text == changeCPassBtn.Text)
            {
                con.Open();
                string qry = "UPDATE userinfo SET Password='" + changePassBtn.Text + "' WHERE Email='" + login.userEmail + "';";
                MySqlCommand cmd = new MySqlCommand(qry, con);

                MySqlDataReader reader = null;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                con.Close();

                MessageBox.Show("Password succesfully changed!");
            }

            else if(changeOPassBtn.Text != qryPass)
            {
                changeOPassBtn.BorderColor = Color.Red;
                MessageBox.Show("Wrong Old Password!");
            }

            else if (changePassBtn.TextLength < 7 || changeCPassBtn.TextLength < 7)
            {
                changePassBtn.BorderColor = Color.Red;
                changeCPassBtn.BorderColor = Color.Red;
                MessageBox.Show("Password too short!", "Error");
                return;
            }

            else
            {
                changePassBtn.BorderColor = Color.Red;
                changeCPassBtn.BorderColor = Color.Red;
                MessageBox.Show("Password's doesn't match!");
            }
        }

        private void changeOPassBtn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
