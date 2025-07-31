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
    public partial class backupform : Form
    {
        SqlConnection con = new SqlConnection(ProjectConnection.connectionstring);
        public backupform()
        {
            InitializeComponent();
        }

        private void browsebtnbup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                backupbtn.Enabled = true;
            }
        }

        private void backupbtn_Click(object sender, EventArgs e)
        {
            string database = @"D:\New folder\coal managment application\iqbalcoalmng.mdf"; // Replace with your actual database name
            string backupPath = textBox1.Text + "\\backup_file.bak";  // Replace with the path and filename for your backup file

            string cmd = $"BACKUP DATABASE [{database}] TO DISK='{backupPath}'";
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\New folder\coal managment application\iqbalcoalmng.mdf;Integrated Security=True;Connect Timeout=30");

            try
            {
                con.Open();
                SqlCommand command = new SqlCommand(cmd, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Backup created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during backup: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

        }

        private void browsebthnres_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "DataBase Restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = dlg.FileName;
                restorebthn.Enabled = true;
            }
        }

        private void restorebthn_Click(object sender, EventArgs e)
        {
            string database = @"D:\New folder\coal managment application\iqbalcoalmng.mdf";
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
            con.Open();
            try
            {
                // Check for null or empty database name
                if (string.IsNullOrEmpty(database))
                {
                    throw new Exception("Database name is missing or empty.");
                }

                // Check for valid backup file path
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    throw new Exception("Backup file path is missing or empty.");
                }

                // Execute SQL statements
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand cmd1 = new SqlCommand(str1, con);
                cmd1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox2.Text + "' WITH REPLACE;";
                SqlCommand cmd2 = new SqlCommand(str2, con);
                cmd2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand cmd3 = new SqlCommand(str3, con);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("DATABASE restore succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
