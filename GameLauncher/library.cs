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
    public partial class library : Form
    {
        public library()
        {
            InitializeComponent();
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

        }
    }
}
