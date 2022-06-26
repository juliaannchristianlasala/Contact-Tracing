using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowAllDatabutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 alldata = new Form3();
            alldata.ShowDialog();
            alldata = null;
            this.Show();
        }

        private void searchdate_ValueChanged(object sender, EventArgs e)
        {
            var filedates = Directory.GetFiles(@"C:\Users\JULIA-ANN\source\repos\Contact Tracing Information\");

            List<string> listofdates = new List<string>();
            string fdates = searchdate.Text;
            int alldata = 0;

            foreach (string data in filedates)
            {
                string datadates = File.ReadAllText(data);
                if (datadates.Contains(fdates))
                {
                    alldata++;
                    var date = datadates.Substring(0, datadates.IndexOf(fdates));
                }
            }

            if (alldata != 0)
            {
                MessageBox.Show("All data has been found");
            }
            else
            {
                MessageBox.Show("No data was found");
            }
        }
    }
}
