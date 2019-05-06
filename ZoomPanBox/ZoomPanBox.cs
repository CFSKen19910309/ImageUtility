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
        Bitmap m_Bitmap = null;
        double m_Scale = 1.0;
        int m_PanX = 0;
        int m_PanY = 0;

        public ZoomPanBox()
        {
            InitializeComponent();
        }

        public bool LoadImage(Bitmap f_Image)
        {
            try
            {
                m_Bitmap = new Bitmap(f_Image);
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show($"LoadImage Input Format Error: {Ex.Message}");
                return false;
            }
            return true;
        }
        private void FitImageToScreen()
        {
            ZoomImgToFitScreen();
            PanImgToCenter();
        }
        private void ZoomImgToFitScreen()
        {
            double t_HeightScale = this.ClientSize.Height / m_Bitmap.Height;
            double t_WidthScale = this.ClientSize.Width / m_Bitmap.Width;
            if(t_HeightScale < t_WidthScale)
            {
                m_Scale =  t_HeightScale;
            }
            m_Scale = t_WidthScale;
        }
        private void PanImgToCenter()
        {
            m_PanX = (int)((this.ClientSize.Width - m_Scale * m_Bitmap.Width ) / 2);
            m_PanY = (int)((this.ClientSize.Height - m_Scale * m_Bitmap.Height) / 2);
        }

        private void ZoomPanBox_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void ZoomPanBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics t_Graphics = this.CreateGraphics() ;
            t_Graphics.Clear(Color.White);
            Size t_Rect = this.Size;
            if (m_Bitmap == null)
            {
                t_Graphics.DrawEllipse(Pens.Red, new Rectangle(t_Rect.Width / 4, t_Rect.Height / 4, t_Rect.Width / 2, t_Rect.Height / 2));
                StringFormat stringFormat = new StringFormat();
                stringFormat.Alignment = StringAlignment.Center;
                stringFormat.LineAlignment = StringAlignment.Center;
                t_Graphics.DrawString("No Picture Loading", new Font("Arial", 20), Brushes.Black, new Rectangle(t_Rect.Width / 4, t_Rect.Height / 4, t_Rect.Width / 2, t_Rect.Height / 2), stringFormat);
            }
            else
            {
                t_Graphics.ScaleTransform((float)m_Scale, (float)m_Scale);
                t_Graphics.DrawImage(m_Bitmap, 0, 0, m_Bitmap.Width, m_Bitmap.Height, );
            }
            t_Graphics.Dispose();
           
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
