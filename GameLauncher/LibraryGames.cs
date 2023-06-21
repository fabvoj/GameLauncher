using MySql.Data.MySqlClient;
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
    public partial class LibraryGames : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=eclipse");
        public LibraryGames()
        {
            InitializeComponent();
        }
        #region Properties

        public event EventHandler ClickedGame;

        private string _title;
        private string _price;
        private Image _picture;

        [Category("Game Props")]
        public string title
        {
            get { return _title; }
            set { _title = value; gameTitle.Text = value; }
        }

        [Category("Game Props")]
        public string price
        {
            get { return _price; }
            set { _price = value; gamePrice.Text = value; }
        }

        [Category("Game Props")]
        public Image picture
        {
            get { return _picture; }
            set { _picture = value; gamePicture.Image = value; }
        }



        #endregion






        private void LibraryGames_Click(object sender, EventArgs e)
        {
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

            string game_query = "SELECT game_id FROM games WHERE game_name='" + gameTitle.Text + "';";
            MySqlCommand game_command = new MySqlCommand(game_query, connection);
            MySqlDataReader game_reader = game_command.ExecuteReader();
            string game_id = null;
            while (game_reader.Read())
            {
                game_id = game_reader["game_id"].ToString();
            }

            game_reader.Close();
            connection.Close();

            if (this.gamePrice.Text == "Install now")
            {
                connection.Open();
                this.gamePrice.Text = "Installing";
                string install_query = "UPDATE user_games SET status='Installing' WHERE user_id=" + user_id + " AND game_id=" + game_id + ";";
                MySqlCommand install_command = new MySqlCommand(install_query, connection);
                install_command.ExecuteScalar();
                connection.Close();
            }
            else
            {
                connection.Open();
                this.gamePrice.Text = "Install now";
                string install_query = "UPDATE user_games SET status='Install now' WHERE user_id=" + user_id + " AND game_id=" + game_id + ";";
                MySqlCommand install_command = new MySqlCommand(install_query, connection);
                install_command.ExecuteScalar();
                connection.Close();
            }
        }

        private void LibraryGames_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(39, 49, 56);
        }

        private void LibraryGames_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(16, 23, 28);
        }
    }
}
