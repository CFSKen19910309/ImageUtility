using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUtility
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panAndZoomPictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void MenuStrip_OpenImgFile_Click(object sender, EventArgs e)
        {
            ImageGeneral t_ImageGeneral = new ImageGeneral();
            object t_object = t_ImageGeneral.LoadImageFile(@"C:\Users\FD_Kenzo_NB\Desktop\Iphone Photo\576825840.265911.jpg");
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> t_Image = t_object as Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>;
        }
    }
}
