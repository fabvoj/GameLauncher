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
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");

        public static string pfp_path;
        public home()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

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

        private void pfpCircle_Click(object sender, EventArgs e)
        {
            /*MySqlCommand pfpcmd = new MySqlCommand("SELECT ProfilePic FROM loginform.userinfo WHERE Email='"+login.userEmail+"';");
            MySqlDataReader pfpread;

            connection.Open();
            pfpread = pfpcmd.ExecuteReader();
            while (pfpread.Read()) 
            {
                pfp_path = pfpread["ProfilePic"].ToString();
                pfpCircle.ImageLocation = pfp_path;
            }*/
        }
    }
}
