using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLauncher
{
    public partial class register1 : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=; database=Eclipse");
        public static string newEmail, newAccGender, barValue;
        public static bool loadNew, deleteInfo;
        public register1()
        {
            InitializeComponent();
        }

        private void register1_Load(object sender, EventArgs e)
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
            cboGender.Items.Add("Other");
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFName_Click(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labeblLName_Click(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelGender_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnBioNext_Click(object sender, EventArgs e)
        {
            string forbidden_email1 = @"^[a-zA-Z0-9]+.[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";
            string forbidden_email2 = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]{2,}$";

            bool fName = char.IsUpper(txtFName.Text, 0);
            bool lName = char.IsUpper(txtLName.Text, 0);

            if ((!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.')) && txtEmail.TextLength < 3)
            {
                txtEmail.BorderColor = Color.Red;
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(Regex.IsMatch(txtEmail.Text, forbidden_email1) || Regex.IsMatch(txtEmail.Text, forbidden_email2)))
            {
                txtEmail.BorderColor = Color.Red;
                MessageBox.Show("Enter valid characters!", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrEmpty(cboGender.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                txtFName.BorderColor = Color.Red;
                txtLName.BorderColor = Color.Red;
                cboGender.BorderColor = Color.Red;
                txtEmail.BorderColor = Color.Red;
                MessageBox.Show("Please fill out all information!", "Error");
                return;
            }

            if (fName == false)
            {
                txtFName.BorderColor = Color.Red;
                MessageBox.Show("Start First Name with an uppercase character!", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lName == false)
            {
                txtLName.BorderColor = Color.Red;
                MessageBox.Show("Start Last Name with an uppercase character!", "Invalid Character", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM userinfo WHERE Email = '" + txtEmail.Text + "'", connection);

                bool mailExists = false;

                using (var dr2 = cmd2.ExecuteReader())
                    if (mailExists = dr2.HasRows) MessageBox.Show("Email not available!");


                if (!(mailExists))
                {
                    string iquery = "INSERT INTO userinfo(`user_id`,`FirstName`,`LastName`,`Gender`,`Email`) VALUES (NULL, '" + txtFName.Text + "', '" + txtLName.Text + "', '" + cboGender.Text + "', '" + txtEmail.Text + "')";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.CommandTimeout = 60;

                    try
                    {
                        MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    txtFName.BorderColor = Color.LimeGreen;
                    txtLName.BorderColor = Color.LimeGreen;
                    cboGender.BorderColor = Color.LimeGreen;
                    txtEmail.BorderColor = Color.LimeGreen;

                    loadNew = true;
                    barValue = "50";
                    newEmail = txtEmail.Text;
                    newAccGender = cboGender.Text;
                    deleteInfo = true;

                }
                this.Hide();
                connection.Close();
            }
        }
    }
}
