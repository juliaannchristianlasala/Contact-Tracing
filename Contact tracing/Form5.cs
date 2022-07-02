using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using ZXing.Windows.Compatibility;

namespace Contact_tracing
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterdatainfos;
        VideoCaptureDevice capturedataform;

        private void Form5_Load(object sender, EventArgs e)
        {
            filterdatainfos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo devicecapture in filterdatainfos) 
            camcombox.Items.Add(devicecapture.Name);

            camcombox.SelectedIndex = 0;
            capturedataform = new VideoCaptureDevice();
        }

        private void StScanButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allow to use your camera");
            capturedataform = new VideoCaptureDevice(filterdatainfos[camcombox.SelectedIndex].MonikerString);
            capturedataform.NewFrame += new NewFrameEventHandler(capturedataform_NewFrame);
            capturedataform.Start();
            ScanTimer.Start();
        }

        private void capturedataform_NewFrame(object sender, NewFrameEventArgs newscanner)
        {
            ScanPicbox.Image=(Bitmap)newscanner.Frame.Clone();
        }

        private void ScanTimer_Tick(object sender, EventArgs e)
        {
            if (ScanPicbox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)ScanPicbox.Image);
                if (result != null)
                {
                    ScanInfoLabel.Text = result.ToString();
                    ScanTimer.Stop();
                    StreamWriter file = new StreamWriter(@"C:\Users\JULIA-ANN\source\repos\Contact Tracing QR Code\" + "Contact Tracing" + ".txt");
                    file.WriteLine(result.ToString());
                    file.Close();
                }
            }
        }
    }
}
