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
    public partial class expensereportform : Form
    {
        DataTable dt;
        SqlDataAdapter da;
        DataSet ds;
        public expensereportform()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void expensereportform_Load(object sender, EventArgs e)
        {
            if (allrecord.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from expense";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("date", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("equipment_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("maintainance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("employee_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("insurance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("travel_exp", 120, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                        }

                    }

                }

            }
            
        }

        private void dailyreportrb_CheckedChanged(object sender, EventArgs e)
        {
            if (dailyreportrb.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    string query = "SELECT * FROM expense where CONVERT(date, date, 105) = CONVERT(date, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        // add new columns
                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("date", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("equipment_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("maintainance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("employee_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("insurance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("travel_exp", 120, HorizontalAlignment.Center);

                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        con.Close();

                        foreach (DataRow row in dt.Rows)
                        {
                            ListViewItem item = new ListViewItem(row["id"].ToString());
                            item.SubItems.Add(row["date"].ToString());
                            item.SubItems.Add(row["equipment_exp"].ToString());
                            item.SubItems.Add(row["maintainance_exp"].ToString());
                            item.SubItems.Add(row["employee_exp"].ToString());
                            item.SubItems.Add(row["insurance_exp"].ToString());
                            item.SubItems.Add(row["travel_exp"].ToString());
                            listView1.Items.Add(item);
                        }
                    }
                }

                this.Refresh(); // refresh the form
            }

        }

        private void weeklyreportrb_CheckedChanged(object sender, EventArgs e)
        {
            if (weeklyreportrb.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    string queury = "SELECT * FROM expense WHERE DATEPART(week, CONVERT(date, date, 105)) = DATEPART(week, GETDATE()) AND DATEPART(year, CONVERT(date, date, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("date", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("equipment_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("maintainance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("employee_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("insurance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("travel_exp", 120, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                        }

                    }

                }
            }
            this.Refresh(); // refresh the form
        }

        private void allrecord_CheckedChanged(object sender, EventArgs e)
        {
            if (allrecord.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select * from expense";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("date", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("equipment_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("maintainance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("employee_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("insurance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("travel_exp", 120, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
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
                    String queury = "select * from expense WHERE DATEPART(month, CONVERT(date, date, 105)) = DATEPART(month, GETDATE()) AND DATEPART(year, CONVERT(date, date, 105)) = DATEPART(year, GETDATE())";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        listView1.Columns.Clear(); // clear existing columns
                        listView1.Items.Clear(); // clear existing items
                        listView1.View = View.Details;

                        listView1.Columns.Add("id", 30);
                        listView1.Columns.Add("date", 180, HorizontalAlignment.Center);
                        listView1.Columns.Add("equipment_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("maintainance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("employee_exp", 100, HorizontalAlignment.Center);
                        listView1.Columns.Add("insurance_exp", 130, HorizontalAlignment.Center);
                        listView1.Columns.Add("travel_exp", 120, HorizontalAlignment.Center);
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
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[6].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                            listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
                        }

                    }

                }

            }
            this.Refresh(); // refresh the form
        }
    }
}
