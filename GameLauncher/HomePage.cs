using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class HomePage : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");
        public HomePage()
        {
            InitializeComponent();
            gameLoad();
        }

        private void gameLoad() 
        {
            connection.Open();

            string user_query = "SELECT Username FROM userinfo WHERE Email=@Email;";
            MySqlCommand user_command = new MySqlCommand(user_query, connection);
            user_command.Parameters.AddWithValue("@Email", login.userEmail);
            MySqlDataReader user_reader = user_command.ExecuteReader();
            string user_name = null;
            while (user_reader.Read())
            {
                user_name = user_reader["Username"].ToString();
            }
            user_reader.Close();

            txtWelcome.Text = "Welcome, " + user_name + "! It's nice to see you again.";

            string popular_query = "SELECT COUNT(game_id) AS total_count FROM games;";
            MySqlCommand popular_command = new MySqlCommand(popular_query, connection);
            int popular_game_id = Convert.ToInt32(popular_command.ExecuteScalar());
            var random = new Random();
            int popular_game = random.Next(1, popular_game_id + 1);

            string game_query = "SELECT * FROM games WHERE game_id=@gameid;";
            MySqlCommand game_command = new MySqlCommand(game_query, connection);
            game_command.Parameters.AddWithValue("@gameid", popular_game);
            MySqlDataReader game_reader = game_command.ExecuteReader();
            while (game_reader.Read())
            {
                string pathCover = game_reader["game_cover"].ToString();
                string cover = Path.Combine("../../", "assets", "gamePicture", pathCover);
                Image imagecover = Image.FromFile(cover);
                string logoincover = game_reader["game_logo"].ToString();
                string pathlogo = Path.Combine("../../", "assets", "gamePicture", logoincover);
                Image coverlogo = Image.FromFile(pathlogo);
                string game_name = game_reader["game_name"].ToString();

                gameCover.Image = imagecover;
                gameLogo.Image = coverlogo;
                game_title.Text = game_name;
                
            }
            game_title.Visible = false;
            game_reader.Close();


            List<string> gamePicture = new List<string>();
            List<string> gameName = new List<string>();
            List<string> gamePrice = new List<string>();

            string cheapest_query = "SELECT * FROM games ORDER BY game_price ASC LIMIT 4;";
            MySqlCommand cheapest_command = new MySqlCommand(cheapest_query, connection);
            MySqlDataReader cheapest_reader = cheapest_command.ExecuteReader();
            while (cheapest_reader.Read())
            {
                string pathPicture = cheapest_reader["game_picture"].ToString();
                string picture = Path.Combine("../../", "assets", "gamePicture", pathPicture);
                string title = cheapest_reader["game_name"].ToString();
                string price = cheapest_reader["game_price"].ToString();

                gamePicture.Add(picture);
                gameName.Add(title);
                gamePrice.Add(price);
            }
            cheapest_reader.Close();


            Image game1 = Image.FromFile(gamePicture[0]);
            Image game2 = Image.FromFile(gamePicture[1]);
            Image game3 = Image.FromFile(gamePicture[2]);
            Image game4 = Image.FromFile(gamePicture[3]);
            guna2PictureBox1.Image = game1;
            guna2PictureBox2.Image = game2;
            guna2PictureBox3.Image = game3;
            guna2PictureBox4.Image = game4;
            label3.Text = gameName[0];
            label4.Text = gameName[1];
            label5.Text = gameName[2];
            label6.Text = gameName[3];
            label33.Text = gamePrice[0];
            label44.Text = gamePrice[1];
            label55.Text = gamePrice[2];
            label66.Text = gamePrice[3];


            connection.Close();


        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomePage_MouseLeave(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.FromArgb(16, 23, 28);
        }

        private void guna2Panel1_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel1.BackColor = Color.Transparent;
        }

        private void guna2Panel4_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel4.BackColor = Color.FromArgb(16, 23, 28);
        }

        private void guna2Panel4_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel4.BackColor = Color.Transparent;
        }

        private void guna2PictureBox2_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel2.BackColor = Color.FromArgb(16, 23, 28);
        }

        private void guna2PictureBox2_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel2.BackColor = Color.Transparent;
        }

        private void guna2PictureBox3_MouseEnter(object sender, EventArgs e)
        {
            guna2Panel3.BackColor = Color.FromArgb(16, 23, 28);
        }

        private void guna2PictureBox3_MouseLeave(object sender, EventArgs e)
        {
            guna2Panel3.BackColor = Color.Transparent;
        }

        private void gameBuy_Click(object sender, EventArgs e)
        {
            home Form = this.FindForm() as home;
            Form.Hide();
            store storeForm = new store();
            storeForm.Show();

            Games gameClicked = new Games();
            gameClicked.title = game_title.Text;
            storeForm.GameClicked(gameClicked, EventArgs.Empty);
        }

        private void guna2Panel1_Click(object sender, EventArgs e)
        {
            home Form = this.FindForm() as home;
            Form.Hide();
            store storeForm = new store();
            storeForm.Show();

            Games gameClicked = new Games();
            gameClicked.title = label3.Text;
            storeForm.GameClicked(gameClicked, EventArgs.Empty);
        }

        private void guna2Panel2_Click(object sender, EventArgs e)
        {
            home Form = this.FindForm() as home;
            Form.Hide();
            store storeForm = new store();
            storeForm.Show();

            Games gameClicked = new Games();
            gameClicked.title = label4.Text;
            storeForm.GameClicked(gameClicked, EventArgs.Empty);
        }

        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            home Form = this.FindForm() as home;
            Form.Hide();
            store storeForm = new store();
            storeForm.Show();

            Games gameClicked = new Games();
            gameClicked.title = label5.Text;
            storeForm.GameClicked(gameClicked, EventArgs.Empty);
        }

        private void guna2Panel4_Click(object sender, EventArgs e)
        {
            home Form = this.FindForm() as home;
            Form.Hide();
            store storeForm = new store();
            storeForm.Show();

            Games gameClicked = new Games();
            gameClicked.title = label6.Text;
            storeForm.GameClicked(gameClicked, EventArgs.Empty);
        }
    }
}
