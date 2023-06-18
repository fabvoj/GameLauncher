﻿using MySql.Data.MySqlClient;
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
            get_pfpPath();
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


        public void populateItems()
        {
            flowLayoutPanel3.Visible = false;
            flowLayoutPanel1.Controls.Clear();
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

                Image picture = Image.FromFile(image);

                Games game = new Games();
                game.title = title;
                game.price = price;
                game.picture = picture;

                game.ClickedGame += GameClicked;

                flowLayoutPanel1.Controls.Add(game);
            }
            Console.WriteLine("hry su nacitane");
            reader.Close();
            connection.Close();
        }

        private void GameClicked(object sender, EventArgs e)
        {
            Console.WriteLine("robim na tom");
            Games gameclick = (Games)sender;
            string zakliknutahra = gameclick.title;

            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=eclipse");
            connection.Open();
            
            string query = "SELECT * FROM games WHERE game_name = @title";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", zakliknutahra);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string pathCover = reader["game_cover"].ToString();
                string cover = Path.Combine("../../", "assets", "gamePicture", pathCover);
                Image imagecover = Image.FromFile(cover);
                string logoincover = reader["game_logo"].ToString();
                string pathlogo = Path.Combine("../../", "assets", "gamePicture", logoincover);
                Image coverlogo = Image.FromFile(pathlogo);
                string description = reader["game_description"].ToString();
                string genre = reader["game_genres"].ToString();
                string features = reader["game_features"].ToString();
                string developer = reader["game_developer"].ToString();
                string publisher = reader["game_publisher"].ToString();
                string release = reader["game_release"].ToString();
                string castPrice = reader["game_price"].ToString();
                string price = "Buy now for " + castPrice;

                Game gameska = new Game();
                gameska.cover = imagecover;
                gameska.logo = coverlogo;
                gameska.logoinpicture = coverlogo;
                gameska.description = description;
                gameska.developer = developer;
                gameska.publisher = publisher;
                gameska.release = release;  
                gameska.genre = genre;
                gameska.features = features;
                gameska.price = price;

                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.Add(gameska);
                flowLayoutPanel3.Visible = true;

            }
            Console.WriteLine("hotovo");
            reader.Close();
            connection.Close();
        }

        private void pfpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings nastavenia = new settings();
            nastavenia.ShowDialog();
        }

        public void get_pfpPath()
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");
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
        }
    }
}

