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
        string randomcode;
        public static string to, inTable, sameCode, CodeDelete;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
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
            string qry = "SELECT Email FROM userinfo WHERE Email='"+rstEmail.Text+"';";
            
            MySqlCommand command = new MySqlCommand(qry, connection);
            reader = command.ExecuteReader();

            while(reader.Read())
            {
                inTable = (string)reader["Email"]; //premenna s outputom mysql qry, ktore hladalo ci je v db zadany email
                if(inTable == rstEmail.Text)
                {
                    Random rand = new Random();                                                                                                     //
                    randomcode = (rand.Next(999999)).ToString();

                    string con2_string = "datasource=localhost;port=3306;username=root;password=; database=Eclipse";
                    string qryverify = "INSERT INTO verifycodes(`Email`,`Code`) VALUES ('"+rstEmail.Text+"','"+randomcode+"')";

                    MySqlConnection con2 = new MySqlConnection(con2_string);
                    MySqlCommand cmdverify = new MySqlCommand(qryverify, con2);
                    MySqlDataReader con2Reader = null;

                    con2.Open();
                    con2Reader = cmdverify.ExecuteReader();
                    while(con2Reader.Read())
                    {
                    }                                                                                                                               // tento usek je len na zapisanie do db :))))
                    con2.Close();

                    rstEmail.Enabled = false;
                    rstCode.Enabled = true;


                    MailMessage mail = new MailMessage("eclipse.gethelp@gmail.com", rstEmail.Text, "Password Reset Code", $"Your Reset Code is {randomcode}"); //posielanie mailu
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

        private void logoName_Click(object sender, EventArgs e)
        {

        }

        private void logoImg_Click(object sender, EventArgs e)
        {

        }

        private void rstEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void rstCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string codecheck_string = "datasource=localhost;port=3306;username=root;password=; database=Eclipse";
            string qrycodecheck = "SELECT Code FROM verifycodes WHERE Email='"+rstEmail.Text+"';";

            MySqlConnection codecheck_con = new MySqlConnection(codecheck_string);
            MySqlCommand codeverify = new MySqlCommand(qrycodecheck, codecheck_con);
            MySqlDataReader codecheckReader = null;

            codecheck_con.Open();
            codecheckReader = codeverify.ExecuteReader();
            while (codecheckReader.Read())
            {
                sameCode = (string)codecheckReader["Code"];
                if(sameCode == rstCode.Text)
                {
                    CodeDelete = sameCode;

                    string delete_verifycodes_string = "datasource=localhost;port=3306;username=root;password=; database=Eclipse";
                    string delete_verifycodes_qry = "DELETE FROM verifycodes WHERE Email='"+rstEmail.Text+"' AND Code='"+CodeDelete+"'";

                    MySqlConnection delete_verifycodes_con = new MySqlConnection(delete_verifycodes_string);
                    MySqlCommand delete_verifycodes = new MySqlCommand(delete_verifycodes_qry, delete_verifycodes_con);
                    MySqlDataReader deletecodesReader = null;

                    delete_verifycodes_con.Open();
                    deletecodesReader = delete_verifycodes.ExecuteReader();
                    while(deletecodesReader.Read())
                    {
                    }
                    delete_verifycodes_con.Close();

                    to = rstEmail.Text;
                    resetpass rp = new resetpass();
                    this.Hide();
                    rp.Show();
                }
                else
                {
                    rstVerify.BorderColor = Color.Red;
                    MessageBox.Show("Code doesn't match!");
                }

            }
            codecheck_con.Close();
        }
    }
}
