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
    public partial class adminexpensereport : Form
    {
        String asignid, equip_exp, maint_exp, empl_exp, insur_exp, travel_exp, srchid;

        private void insertbutton_Click(object sender, EventArgs e)
        {
            equip_exp = getequip_exp.Text;
            maint_exp = getmaint_exp.Text;
            empl_exp = getempl_exp.Text;
            insur_exp = getinsur_exp.Text;
            travel_exp = gettravel_exp.Text;
            selecteddatetime = dateTimePicker1.Value;
            asignid = getid.Text;

            if (insertradioButton.Checked)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "INSERT INTO expense (Id, equipment_exp, maintainance_exp, employee_exp, insurance_exp, travel_exp, date) VALUES ('" + asignid + "','" + equip_exp + "', '" + maint_exp + "','" + empl_exp + "','" + insur_exp + "','" + travel_exp + "', '" + selecteddatetime.ToString() + "')";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Data Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getequip_exp.Clear();
                        getmaint_exp.Clear();
                        getempl_exp.Clear();
                        getinsur_exp.Clear();
                        gettravel_exp.Clear();

                    }

                }
            }
        }

        private void updatebutton_Click(object sender, EventArgs e)
        {

            equip_exp = getequip_exp.Text;
            maint_exp = getmaint_exp.Text;
            empl_exp = getempl_exp.Text;
            insur_exp = getinsur_exp.Text;
            travel_exp = gettravel_exp.Text;
            selecteddatetime = dateTimePicker1.Value;
            asignid = getid.Text;

            if (updateradioButton.Checked)
            {

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "UPDATE[expense] SET[equipment_exp] = '" + equip_exp + "', [maintainance_exp] = '" + maint_exp + "', [employee_exp] = '" + empl_exp + "', [insurance_exp] = '" + insur_exp + "', [travel_exp] = '" + travel_exp + "', [date] = '" + selecteddatetime.ToString() + "'where id = '" + srchid + "'";
                    // UPDATE[salesreporttable] SET[dateandtime] = '" + selecteddatetime.ToString() + "', [customername] = '" + custname + "', [customerphonenum] = '" + " + custphn + " + "', [quantity] = '" + qnt + "', [paymentmethod] = '" + pymmth + "', [amount] = '" + amt + "'where customername = '" + srchcstname + "' or Id = '" + srchid + "'
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        cmd.Parameters.AddWithValue("@value1", equip_exp);
                        cmd.Parameters.AddWithValue("@value2", maint_exp);
                        cmd.Parameters.AddWithValue("@value3", empl_exp);
                        cmd.Parameters.AddWithValue("@value4", insur_exp);
                        cmd.Parameters.AddWithValue("@value5", travel_exp);
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
                        getequip_exp.Clear();
                        getmaint_exp.Clear();
                        getempl_exp.Clear();
                        getinsur_exp.Clear();
                        gettravel_exp.Clear();

                    }

                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            if (searchid.Text != string.Empty)
            {
                srchid = searchid.Text;


                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    String queury = "select equipment_exp, maintainance_exp, employee_exp, insurance_exp, travel_exp, date from expense where id='" + srchid + "'";
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
                            getequip_exp.Text = reader1["equipment_exp"].ToString();
                           getmaint_exp.Text = reader1["maintainance_exp"].ToString();
                            getempl_exp.Text = reader1["employee_exp"].ToString();
                            getinsur_exp.Text = reader1["insurance_exp"].ToString();
                            gettravel_exp.Text = reader1["travel_exp"].ToString();

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
                    String queury = "DELETE FROM expense where id = '" + srchid + "'";
                    using (SqlCommand cmd = new SqlCommand(queury, con))
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();
                        // execute the query
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                        getequip_exp.Clear();
                        getmaint_exp.Clear();
                        getempl_exp.Clear();
                        getinsur_exp.Clear();
                        gettravel_exp.Clear();

                    }

                }
            }
            else
            {
                MessageBox.Show("Data Deletion Failed", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
            }
        }

        DateTime selecteddatetime;
        public adminexpensereport()
        {
            InitializeComponent();
        }

        private void adminexpensereport_Load(object sender, EventArgs e)
        {
            insertradioButton.Checked = true;
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
    }
}
