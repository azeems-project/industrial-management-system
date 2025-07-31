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
    public partial class stockreportform : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public stockreportform()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockreportform_Load(object sender, EventArgs e)
        {
             using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
            {
                String queury = "select * from stocktable";
                using (SqlCommand cmd = new SqlCommand(queury, con))
                {
                    listView1.Columns.Clear(); // clear existing columns
                    listView1.Items.Clear(); // clear existing items
                    listView1.View = View.Details;

                    listView1.Columns.Add("id", 30);
                    listView1.Columns.Add("stockdate", 180, HorizontalAlignment.Center);
                    listView1.Columns.Add("inventory", 100, HorizontalAlignment.Center);
                    listView1.Columns.Add("stock_turnover", 130, HorizontalAlignment.Center);
                    listView1.Columns.Add("total_stock", 100, HorizontalAlignment.Center);
                    listView1.Columns.Add("remaining_stock", 130, HorizontalAlignment.Center);
                    listView1.Columns.Add("totalstockamount", 120, HorizontalAlignment.Center);
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
                        listView1.Items.Add(dt.Rows[i].ItemArray[6].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                    }

                }

            }
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            // Set the background color of the column headers
            e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);

            // Draw the text of the column header
            e.DrawText();
        }

        private void allrecord_CheckedChanged(object sender, EventArgs e)
        {
            if (allrecord.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from stocktable";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("stockdate", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("inventory", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("stock_turnover", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("total_stock", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("remaining_stock", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("totalstockamount", 120, HorizontalAlignment.Center);
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
                            listView1.Items.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
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
                    String queury = "select * from stocktable where CONVERT(date, stockdate, 105) = CONVERT(date, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("stockdate", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("inventory", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("stock_turnover", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("total_stock", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("remaining_stock", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("totalstockamount", 120, HorizontalAlignment.Center);
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
                            listView1.Items.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
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
                    String queury = "select * from stocktable WHERE DATEPART(week, CONVERT(date, stockdate, 105)) = DATEPART(week, GETDATE()) AND DATEPART(year, CONVERT(date, stockdate, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("stockdate", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("inventory", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("stock_turnover", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("total_stock", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("remaining_stock", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("totalstockamount", 120, HorizontalAlignment.Center);
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
                            listView1.Items.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }

        private void mnthlyrbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (mnthlyrbtn.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from stocktable WHERE DATEPART(month, CONVERT(date, stockdate, 105)) = DATEPART(month, GETDATE()) AND DATEPART(year, CONVERT(date, stockdate, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("stockdate", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("inventory", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("stock_turnover", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("total_stock", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("remaining_stock", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("totalstockamount", 120, HorizontalAlignment.Center);
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
                            listView1.Items.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[0].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }
    }
}
