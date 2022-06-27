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
                    this.Hide();
                    alldata++;
                    var date = datadates.Substring(0, datadates.IndexOf(fdates));
                    MessageBox.Show(datadates);
                }
            }

            if (alldata != 0)
            {
                MessageBox.Show("That's all of the data collected on this date");
                this.Show();
            }
            else
            {
                this.Hide();
                MessageBox.Show("No data was found on this date");
                this.Show();
            }
        }

        private void Nsearchtxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nsearchbutton_Click(object sender, EventArgs e)
        {

            var filenames = Directory.GetFiles(@"C:\Users\JULIA-ANN\source\repos\Contact Tracing Information\");

            string searchname = Nsearchtxtbox.Text;
            foreach (var datanames in filenames)
            {
                if (datanames.Contains(searchname))
                {
                    this.Hide();
                    searchname = File.ReadAllText(datanames);
                    MessageBox.Show("Results has been Found");
                    MessageBox.Show(searchname);

                    Nsearchtxtbox.Text = "";
                    this.Show();
                }
            }
        }
    }
}
