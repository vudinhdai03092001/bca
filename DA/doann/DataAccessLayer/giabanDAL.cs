using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using System.IO;
using doann.DataAccessLayer.Interface;


namespace doann.DataAccessLayer
{
    class giabanDAL :IgiabanDAL

    {
        private string txtfile = "Data/giaban.txt";
        //Lấy toàn bộ dữ liệu có trong file giaban.txt đưa vào một danh sách 
        public List<giaban> GetAllgiaban()
        {
            List<giaban> list = new List<giaban>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {

                    string[] a = s.Split('#');
                    list.Add(new giaban(a[0], double.Parse(a[1]), a[2]));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi giá bán vào tệp
        public void themgiaban(giaban gb)
        {
            string magiaban = DateTime.Now.ToString("tt");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(magiaban + "#" + gb.Magiaban + "#" + gb.Gia + "#" + gb.Donvitinh );
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void update(List<giaban> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Magiaban+ "#" + list[i].Gia + "#" + list[i].Donvitinh );
            fwrite.Close();
        }
    }
}

