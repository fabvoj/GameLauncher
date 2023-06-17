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
    public partial class BackBtn : UserControl
    {
        public BackBtn()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(16, 23, 28);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void guna2CirclePictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
