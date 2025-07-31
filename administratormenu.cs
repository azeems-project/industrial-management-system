using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coal_managment_application
{
    public partial class administratormenu : Form
    {
        bool slidebarexpand;
        bool reportpanelcollape;
        public Timer timer = new Timer();
        String tstock, quantity;
        int tstk, qnt;
        public administratormenu()
        {
            InitializeComponent();
        }

        private void administratormenu_Load(object sender, EventArgs e)
        {
            string data = File.ReadAllText("assign_duty");

            // Check if the file contains any text
            if (!string.IsNullOrEmpty(data))
            {
                // Show the button
                alert.Visible = true;
                alert.BackColor = Color.FromArgb(0, 64, 64);

                // Start the blinking timer
                
                timer.Interval = 500; // Set the blinking interval to 500 milliseconds
                timer.Tick += (eventsender, ev) =>
                {
                    alert.BackColor = alert.BackColor == Color.Red ? Color.Green : Color.Red;
                };
                
                    timer.Start();
                
            }


            // for checking quantity and stock
            using (SqlConnection connection = new SqlConnection(ProjectConnection.connectionstring))
            {
                connection.Open();
                string query = "SELECT t1.total_stock, t2.TotalSales " +
                               "FROM stocktable t1 " +
                               "INNER JOIN (" +
                               "  SELECT SUM(CAST(quantity AS float)) AS TotalSales " +
                               "  FROM salesreporttable " +
                               ") t2 ON 1=1 ";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     tstock = reader.GetString(0);
                    quantity = reader.GetDouble(1).ToString();

                    if (int.TryParse(tstock, out tstk) && int.TryParse(quantity, out qnt))
                    {
                        // Conversion successful, do something with myInt
                        Console.WriteLine(tstk);
                        Console.WriteLine(qnt);

                        if (qnt >= tstk)
                        {
                            Notification.BackColor = Color.FromArgb(0, 64, 64);

                            // Start the blinking timer

                            timer.Interval = 500; // Set the blinking interval to 500 milliseconds
                            timer.Tick += (eventsender, ev) =>
                            {
                                Notification.BackColor = Notification.BackColor == Color.Red ? Color.Green : Color.Red;
                            };

                            timer.Start();
                        }
                    }
                    
                    else
                    {
                        // Conversion failed, handle the error
                        Console.WriteLine("Invalid input!");
                    }
                }
                reader.Close();
            }
        }

        private void sliderbartimer_Tick(object sender, EventArgs e)
        {
            if (slidebarexpand)
            {
                slidebaradmin.Width -= 10;
                if (slidebaradmin.Width == slidebaradmin.MinimumSize.Width)
                {
                    slidebarexpand = false;
                    sliderbartimeradmin.Stop();
                }
            }
            else
            {
                slidebaradmin.Width += 10;
                if (slidebaradmin.Width == slidebaradmin.MaximumSize.Width)
                {
                    slidebarexpand = true;
                    sliderbartimeradmin.Stop();
                }
            }
        }

        private void reportbutton_Click(object sender, EventArgs e)
        {
            ReportTimeradmin.Start();
        }

        private void menubuttononbar_Click(object sender, EventArgs e)
        {
            sliderbartimeradmin.Start();
        }

        private void ReportTimer_Tick(object sender, EventArgs e)
        {
            if (reportpanelcollape)
            {
                Reportpaneladmin.Height += 10;
                if (Reportpaneladmin.Height == Reportpaneladmin.MaximumSize.Height)
                {
                    reportpanelcollape = false;
                    ReportTimeradmin.Stop();
                }
            }
            else
            {
                Reportpaneladmin.Height -= 10;
                if (Reportpaneladmin.Height == Reportpaneladmin.MinimumSize.Height)
                {
                    reportpanelcollape = true;
                    ReportTimeradmin.Stop();
                }
            }
        }

        private void forminpanel(object formobj)
        {
            if (this.panelcontaineradmin.Controls.Count > 0)
                this.panelcontaineradmin.Controls.RemoveAt(0);
            Form fh = formobj as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontaineradmin.Controls.Add(fh);
            this.panelcontaineradmin.Tag = fh;
            fh.Show();
        }

        private void slidebaradmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salesreportbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new adminsalesreport());
        }

        private void stockreportbutton_Click(object sender, EventArgs e)
        {
            forminpanel(new adminstockreport());
        }

        private void expensereportbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new adminexpensereport());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            forminpanel(new SecondForm());
            timer.Stop();
            alert.BackColor = Color.FromArgb(0, 64, 64);
        }

        private void transactionandcashbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new financereport());
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintDialog pdialog = new PrintDialog();
            if (pdialog.ShowDialog() == DialogResult.OK)
            {
                pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                pd.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(panelcontaineradmin.Width, panelcontaineradmin.Height);
            panelcontaineradmin.DrawToBitmap(bm, new Rectangle(0, 0, panelcontaineradmin.Width, panelcontaineradmin.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void panelcontaineradmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createbackup_Click(object sender, EventArgs e)
        {
            forminpanel(new backupform());
        }

        private void graphbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new chartform());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Notification.BackColor = Color.FromArgb(0, 64, 64);
            if (qnt >= tstk)
            {
                MessageBox.Show("Out Of Stock!!!!!! Total Stock:" + tstk + " and Total Sales: " + qnt, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }

        }
    }
}
