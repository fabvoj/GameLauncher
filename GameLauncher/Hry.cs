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
    public partial class Hry : UserControl
    {
        public Hry()
        {
            InitializeComponent();
        }



        #region Properties

        private string _name;
        private string _price;
        private Image _picture;


        [Category("Game Properties")]
        public string name
        {
            get { return _name; }
            set { _name = value; gameName.Text = value; }
        }

        [Category("Game Properties")]
        public string price
        {
            get { return _price; }
            set { _price = value; gamePrice.Text = value; }
        }

        [Category("Game Properties")]
        public Image picture
        {
            get { return _picture; }
            set { _picture = value; gamePicture.Image = value; }
        }


        #endregion


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
