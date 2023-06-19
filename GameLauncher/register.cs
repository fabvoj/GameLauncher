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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoImg_Click(object sender, EventArgs e)
        {

        }

        private void logoName_Click(object sender, EventArgs e)
        {

        }

        private void registerProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void register11_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            register11.Visible = false;
            register21.Visible = false;

            if(register1.deleteInfo == true)
            {
                MySqlConnection connection2 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
                connection2.Open();
                string deleteUserqry = "DELETE FROM userinfo WHERE Email='" + register1.newEmail + "';";
                MySqlCommand removedUser = new MySqlCommand(deleteUserqry, connection2);
                removedUser.ExecuteScalar();

                this.Hide();
                login frm4 = new login();
                frm4.ShowDialog();

                connection2.Close();
            }
            else if(register1.deleteInfo == false)
            {
                this.Hide();
                login frm1 = new login();
                frm1.ShowDialog();
            }
            

        }
    }
}
