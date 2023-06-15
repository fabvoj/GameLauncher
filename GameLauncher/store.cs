using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class store : Form
    {
        public store()
        {
            InitializeComponent();
            populateItems();
        }

        private void store_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            storeBtn.Checked = false;
            this.Hide();
            home domov = new home();
            domov.ShowDialog();

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            storeBtn.Checked = false;
            this.Hide();
            library kniznica = new library();
            kniznica.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }


        private void populateItems()
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");
            connection.Open();

            string query = "SELECT * FROM games";
            MySqlCommand command = new MySqlCommand(query, connection);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["game_name"].ToString();
                string price = reader["game_price"].ToString();
                string picturePath = reader["game_picture"].ToString();
                string image = Path.Combine("../../", "assets", "gamePicture", picturePath);
                Console.WriteLine(picturePath);

                Image picture = Image.FromFile(image);

                Games game = new Games();
                game.title = title;
                game.price = price;
                game.picture = picture;

                flowLayoutPanel1.Controls.Add(game);
            }

            reader.Close();
            connection.Close();
        }
    }



}

