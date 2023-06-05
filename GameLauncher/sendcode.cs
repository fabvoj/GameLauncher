using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace GameLauncher
{
    public partial class sendcode : Form
    {
        string randomcode, sentcode;
        public static string to, inTable;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
        public sendcode()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login frm4 = new login();
            frm4.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlDataReader reader = null;
            string qry = "SELECT Email FROM loginform.userinfo WHERE Email='"+rstEmail.Text+"';";
            MySqlCommand command = new MySqlCommand(qry, connection);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                inTable = (string)reader["Email"]; //premenna s outputom mysql qry, ktore hladalo ci je v db zadany email
                if(inTable == rstEmail.Text)
                {
                    rstEmail.Enabled = false;

                    Random rand = new Random();
                    randomcode = (rand.Next(999999)).ToString();

                    MailMessage mail = new MailMessage("eclipse.gethelp@gmail.com", rstEmail.Text, "Password Reset Code", $"Your Reset Code is {randomcode}");
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential("eclipse.gethelp@gmail.com", "zpccpmcdvwovoprs");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }
                
            }
            if(inTable != rstEmail.Text)
            {
                rstEmail.BorderColor = Color.Red;
                MessageBox.Show("Written email isn't registered under any account or doesn't exist!", "Error");
            }

            connection.Close();
        }

        private void rstEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rstCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            sentcode = rstVerify.Text;
            int comparison = String.Compare(randomcode, sentcode, comparisonType: StringComparison.OrdinalIgnoreCase);

            if (comparison < 0) 
            {
                to = rstEmail.Text;
                resetpass rp = new resetpass();
                this.Hide();
                rp.Show();
            }
            else
            {
                rstVerify.BorderColor = Color.Red;
                MessageBox.Show($"{comparison}");
            }
        }
    }
}
