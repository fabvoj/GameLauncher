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
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        #region Properties

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

        private void gamePicture_Click(object sender, EventArgs e)
        {

        }

        private void gamePrice_Click(object sender, EventArgs e)
        {

        }
    }
}
