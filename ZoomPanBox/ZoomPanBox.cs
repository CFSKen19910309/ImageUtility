using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomPanBox
{
    public partial class ZoomPanBox: UserControl
    {
        Bitmap m_ShowBitmap;
        public ZoomPanBox()
        {
            InitializeComponent();
            
        }

        private void ZoomPanBox_MouseMove(object sender, MouseEventArgs e)
        {

        }
        private void ZoomPanBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics t_Graphics = this.CreateGraphics() ;
            t_Graphics.Clear(Color.White);
            Size t_Rect = this.Size;
            if (m_ShowBitmap == null)
            {
                t_Graphics.DrawEllipse(Pens.Red, new Rectangle(t_Rect.Width / 4, t_Rect.Height / 4, t_Rect.Width / 2, t_Rect.Height / 2));
                System.Threading.Thread.Sleep(20);
            }
           
        }

        private void ZoomPanBox_MouseHover(object sender, EventArgs e)
        {

        }

        private void ZoomPanBox_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
