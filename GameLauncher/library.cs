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
    public partial class library : Form
    {
        public library()
        {
            InitializeComponent();
            get_pfpPath();
            LibraryItems();
        }

        private void library_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            libraryBtn.Checked = false;
            this.Hide();
            home domov = new home();
            domov.ShowDialog();
        }

        private void storeBtn_Click(object sender, EventArgs e)
        {
            libraryBtn.Checked = false;
            this.Hide();
            store obchod = new store();
            obchod.ShowDialog();
        }

        private void libraryBtn_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm1 = new login();
            frm1.ShowDialog();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings nastavenia = new settings();
            nastavenia.ShowDialog();
        }

        private void pfpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            settings nastavenia = new settings();
            nastavenia.ShowDialog();
        }

        public void LibraryItems() 
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

            string query = "SELECT games.game_name, games.game_picture FROM games INNER JOIN user_games ON games.game_id=user_games.game_id WHERE user_games.user_id =" + user_id + ";";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string title = reader["game_name"].ToString();
                string price = "Install Now";
                string picturePath = reader["game_picture"].ToString();
                string image = Path.Combine("../../", "assets", "gamePicture", picturePath);

                Image picture = Image.FromFile(image);

                Games game = new Games();
                game.title = title;
                game.price = price;
                game.picture = picture;

                flowLayoutPanel2.Controls.Add(game);
            }
            reader.Close();
            connection.Close();
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
