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
    }
}
