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
    public partial class dowloadManagerGame : UserControl
    {
        public dowloadManagerGame()
        {
            InitializeComponent();
        }

        private string _title;
        private Image _picture;

        [Category("Game Props")]
        public string title
        {
            get { return _title; }
            set { _title = value; gameName.Text = value; }
        }

        [Category("Game Props")]
        public Image picture
        {
            get { return _picture; }
            set { _picture = value; gamePicture.Image = value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
