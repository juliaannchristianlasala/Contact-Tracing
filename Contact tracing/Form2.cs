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
            StreamReader Alldata = new StreamReader(@"C:\Users\JULIA-ANN\Desktop\Contact Tracing.txt");
            String all = Alldata.ReadToEnd();
            MessageBox.Show(all);
        }
    }
}
