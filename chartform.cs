using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace coal_managment_application
{
    public partial class chartform : Form
    {
        Chart chart2, Chart0, chart3;
        public chartform()
        {
            InitializeComponent();
        }

        private void chartform_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ProjectConnection.connectionstring))
            {
                connection.Open();

                string query = "SELECT paymentmethod, SUM(CASE WHEN ISNUMERIC(amount) = 1 THEN CAST(amount AS float) ELSE 0.0 END) AS TotalAmount FROM salesreporttable GROUP BY paymentmethod";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);


                // Bind the data to the chart control
                chart1.DataSource = dataTable;
                chart1.Series["Series1"].XValueMember = "paymentmethod";
                chart1.Series["Series1"].YValueMembers = "TotalAmount";

                // Customize the appearance of the chart control
                chart1.Series["Series1"].ChartType = SeriesChartType.Bar;
                chart1.Series["Series1"].Color = System.Drawing.Color.DarkBlue;
                chart1.ChartAreas[0].AxisX.Title = "Payment Method";
                chart1.ChartAreas[0].AxisY.Title = "Total Amount";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // Connect to the database
                using (SqlConnection connection = new SqlConnection(ProjectConnection.connectionstring))
                {
                    connection.Open();

                    // Retrieve the data from the database

                    string query = "SELECT paymentmethod, SUM(CASE WHEN ISNUMERIC(amount) = 1 THEN CAST(amount AS float) ELSE 0.0 END) AS TotalAmount FROM salesreporttable GROUP BY paymentmethod";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // create a new chart control
                    Chart chart1 = new Chart();

                    // set the chart control properties
                    chart1.Size = new System.Drawing.Size(776, 324);
                    chart1.ChartAreas.Add("ChartArea1");
                    chart1.Location = new Point(12, 97);
                   

                    // Bind the data to the chart control
                    chart1.DataSource = dataTable;
                    // Create a new series and add it to the chart control
                    Series newSeries = new Series("NewSeries");
                    chart1.Series.Add(newSeries);

                    // Bind the data to the new series
                    newSeries.ChartType = SeriesChartType.Bar;
                    newSeries.Color = System.Drawing.Color.DarkBlue;
                    newSeries.XValueMember = "paymentmethod";
                    newSeries.YValueMembers = "TotalAmount";

                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("SELECT paymentmethod, SUM(CASE WHEN ISNUMERIC(amount) = 1 THEN CAST(amount AS float) ELSE 0.0 END) AS TotalAmount FROM salesreporttable GROUP BY paymentmethod", con);

                    // open the database connection
                    con.Open();

                    // execute the SQL query and get the SqlDataReader object
                    SqlDataReader reader = cmd.ExecuteReader();

                    // create a regular expression to match only numeric values
                    Regex regex = new Regex(@"\d+");

                    

                    // create a new chart control
                    Chart0 = new Chart();

                    // set the chart control properties
                    Chart0.Size = new System.Drawing.Size(500, 300);
                    Chart0.ChartAreas.Add("ChartArea1");
                    Chart0.Series.Add("Total");
                    Chart0.Series["Total"].ChartType = SeriesChartType.Bar;

                    // iterate through the SqlDataReader object and extract the numeric values and dates from each row
                    while (reader.Read())
                    {

                        // add the date and total to the chart control
                        Chart0.Series["Total"].Points.AddXY(reader["paymentmethod"].ToString(), Convert.ToDouble(reader["TotalAmount"]));
                    }

                    // close the SqlDataReader object and the database connection
                    reader.Close();
                    con.Close();

                    // remove the previous chart control from the form's Controls collection
                    if (this.Controls.Contains(chart2) || this.Controls.Contains(chart1) || this.Controls.Contains(chart3))
                    {
                        this.Controls.Remove(chart2);
                        this.Controls.Remove(chart1);
                        this.Controls.Remove(chart3);
                    }

                    // add the new chart control to the form's Controls collection
                    this.Controls.Add(Chart0);
                    Chart0.Location = new Point(12, 97);
                    Chart0.Size = new Size(776, 324);
                    chart2 = Chart0;
                    chart1 = Chart0;
                    chart3 = Chart0;
                }
            }


            if (radioButton2.Checked == true)
            {
                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("SELECT equipment_exp, maintainance_exp, employee_exp, insurance_exp, travel_exp, date FROM expense", con);

                // open the database connection
                con.Open();

                // execute the SQL query and get the SqlDataReader object
                SqlDataReader reader = cmd.ExecuteReader();

                // create a regular expression to match only numeric values
                Regex regex = new Regex(@"\d+");

                // initialize the running total to 0
                int total = 0;

                    // create a new chart control
                    chart2 = new Chart();

                    // set the chart control properties
                    chart2.Size = new System.Drawing.Size(500, 300);
                    chart2.ChartAreas.Add("ChartArea1");
                    chart2.Series.Add("Total");
                    chart2.Series["Total"].ChartType = SeriesChartType.Line;

                    // iterate through the SqlDataReader object and extract the numeric values and dates from each row
                    while (reader.Read())
                    {
                        int columnTotal = 0;
                        string dateValue = reader["date"].ToString();

                        // iterate through each column and extract the numeric values
                        for (int i = 0; i < reader.FieldCount - 1; i++)
                        {
                            string columnValue = reader[i].ToString();
                            MatchCollection matches = regex.Matches(columnValue);

                            // iterate through the matches and extract the numeric values
                            foreach (Match match in matches)
                            {
                                int numericValue = int.Parse(match.Value);
                                columnTotal += numericValue;
                            }
                        }

                        // add the column total to the running total
                        total += columnTotal;

                        // add the date and total to the chart control
                        chart2.Series["Total"].Points.AddXY(dateValue, total);
                    }

                    // close the SqlDataReader object and the database connection
                    reader.Close();
                    con.Close();

                    // remove the previous chart control from the form's Controls collection
                    if (this.Controls.Contains(chart1) || this.Controls.Contains(Chart0) || this.Controls.Contains(chart3))
                    {
                        this.Controls.Remove(chart1);
                        this.Controls.Remove(chart3);
                        this.Controls.Remove(Chart0);
                    }

                    // add the new chart control to the form's Controls collection
                    this.Controls.Add(chart2);
                    chart2.Location = new Point(12, 97);
                    chart2.Size = new Size(776, 324);
                    chart1 = chart2;
                    Chart0 = chart2;
                    chart3 = chart2;
                }
            }


            if (radioButton3.Checked == true)
            {

                using (SqlConnection con = new SqlConnection(ProjectConnection.connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("SELECT CAST(CASE WHEN ISNUMERIC(LEFT(remaining_stock, PATINDEX('%[^0-9.-]%', remaining_stock + 'X') - 1)) = 1 THEN LEFT(remaining_stock, PATINDEX('%[^0-9.-]%', remaining_stock + 'X') - 1) ELSE NULL END AS float) AS numeric_value, stockdate FROM stocktable WHERE remaining_stock LIKE '%[0-9.-]%'", con);

                    // open the database connection
                    con.Open();

                    // execute the SQL query and get the SqlDataReader object
                    SqlDataReader reader = cmd.ExecuteReader();

                    // create a regular expression to match only numeric values
                    Regex regex = new Regex(@"\d+");



                    // create a new chart control
                    chart3 = new Chart();

                    // set the chart control properties
                    chart3.Size = new System.Drawing.Size(500, 300);
                    chart3.ChartAreas.Add("ChartArea1");
                    chart3.Series.Add("Remaining_Stock");
                    chart3.Series["Remaining_Stock"].ChartType = SeriesChartType.Bar;


                    while (reader.Read())
                    {
                        // retrieve the numeric_value and stockdate values from the reader
                        double numericValue = Convert.ToDouble(reader["numeric_value"]);
                        string stockDate = reader["stockdate"].ToString();

                        // add the date and Remaining_Stock to the chart control
                        chart3.Series["Remaining_Stock"].Points.AddXY(stockDate, numericValue);
                    }


                    // close the SqlDataReader object and the database connection
                    reader.Close();
                    con.Close();

                    // remove the previous chart control from the form's Controls collection
                    if (this.Controls.Contains(chart2) || this.Controls.Contains(Chart0) || this.Controls.Contains(chart1))
                    {
                        this.Controls.Remove(chart2);
                        this.Controls.Remove(Chart0);
                        this.Controls.Remove(chart1);
                    }

                    // add the new chart control to the form's Controls collection
                    this.Controls.Add(chart3);
                    chart3.Location = new Point(12, 97);
                    chart3.Size = new Size(776, 324);
                    chart2 = chart3;
                    Chart0 = chart3;
                    chart1 = chart3;

                }

            }

        }
    }
    }
    

