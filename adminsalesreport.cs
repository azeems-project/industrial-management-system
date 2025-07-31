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
    public partial class adminsalesreport : Form
    {
        String custname, custphn, qnt, pymmth, amt,srchid,srchcstname;
        DateTime selecteddatetime;
        public adminsalesreport()
        {
            InitializeComponent();
        }

        private void adminsalesreport_Load(object sender, EventArgs e)
        {
            insertradioButton.Checked = true;
        }

        private void updateradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
            updatebutton.Visible = true;
            deletebutton.Visible = false;
            insertbutton.Visible = false;
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchid.Text != string.Empty || searchcustname.Text != string.Empty)
            {
                srchid = searchid.Text;
                srchcstname = searchcustname.Text;

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select dateandtime, customername, customerphonenum, quantity, paymentmethod, amount from salesreporttable where customername='" + srchcstname + "' or Id='" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            DateTime dateTimeValue = DateTime.Parse(reader1["dateandtime"].ToString());
                            dateTimePicker1.Value = dateTimeValue;
                            //DateTime valueFromSql = reader1.GetDateTime(1);
                            //dateTimePicker1.Value = valueFromSql;
                            getcustomername.Text = reader1["customername"].ToString();
                            getcustomerphone.Text = reader1["customerphonenum"].ToString();
                            getquantity.Text = reader1["quantity"].ToString();
                            getpaymentmethod.SelectedItem= reader1["paymentmethod"].ToString();
                            getamount.Text= reader1["amount"].ToString();

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

        private void getcustomername_TextChanged(object sender, EventArgs e)
        {

        }

        private void deleteradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
            updatebutton.Visible = false;
            deletebutton.Visible = true;
            insertbutton.Visible = false;
        }

        private void insertradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchpanel.Visible = false;
            updatebutton.Visible = false;
            deletebutton.Visible = false;
            insertbutton.Visible = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void insertbutton_Click(object sender, EventArgs e)
        {

            selecteddatetime = dateTimePicker1.Value;
            custname = getcustomername.Text;
            custphn = getcustomerphone.Text;
            qnt = getquantity.Text;
            pymmth = getpaymentmethod.SelectedItem.ToString();
            amt = getamount.Text;

            if (insertradioButton.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "INSERT INTO salesreporttable (dateandtime, customername, customerphonenum, quantity, paymentmethod, amount) VALUES ('" + selecteddatetime.ToString() + "','" + custname + "', '" + custphn + "','" + qnt + "','" + pymmth + "', '" + amt + "')";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getcustomername.Clear();
                         getcustomerphone.Clear();
                        getquantity.Clear();
                        getamount.Clear();

                    }

                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            selecteddatetime = dateTimePicker1.Value;
            custname = getcustomername.Text;
            custphn = getcustomerphone.Text;
            qnt = getquantity.Text;
            pymmth = getpaymentmethod.SelectedItem.ToString();
            amt = getamount.Text;

            if (updateradioButton.Checked)
            {

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "UPDATE[salesreporttable] SET[dateandtime] = '" + selecteddatetime.ToString() + "', [customername] = '" + custname + "', [customerphonenum] = '" + custphn  + "', [quantity] = '" + qnt + "', [paymentmethod] = '" + pymmth + "', [amount] = '" + amt + "'where customername = '" + srchcstname + "' or Id = '" + srchid + "'";
                    // UPDATE[salesreporttable] SET[dateandtime] = '" + selecteddatetime.ToString() + "', [customername] = '" + custname + "', [customerphonenum] = '" + " + custphn + " + "', [quantity] = '" + qnt + "', [paymentmethod] = '" + pymmth + "', [amount] = '" + amt + "'where customername = '" + srchcstname + "' or Id = '" + srchid + "'
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        cmd.Parameters.AddWithValue("@value2", selecteddatetime.ToString());
                        cmd.Parameters.AddWithValue("@value3", custname);
                        cmd.Parameters.AddWithValue("@value4", custphn);
                        cmd.Parameters.AddWithValue("@value5", qnt);
                        cmd.Parameters.AddWithValue("@value6", pymmth);
                        cmd.Parameters.AddWithValue("@value7", amt);
                      
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
                        getcustomername.Clear();
                        getcustomerphone.Clear();
                        getquantity.Clear();
                        getamount.Clear();

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
                    String queury = "DELETE FROM salesreporttable where customername = '" + srchcstname + "' or Id = '" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        // execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getcustomername.Clear();
                        getcustomerphone.Clear();
                        getquantity.Clear();
                        getamount.Clear();

                    }

                }
            }
            else
            {
                MessageBox.Show("Data Deletion Failed", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }
    }
}
