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
    public partial class salesreportform : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public salesreportform()
        {
            InitializeComponent();
        }

        private void salesreportform_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
            {
                String queury = "select * from salesreporttable";
                using (SqlCommand cmd = new SqlCommand(queury, con))
                {
                    listView1.Columns.Add("Id", 30);
                    listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                    listView1.Columns.Add("customername", 100, HorizontalAlignment.Center);
                    listView1.Columns.Add("customerphonenum", 130, HorizontalAlignment.Center);
                    listView1.Columns.Add("quantity", 110, HorizontalAlignment.Center);
                    listView1.Columns.Add("paymentmethod", 110, HorizontalAlignment.Center);
                    listView1.Columns.Add("amount", 110, HorizontalAlignment.Center);
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
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                        listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                    }

                }

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void allrecord_CheckedChanged(object sender, EventArgs e)
        {
            if (allrecord.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from salesreporttable";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("Id", 30);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("customername", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("customerphonenum", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("quantity", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("paymentmethod", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("amount", 110, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
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
                    String queury = "select * from salesreporttable where CONVERT(date, dateandtime, 105) = CONVERT(date, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("Id", 30);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("customername", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("customerphonenum", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("quantity", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("paymentmethod", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("amount", 110, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
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
                    String queury = "select * from salesreporttable WHERE DATEPART(week, CONVERT(date, dateandtime, 105)) = DATEPART(week, GETDATE()) AND DATEPART(year, CONVERT(date, dateandtime, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("Id", 30);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("customername", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("customerphonenum", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("quantity", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("paymentmethod", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("amount", 110, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
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
                    String queury = "select * from salesreporttable WHERE DATEPART(month, CONVERT(date, dateandtime, 105)) = DATEPART(month, GETDATE()) AND DATEPART(year, CONVERT(date, dateandtime, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("Id", 30);
                        listView1.Columns.Add("dateandtime", 170, HorizontalAlignment.Center);
                        listView1.Columns.Add("customername", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("customerphonenum", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("quantity", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("paymentmethod", 110, HorizontalAlignment.Center);
                        listView1.Columns.Add("amount", 110, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }
    }
}
