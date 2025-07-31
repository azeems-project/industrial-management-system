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

namespace coal_managment_application
{
    public partial class login : Form
    {
        public String usern,pass,desig;
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void signup_Click(object sender, EventArgs e)
        {
           
            signup sgup = new signup();
            this.Hide();
            sgup.Show();
         
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            usern = username_get.Text;
            pass = password_get.Text;

            if (username_get.Text != string.Empty && password_get.Text != string.Empty)
            {
               
                    using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                    {
                        String queury = "select designation from usersignup where username='"+usern+"' and password='"+pass+"'";
                        using (SqlCommand cmd = new SqlCommand(queury, con))
                        {
                            if (con.State != ConnectionState.Open)
                                con.Open();
                        SqlDataReader reader1;
                            reader1=cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            desig = reader1["designation"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Sorry..No Data Found. You must need to signup", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        }
                        con.Close();
                        if (desig == "owner")
                        {
                            ownermenu om = new ownermenu();
                            om.Show();
                            this.Hide();
                        }
                        else if (desig == "admin")
                        {
                            administratormenu am = new administratormenu();
                            am.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Try Again..no data found", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        }
                            
                        }

                    }
                
            }
            else
            {
                MessageBox.Show("please Enter Valid Data", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }

        private void username_get_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_get_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username_get.Text))
            {
                username_get.Focus();
                username_error.Text = "Please enter Username";
                username_error.Visible = true;
                
                username_get.Select();
            }
        }

        private void password_get_Enter(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(password_get.Text))
            {
                password_get.Focus();
                password_error.Text = "Please enter password";
               password_error.Visible = true;
                password_get.Select();
            }
        }
    }
}
