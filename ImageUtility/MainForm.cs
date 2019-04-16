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

        private void MenuStrip_SaveImgFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = ".img file (*.img)|*.img";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            saveFile.ShowDialog();
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //File.Create(saveFileDialog1.FileName);
                //這要怎麼用阿?因為FILE還沒有定義嗎
            }
        }
    }
}
