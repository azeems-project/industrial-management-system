using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coal_managment_application
{
    public partial class ownermenu : Form
    {
        bool slidebarexpand;
        bool reportpanelcollape;
        public Timer timer = new Timer();
        String tstock, quantity;
        int tstk, qnt;

        public ownermenu()
        {
            InitializeComponent();
        }

        private void ownermenu_Load(object sender, EventArgs e)
        {
            slidebar.Dock=DockStyle.Left;


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

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Notification.BackColor = Color.FromArgb(0, 64, 64);

            if (qnt >= tstk)
            {
                MessageBox.Show("Out Of Stock!!!!!! Total Stock:" + tstk + " and Total Sales: " + qnt, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void sliderbartimer_Tick(object sender, EventArgs e)
        {
            if (slidebarexpand)
            {
                slidebar.Width -= 10;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    slidebarexpand = false;
                    sliderbartimer.Stop();
                }
            }
            else
            {
                slidebar.Width += 10;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    slidebarexpand = true;
                    sliderbartimer.Stop();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportTimer.Start();
        }

        private void menubuttononbar_Click(object sender, EventArgs e)
        {
            sliderbartimer.Start();
        }

        private void ReportTimer_Tick(object sender, EventArgs e)
        {
            if (reportpanelcollape)
            {
                Reportpanel.Height += 10;
                if (Reportpanel.Height == Reportpanel.MaximumSize.Height)
                {
                    reportpanelcollape = false;
                    ReportTimer.Stop();
                }
            }
            else
            {
                Reportpanel.Height -= 10;
                if (Reportpanel.Height == Reportpanel.MinimumSize.Height)
                {
                    reportpanelcollape = true;
                    ReportTimer.Stop();
                }
            }
        }

        private void forminpanel(object formobj)
        {
            if (this.panelcontainer.Controls.Count > 0)
                this.panelcontainer.Controls.RemoveAt(0);
            Form fh = formobj as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontainer.Controls.Add(fh);
            this.panelcontainer.Tag = fh;
            fh.Show();
        }
        private void salesreportbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new salesreportform());
        }

        private void stockreportbutton_Click(object sender, EventArgs e)
        {
            forminpanel(new stockreportform());
        }

        private void expensereportbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new expensereportform());
        }

        private void suppliesreportbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new financereport());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            forminpanel(new transactionandcashform());
        }

        private void panelcontainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(panelcontainer.Width, panelcontainer.Height);
            panelcontainer.DrawToBitmap(bm, new Rectangle(0, 0, panelcontainer.Width, panelcontainer.Height));
            e.Graphics.DrawImage(bm, 0, 0);
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

        private void createbackup_Click(object sender, EventArgs e)
        {
            forminpanel(new backupform());
        }

        private void graphbtn_Click(object sender, EventArgs e)
        {
            forminpanel(new chartform());
        }

        private void assignduty_Click(object sender, EventArgs e)
        {
            forminpanel(new assigndutyform());
        }

        private void logout_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.Show();
            this.Hide();
        }
    }
}
