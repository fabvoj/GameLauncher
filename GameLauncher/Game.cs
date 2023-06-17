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

    }
}
