using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coal_managment_application
{
    public partial class SecondForm : Form
    {
        public SecondForm()
        {
            InitializeComponent();
        }

        private void SecondForm_Load(object sender, EventArgs e)
        {
            string fileName = "assign_duty";
            string data = GetDataFromFile(fileName);
            txtdescription.Text = data;
        }

        public string GetDataFromFile(string fileName)
        {
            string data = string.Empty;
            using (var reader = new StreamReader(fileName))
            {
                data = reader.ReadToEnd();
            }
            
            return data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("assign_duty", string.Empty);
        }
    }
}
