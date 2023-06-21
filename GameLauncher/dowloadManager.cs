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
    public partial class dowloadManager : Form
    {
        public dowloadManager()
        {
            InitializeComponent();
            populateItems();
        }
        public static string pfp_path;

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeBtn.Checked = false;
            this.Hide();
            home domov = new home();
            domov.ShowDialog();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            storeBtn.Checked = false;
            this.Hide();
            store obchod = new store();
            obchod.ShowDialog();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {
            libraryBtn.Checked = false;
            this.Hide();
            library library = new library();
            library.ShowDialog();
        }

        private void pfpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings nastavenia = new settings();
            nastavenia.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings nastavenia = new settings();
            nastavenia.ShowDialog();
        }

        public void populateItems()
        {
            MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");
            connection.Open();

            string user_query = "SELECT user_id FROM userinfo WHERE Email=@Email;";
            MySqlCommand user_command = new MySqlCommand(user_query, connection);
            user_command.Parameters.AddWithValue("@Email", login.userEmail);
            MySqlDataReader user_reader = user_command.ExecuteReader();
            string user_id = null;
            while (user_reader.Read())
            {
                user_id = user_reader["user_id"].ToString();
            }
            user_reader.Close();

            string query = "SELECT games.game_name, games.game_picture FROM games INNER JOIN user_games ON games.game_id=user_games.game_id WHERE user_games.user_id =" + user_id + " AND status='Installing';";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["game_name"].ToString();
                string picturePath = reader["game_picture"].ToString();
                string image = Path.Combine("../../", "assets", "gamePicture", picturePath);

                Image picture = Image.FromFile(image);

                dowloadManagerGame game = new dowloadManagerGame();
                game.title = title;
                game.picture = picture;

                flowLayoutPanel2.Controls.Add(game);
            }
            reader.Close();
            connection.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dowloadManagerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
