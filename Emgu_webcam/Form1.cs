using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Emgu_webcam
{
    public partial class Form1 : Form
    {
        Image<Bgr, Byte> currentImage;
        Capture webcam = new Capture();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += new EventHandler(Camera_View);
        }

        private void Camera_View(object sender, EventArgs e)
        {
            currentImage = webcam.QueryFrame().ToImage<Bgr, Byte>();
            pictureBox1.Image = currentImage.Bitmap;
        }
    }
}
