﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GameLauncher
{
    public partial class changeEmail : UserControl
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string qryEmail;
        public changeEmail()
        {
            InitializeComponent();
        }

        private void changeEmail_Load(object sender, EventArgs e)
        {
            con.Open();
            string qry = "SELECT Email FROM userinfo WHERE Email='" + login.userEmail + "';";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                qryEmail = (string)reader["Email"];
                changeEmailBtn.PlaceholderText = qryEmail;
            }
            con.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void changeEmailBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            con.Open();

            string qry = "UPDATE userinfo SET Email='" + changeEmailBtn.Text + "' WHERE Email='" + login.userEmail + "'";
            MySqlCommand cmd = new MySqlCommand(qry, con);

            MySqlDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {

            }
            con.Close();

            MessageBox.Show("Email succesfully changed!");
        }
    }
}