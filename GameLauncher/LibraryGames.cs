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
            this.gamePrice.Text = "Installing";
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
