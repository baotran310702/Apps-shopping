using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace _20521110_TranQuocBao_TH2
{
    public partial class formSearchRecepts : Form
    {
        public formSearchRecepts()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void button1_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void formSearchRecepts_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            string[] s_containt=new string[20];
            int i = 0;
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                //cDevice.Items.Add(filterInfo.Name);
                s_containt[i] = filterInfo.Name;
                i++;   
            }
        }
        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }
                    int res = Int32.Parse(result.ToString());
                    showRecept(res.ToString());
                    this.Hide();
                }

            }

        }

        public void showRecept(string id)
        {
            formReport rc = new formReport(id);
            rc.ShowDialog();
            this.Hide();
        }

        private void logo_Label_Click(object sender, EventArgs e)
        {
            formMenu Form1 = new formMenu();
            Form1.Show();
            this.Hide();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            if(!String.IsNullOrEmpty(s))
            {
                showRecept(s);
            }
        }

        private void formSearchRecepts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            this.Hide();
        }
    }
}
