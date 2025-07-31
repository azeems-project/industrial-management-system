using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace coal_managment_application
{
    public partial class assigndutyform : Form
    {
       String name,description; 
        public assigndutyform()
        {
            InitializeComponent();
        }

        public void SaveDataToFile(string fileName, string data)
        {
            using (var writer = new StreamWriter(fileName))
            {
                writer.Write(data);
            }
        }

        private void Send_Data_Click(object sender, EventArgs e)
        {
            name = "assign_duty";
            description = getdescription.Text;
            SaveDataToFile(name, description);

        }
    }

       
    }
