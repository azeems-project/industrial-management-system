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
    public partial class transactionandcashform : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public transactionandcashform()
        {
            InitializeComponent();
        }

        private void transactionandcashform_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
            {
                String queury = "select * from finance";
                using (SqlCommand cmd = new SqlCommand(queury, con))
                {
                    listView1.Columns.Add("finance_id", 100);
                    listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                    listView1.Columns.Add("financetype", 300, HorizontalAlignment.Center);
                    listView1.Columns.Add("finance_descrip", 400, HorizontalAlignment.Center);

                    listView1.Font = new Font("Microsoft Sans Serif", 12);

                    // Set the column widths
                    foreach (ColumnHeader column in listView1.Columns)
                    {
                        column.Width = -2;
                    }

                    listView1.View = View.Details;



                    con.Open();
                    da = new SqlDataAdapter(cmd);
                    ds = new DataSet();
                    da.Fill(ds, "testTable");
                    con.Close();

                    dt = ds.Tables["testTable"];
                    int i;
                    for (i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                        
                    }

                }

            }
        }

        private void allrecord_CheckedChanged(object sender, EventArgs e)
        {
            if (allrecord.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from finance";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("finance_id", 100);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("financetype", 300, HorizontalAlignment.Center);
                        listView1.Columns.Add("finance_descrip", 400, HorizontalAlignment.Center);

                        listView1.Font = new Font("Microsoft Sans Serif", 12);

                        // Set the column widths
                        foreach (ColumnHeader column in listView1.Columns)
                        {
                            column.Width = -2;
                        }

                        listView1.View = View.Details;



                        con.Open();
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "testTable");
                        con.Close();

                        dt = ds.Tables["testTable"];
                        int i;
                        for (i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());

                        }

                    }

                }
            }
        }

        private void mnthlyrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mnthlyrbtn.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from finance WHERE DATEPART(month, CONVERT(date, date, 105)) = DATEPART(month, GETDATE()) AND DATEPART(year, CONVERT(date, date, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("finance_id", 100);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("financetype", 300, HorizontalAlignment.Center);
                        listView1.Columns.Add("finance_descrip", 400, HorizontalAlignment.Center);

                        listView1.Font = new Font("Microsoft Sans Serif", 12);

                        // Set the column widths
                        foreach (ColumnHeader column in listView1.Columns)
                        {
                            column.Width = -2;
                        }

                        listView1.View = View.Details;



                        con.Open();
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "testTable");
                        con.Close();

                        dt = ds.Tables["testTable"];
                        int i;
                        for (i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());

                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }

        private void weeklyreportrb_CheckedChanged(object sender, EventArgs e)
        {
            if (weeklyreportrb.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from finance WHERE DATEPART(week, CONVERT(date, date, 105)) = DATEPART(week, GETDATE()) AND DATEPART(year, CONVERT(date, date, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("finance_id", 100);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("financetype", 300, HorizontalAlignment.Center);
                        listView1.Columns.Add("finance_descrip", 400, HorizontalAlignment.Center);

                        listView1.Font = new Font("Microsoft Sans Serif", 12);

                        // Set the column widths
                        foreach (ColumnHeader column in listView1.Columns)
                        {
                            column.Width = -2;
                        }

                        listView1.View = View.Details;



                        con.Open();
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "testTable");
                        con.Close();

                        dt = ds.Tables["testTable"];
                        int i;
                        for (i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());

                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }

        private void dailyreportrb_CheckedChanged(object sender, EventArgs e)
        {
            if (dailyreportrb.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from finance where CONVERT(date, date, 105) = CONVERT(date, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("finance_id", 100);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("financetype", 300, HorizontalAlignment.Center);
                        listView1.Columns.Add("finance_descrip", 400, HorizontalAlignment.Center);

                        listView1.Font = new Font("Microsoft Sans Serif", 12);

                        // Set the column widths
                        foreach (ColumnHeader column in listView1.Columns)
                        {
                            column.Width = -2;
                        }

                        listView1.View = View.Details;



                        con.Open();
                        da = new SqlDataAdapter(cmd);
                        ds = new DataSet();
                        da.Fill(ds, "testTable");
                        con.Close();

                        dt = ds.Tables["testTable"];
                        int i;
                        for (i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());

                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }
    }
}
