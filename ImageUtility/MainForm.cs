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
            //記得要打變數改成t_SaveFile
            SaveFileDialog saveFile = new SaveFileDialog();
            //這裡錯了因為沒有.img的副檔名，所以你可選擇
            //saveFile.Filter = ".img file (*.img)|*.img";
            saveFile.Filter = ".png file (*.png)|*.png|.jpeg file (*.jpeg)|*.jpeg";
            saveFile.FilterIndex = 1;
            //這個參數你要去看看在幹啥的。大概就是說你要不要每次跳出存圖對話框時，都要回到預設路徑
            //saveFile.RestoreDirectory = true;
            saveFile.RestoreDirectory = false;
            //你後面已經有ShowFialog()了，這裡不需要。這個Function意思是你要開啟一個視窗(用另外一個執行緒開，這樣你就可以兩個視窗同時存在(MainForm跟SaveDialog)
            //saveFile.ShowDialog();
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                //如果你是要儲存一般的文字檔案，那你就要先建立一個File，真實存在在PC中的檔案
                //那就要這樣給
                //用Stream做與檔案間的資料傳輸
                //剛剛在Dialog中已經有設定檔案名稱了，所以拿來用
                System.IO.StreamWriter t_StreamWriter = new System.IO.StreamWriter(saveFile.FileName);
                t_StreamWriter.WriteLine("abcd9-d");
                t_StreamWriter.Close();//牽扯到檔案操作時，一定要很小心，因為如果你不Close Stream的話，檔案會被鎖住

                //File.Create(saveFileDialog1.FileName);
                //這要怎麼用阿?因為FILE還沒有定義嗎

                //如果你要存圖
                //那就這樣
                //Emgu.CV.Image<Emgu.CV.Structure.Bgr,byte> t_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>("讀圖");
                //t_Image.Save("儲存名稱");
            }
        }

        private void MenuStrip_ShowImgMode_Click(object sender, EventArgs e)
        {
            ImageUtility.UI.UIShowImage t_UIShowImage = new UI.UIShowImage();
            //t_UIShowImage.TopLevel = false;
            //t_UIShowImage.Dock = DockStyle.Fill;
            //this.Controls.Add(t_UIShowImage);
            t_UIShowImage.Show();
        }
    }
}
