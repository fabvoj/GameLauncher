using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();
            gameLibrarybtn.Visible = false;
        }

        private Image _cover;
        private Image _logoinpicture;
        private string _description;
        private Image _logo;
        private string _genre;
        private string _features;
        private string _developer;
        private string _publisher;
        private string _release;
        private string _price;
        private string _name;

        public Image cover
        {
            get { return _cover; }
            set { _cover = value; gameCover.Image = value; }
        }

        public Image logoinpicture
        {
            get { return _logoinpicture; }
            set { _logoinpicture = value; GameLogoInPicture.Image = value; }
        }

        public string description
        {
            get { return _description; }
            set { _description = value; gameDescription.Text = value; }
        }
        public Image logo
        {
            get { return _logo; }
            set { _logo = value; gameLogo.Image = value; }
        }

        public string genre
        {
            get { return _genre; }
            set { _genre = value; gameGenres.Text = value; }
        }

        public string features
        {
            get { return _features; }
            set { _features = value; gameFeatures.Text = value; }
        }

        public string developer
        {
            get { return _developer; }
            set { _developer = value; gameDeveloper.Text = value; }
        }

        public string publisher
        {
            get { return _publisher; }
            set { _publisher = value; gamePublisher.Text = value; }
        }
        public string release
        {
            get { return _release; }
            set { _release = value; gameRelease.Text = value; }
        }

        public string price
        {
            get { return _price; }
            set { _price = value; gamePrice.Text = value; }
        }

        public string name
        {
            get { return _name; }
            set { _name = value; gameName.Text = value; }
        }



        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void gamePrice_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");
            connection.Open();

            string user_query = "SELECT user_id FROM userinfo WHERE Email='" + login.userEmail + "';";
            MySqlCommand user_command = new MySqlCommand(user_query, connection);
            MySqlDataReader user_reader = user_command.ExecuteReader();
            string user_id = null;
            while(user_reader.Read())
            {
                user_id = user_reader["user_id"].ToString();
            }
            user_reader.Close();
            
            string game_query = "SELECT game_id FROM games WHERE game_name='" + this.name + "';";
            MySqlCommand game_command = new MySqlCommand(game_query, connection);
            MySqlDataReader game_reader = game_command.ExecuteReader();
            string game_id = null;
            while (game_reader.Read())
            {
                 game_id = game_reader["game_id"].ToString();
            }
            game_reader.Close();

            string buy_query = "INSERT INTO user_games (user_id, game_id) VALUES('" + user_id + "', '" + game_id + "')";
            MySqlCommand buy_command = new MySqlCommand(buy_query, connection);
            buy_command.ExecuteScalar();
            gamePrice.Visible = false;
            gameLibrarybtn.Visible = true;
        }

        private void gameLibrarybtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            library kniznica = new library();
            kniznica.ShowDialog();
        }
    }
}
