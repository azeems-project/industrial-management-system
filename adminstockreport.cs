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
    public partial class adminstockreport : Form
    {
        String asignid, invnt, stockto, totalst, remainingst, totalstamt, srchid;
        DateTime selecteddatetime;

       

        

        private void insertradioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            searchpanel.Visible = false;
            updatebutton.Visible = false;
            deletebutton.Visible = false;
            insertbutton.Visible = true;
            labelid.Visible = true;
            getid.Visible = true;
        }

        private void updateradioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
            updatebutton.Visible = true;
            deletebutton.Visible = false;
            insertbutton.Visible = false;
            labelid.Visible = false;
            getid.Visible = false;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            invnt = getinventory.Text;
            stockto = getstackturnover.Text;
            totalst = gettotalstpck.Text;
            remainingst = getremainingstock.Text;
            totalstamt = gettotalstockamount.Text;
            selecteddatetime = dateTimePicker1.Value;
            

            if (updateradioButton.Checked)
            {

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "UPDATE[stocktable] SET[stockdate] = '" + selecteddatetime.ToString() + "', [inventory] = '" + invnt + "', [stock_turnover] = '" + stockto + "', [total_stock] = '" + totalst + "', [remaining_stock] = '" + remainingst + "', [totalstockamount] = '" + totalstamt + "'where id = '" + srchid + "'";
                    // UPDATE[salesreporttable] SET[dateandtime] = '" + selecteddatetime.ToString() + "', [customername] = '" + custname + "', [customerphonenum] = '" + " + custphn + " + "', [quantity] = '" + qnt + "', [paymentmethod] = '" + pymmth + "', [amount] = '" + amt + "'where customername = '" + srchcstname + "' or Id = '" + srchid + "'
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        cmd.Parameters.AddWithValue("@value1", invnt);
                        cmd.Parameters.AddWithValue("@value2", stockto);
                        cmd.Parameters.AddWithValue("@value3", totalst);
                        cmd.Parameters.AddWithValue("@value4", remainingst);
                        cmd.Parameters.AddWithValue("@value5", totalstamt);
                        cmd.Parameters.AddWithValue("@value6", selecteddatetime.ToString());

                        if (con.State != ConnectionState.Open)
                            con.Open();
                        // execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Data Updatation failed", "Success", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                        }
                        con.Close();
                         getinventory.Clear();
                         getstackturnover.Clear();
                       gettotalstpck.Clear();
                       getremainingstock.Clear();
                       gettotalstockamount.Clear();

                    }

                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (deleteradioButton.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "DELETE FROM stocktable where id = '" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        // execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getinventory.Clear();
                        getstackturnover.Clear();
                        gettotalstpck.Clear();
                        getremainingstock.Clear();
                        gettotalstockamount.Clear();

                    }

                }
            }
            else
            {
                MessageBox.Show("Data Deletion Failed", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchid.Text != string.Empty)
            {
                srchid = searchid.Text;
                

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select inventory, stock_turnover, total_stock, remaining_stock, totalstockamount, stockdate from stocktable where id='" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            DateTime dateTimeValue = DateTime.Parse(reader1["stockdate"].ToString());
                            dateTimePicker1.Value = dateTimeValue;
                            //DateTime valueFromSql = reader1.GetDateTime(1);
                            //dateTimePicker1.Value = valueFromSql;
                            getinventory.Text = reader1["inventory"].ToString();
                            getstackturnover.Text = reader1["stock_turnover"].ToString();
                            gettotalstpck.Text = reader1["total_stock"].ToString();
                            getremainingstock.Text= reader1["remaining_stock"].ToString();
                            gettotalstockamount.Text = reader1["totalstockamount"].ToString();

                            MessageBox.Show("Data has shown on left side. You can Update it", "DATA Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sorry..No Data Found. You must need to signup", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                        }
                        con.Close();
                    }
                }
            }
        }

        private void deleteradioButton_CheckedChanged_1(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
            updatebutton.Visible = false;
            deletebutton.Visible = true;
            insertbutton.Visible = false;
            labelid.Visible = false;
            getid.Visible = false;
        }

      

        private void insertbutton_Click(object sender, EventArgs e)
        {
            invnt = getinventory.Text;
            stockto = getstackturnover.Text;
            totalst = gettotalstpck.Text;
            remainingst = getremainingstock.Text;
            totalstamt = gettotalstockamount.Text;
            selecteddatetime = dateTimePicker1.Value;
            asignid = getid.Text;

            if (insertradioButton.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "INSERT INTO stocktable (inventory, stock_turnover, total_stock, remaining_stock, totalstockamount, stockdate) VALUES ('" + invnt + "','" + stockto + "', '" + totalst + "','" + remainingst + "','" + totalstamt + "', '" + selecteddatetime.ToString() + "')";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getinventory.Clear();
                        getstackturnover.Clear();
                        gettotalstpck.Clear();
                       gettotalstockamount.Clear();
                        getremainingstock.Clear();

                    }

                }
            }
        }

        public adminstockreport()
        {
            InitializeComponent();
        }

        private void adminstockreport_Load(object sender, EventArgs e)
        {
            insertradioButton.Checked = true;
        }
    }
}
