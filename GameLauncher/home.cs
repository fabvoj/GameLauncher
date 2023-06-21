using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class home : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");

        public static string pfp_path;
        public home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            get_pfpPath();
            HomeLoad();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            homeBtn.Checked = false;
            this.Hide();
            dowloadManager dowload = new dowloadManager();
            dowload.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm1 = new login();
            frm1.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            homeBtn.Checked = false;
            this.Hide();
            store obchod = new store();
            obchod.ShowDialog();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            homeBtn.Checked = false;
            this.Hide();
            library kniznica = new library();
            kniznica.ShowDialog();
        }

        private void pfpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings nastavenia = new settings();
            nastavenia.ShowDialog();
        }

        private void get_pfpPath()
        {
            connection.Open();
            string qry = "SELECT Gender FROM userinfo WHERE Email='" + login.userEmail + "';";
            MySqlCommand cmd = new MySqlCommand(qry, connection);
            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string pfpPath = (string)reader["Gender"];

                if (pfpPath == "Male")
                {
                    pfpBtn.Image = GameLauncher.Properties.Resources.man_pfp;
                }

                else if (pfpPath == "Female")
                {
                    pfpBtn.Image = GameLauncher.Properties.Resources.woman_pfp;
                }

                else if (pfpPath == "Other")
                {
                    pfpBtn.Image = GameLauncher.Properties.Resources.other_pfp;
                }
            }
            connection.Close();
        }

        private void HomeLoad()
        {
            HomePage homepage = new HomePage();
            flowLayoutPanel1.Controls.Add(homepage);
            connection.Close();
        }

        private void txtWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
