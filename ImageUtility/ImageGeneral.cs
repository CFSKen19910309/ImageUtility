using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------(懂了之後砍掉)---------//
//Emgu.CV.Structure 
//Emgu實際上是namespace，CV與Structure也是
//在這邊使用純粹只是要讓Code看起來更簡潔
//如果沒有就要這樣打     Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> t_Image
//有打這行的話會像這樣   Emgu.CV.Image<Bgr, byte> t_Image
//--------------------------------//
using Emgu.CV.Structure;


namespace ImageUtility
{
    public class ImageGeneral
    {
        #region LoadImageFile
        //---------(懂了之後砍掉)---------//
        //井號:為告知編譯器這裡有個東西要他先處理，region就只是一個告訴編譯這是不用處理的部分，純粹顯示上比較順眼
        //以下為命令組合
        //#region (給個名稱)
        // .
        // .
        // .
        //#endregion
        //---
        //以下兩個LoadImageFile的Function Name為泛型(Generics)
        //意思是在同一個Class中使用一樣的Function Name，但是代不同的參數
        //---
        //LoadImageFile泛型1
        //--------------------------------//
        public object LoadImageFile(string f_Path)
        {
            //---------(懂了之後砍掉)---------//
            //在C# 有分為Value Object與 reference Object。只有reference Object可以為null，但使用時一定要new一個物件。
            //--------------------------------//
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> t_Image = null;
            //---------(懂了之後砍掉)---------//
            //try ... catch(Exception ...)此為避免軟體突然Crash，所以要在catch的地方Handle錯誤
            //--------------------------------//
            try
            {
                t_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(f_Path);
            }
            catch(Exception Ex)
            {
                string Error = Ex.Message;
            }
            //---------(懂了之後砍掉)---------//
            //Function的Return回傳的是object物件，此為C# 所有物件的父節點，所有的子節點都是繼承於他。(可以去看物件-繼承的觀念)
            //--------------------------------//
            return t_Image;
        }
        //---------(懂了之後砍掉)---------//
        //LoadImageFile泛型2
        //--------------------------------//
        public object LoadImageFile(string[] f_Path)
        {
            //---------(懂了之後砍掉)---------//
            //List<...> ...為一種容器，用法很特定，所以要用時網路找找吧
            //--------------------------------//
            List<object> t_object = new List<object>();
            foreach (string t_Path in f_Path)
            {
                t_object.Add(LoadImageFile(t_Path));
            }
            return t_object;
        }
        #endregion
        public object LoadImageFolder(string f_Path)
        {
            //---------(懂了之後砍掉)---------//
            //取得Windows系統的資料夾方式。
            //--------------------------------//
            bool t_IsFolderExist = System.IO.Directory.Exists(f_Path);
            string[] t_FilesPath = null;
            List<object> t_Image = new List<object>();
            if (t_IsFolderExist == true)
            {
                t_FilesPath = System.IO.Directory.GetFiles(f_Path);
            }
            if(t_FilesPath != null)
            {
                foreach(string t_FilePath in t_FilesPath)
                {
                    t_Image.Add(LoadImageFile(t_FilePath));
                }
            }
            return t_Image;
        }

    }
}
