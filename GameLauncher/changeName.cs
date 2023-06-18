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
    public partial class changeName : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string qryFName, qryLName;
        public changeName()
        {
            InitializeComponent();
        }

        private void changeName_Load(object sender, EventArgs e)
        {
            con.Open();
            string qry = "SELECT FirstName, LastName FROM userinfo WHERE Email='" + login.userEmail + "';";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qryFName = (string)reader["FirstName"];
                qryLName = (string)reader["LastName"];
                changeFNameBtn.PlaceholderText = qryFName;
                changeLNameBtn.PlaceholderText = qryLName;
            }
            con.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void changeFNameBtn_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void changeLNameBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            bool fName = char.IsUpper(changeFNameBtn.Text, 0);
            bool lName = char.IsUpper(changeLNameBtn.Text, 0);


            if (changeLNameBtn.Text == string.Empty)
            {
                changeLNameBtn.Text = qryLName;
            }

            if(changeFNameBtn.Text == string.Empty) 
            {  
                changeFNameBtn.Text = qryFName;
            }

            if (fName == false)
            {
                changeFNameBtn.BorderColor = Color.Red;
                MessageBox.Show("Start First Name with an uppercase character!", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lName == false)
            {
                changeLNameBtn.BorderColor = Color.Red;
                MessageBox.Show("Start Last Name with an uppercase character!", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                con.Open();

                string qry = "UPDATE userinfo SET FirstName='" + changeFNameBtn.Text + "', LastName='" + changeLNameBtn.Text + "' WHERE Email='" + login.userEmail + "'";
                MySqlCommand cmd = new MySqlCommand(qry, con);

                MySqlDataReader reader = null;
                reader = cmd.ExecuteReader();
                while(reader.Read())
                {

                }
                con.Close();

                MessageBox.Show("Credentials succesfully changed!");
            }
            
        }
    }
}
