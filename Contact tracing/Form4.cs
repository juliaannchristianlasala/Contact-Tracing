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
        }

        private void qrgenbutton_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrgen = new QRCodeGenerator();
            QRCodeData infos = qrgen.CreateQrCode(qrgentxtbox.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode gcode = new QRCode(infos);
            qrpicbox.Image = gcode.GetGraphic(10);
        }
    }
}
