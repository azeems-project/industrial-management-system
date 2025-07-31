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
    public partial class financereport : Form
    {
        String asignid, fin_type, fin_desc, srchid;
        public DateTime selecteddatetime;

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchid.Text != string.Empty)
            {
                srchid = searchid.Text;


                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select financetype, finance_descrip, date from finance where finance_id='" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        SqlDataReader reader1;
                        reader1 = cmd.ExecuteReader();
                        if (reader1.Read())
                        {
                            DateTime dateTimeValue = DateTime.Parse(reader1["date"].ToString());
                            dateTimePicker1.Value = dateTimeValue;
                            //DateTime valueFromSql = reader1.GetDateTime(1);
                            //dateTimePicker1.Value = valueFromSql;
                            getfin_type.Text = reader1["financetype"].ToString();
                            get_desc.Text = reader1["finance_descrip"].ToString();

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

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (deleteradioButton.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "DELETE FROM finance where finance_id = '" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        // execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getid.Clear();
                        getfin_type.Clear();
                        get_desc.Clear();

                    }

                }
            }
            else
            {
                MessageBox.Show("Data Deletion Failed", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        private void financereport_Load(object sender, EventArgs e)
        {

        }

        private void insertradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchpanel.Visible = false;
            updatebutton.Visible = false;
            deletebutton.Visible = false;
            insertbutton.Visible = true;
            labelid.Visible = true;
            getid.Visible = true;
        }

        private void updateradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
            updatebutton.Visible = true;
            deletebutton.Visible = false;
            insertbutton.Visible = false;
            labelid.Visible = false;
            getid.Visible = false;
        }

        private void deleteradioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchpanel.Visible = true;
            updatebutton.Visible = false;
            deletebutton.Visible = true;
            insertbutton.Visible = false;
            labelid.Visible = false;
            getid.Visible = false;
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            asignid = getid.Text;
            fin_type = getfin_type.Text;
            selecteddatetime = dateTimePicker1.Value;
            fin_desc = get_desc.Text;
            if (updateradioButton.Checked)
            {

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "UPDATE[finance] SET[financetype] = '" + fin_type + "', [finance_descrip] = '" + fin_desc + "', [date] = '" + selecteddatetime.ToString() + "'where finance_id = '" + srchid + "'";
                    // UPDATE[salesreporttable] SET[dateandtime] = '" + selecteddatetime.ToString() + "', [customername] = '" + custname + "', [customerphonenum] = '" + " + custphn + " + "', [quantity] = '" + qnt + "', [paymentmethod] = '" + pymmth + "', [amount] = '" + amt + "'where customername = '" + srchcstname + "' or Id = '" + srchid + "'
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        
                        cmd.Parameters.AddWithValue("@value2", fin_type);
                        cmd.Parameters.AddWithValue("@value3", fin_desc);
                        cmd.Parameters.AddWithValue("@value4", selecteddatetime.ToString());

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
                        getid.Clear();
                        getfin_type.Clear();
                        get_desc.Clear();

                    }

                }
            }
        }

        
        public financereport()
        {
            InitializeComponent();
        }

        private void insertbutton_Click(object sender, EventArgs e)
        {
            asignid = getid.Text;
            fin_type= getfin_type.Text;
            selecteddatetime = dateTimePicker1.Value;
            fin_desc = get_desc.Text;

            if (insertradioButton.Checked)
            {
                getid.Visible = true;
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "INSERT INTO finance (finance_id, financetype, finance_descrip, date) VALUES ('" + asignid + "','" + fin_type + "', '" + fin_desc + "', '" + selecteddatetime.ToString() + "')";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getid.Clear();
                        getfin_type.Clear();
                        get_desc.Clear();
                      

                    }

                }
            }
        }
    }
}
