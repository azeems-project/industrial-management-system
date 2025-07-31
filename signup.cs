using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace coal_managment_application
{
    public partial class signup : Form
    {

        
        String usrname, password, email, designation, adress, phnnum;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ifhaveaccount_Click(object sender, EventArgs e)
        {
            login lg = new login();
            this.Hide();
            lg.Show();
        }

        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupbutton_Click(object sender, EventArgs e)
        {

            usrname = getusername.Text;
            password = getpassword.Text;
            email = getemail.Text;
            if (ownerradiobutton.Checked)
            {
                designation = "owner";
            }
            else
            {
                designation = "admin";
            }
            adress = address.Text;
            phnnum = phonenumber.Text;

            if (getusername.Text!=string.Empty && getpassword.Text != string.Empty && getemail.Text != string.Empty && phonenumber.Text != string.Empty && address.Text != string.Empty)
            {
                if (password.Length < 8)
                {
                    MessageBox.Show("password must have atleat 8 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!IsValidPhoneNumber(phnnum))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ownerradiobutton.Checked==true || adminradiobutton.Checked == true)
                {
                    using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                    {
                        String queury = "INSERT INTO usersignup (username, password, email, designation, address, phonenum) VALUES ('" + usrname + "','" + password + "', '" + email + "','" + designation + "','" + adress + "', '" + phnnum + "')";
                        using(SqlCommand cmd=new SqlCommand(queury,con))
                        {
                            if (con.State != ConnectionState.Open)
                                con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            login lg = new login();
                            lg.Show();
                            this.Hide();
                        }

                    }
                }
                

            }
            else
            {
                MessageBox.Show("Data Insertion Failed", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }







        }
        private bool IsValidEmail(string email)
        {
            // Use regular expression to validate email format
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Use regular expression to validate phone number format
            string phonePattern = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
            return Regex.IsMatch(phoneNumber, phonePattern);
        }
    }
}
