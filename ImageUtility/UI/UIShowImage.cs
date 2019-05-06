using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUtility.UI
{
    public partial class UIShowImage : Form
    {
        public UIShowImage()
        {
            InitializeComponent();
        }

        private void ToolStripBtn_OepnImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog t_OpenFileDialog = new OpenFileDialog();
            if(t_OpenFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> t_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(t_OpenFileDialog.FileName);
            ZoomPanBox.LoadImage(t_Image.Bitmap);
        }
    }
}
