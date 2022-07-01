using QRCoder;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var allfiles = Directory.GetFiles(@"C:\Users\JULIA-ANN\source\repos\Contact Tracing Information\");

            string data = infoslabel.Text;
            foreach (var genqr in allfiles)
            {
                if (genqr.Contains(data))
                {
                    data = File.ReadAllText(genqr);
                    infoslabel.Text = data;
                }
            }
        }

        private void qrgenbutton_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrgen = new QRCodeGenerator();
            QRCodeData infos = qrgen.CreateQrCode(infoslabel.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode gcode = new QRCode(infos);
            qrpicbox.Image = gcode.GetGraphic(10);
        }

        private void qrpicbox_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
