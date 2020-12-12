using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using doann.Entities;
using doann.DataAccessLayer.Interface;

namespace doann.DataAccessLayer
{
    class hanghoaDAL:IhanghoaDAL

    {
        private string txtfile = "Data/hanghoa.txt";
        //Lấy toàn bộ dữ liệu có trong file hanghoa.txt đưa vào một danh sách 
        public List<hanghoa> GetAllhanghoa()
        {
            List<hanghoa> list = new List<hanghoa>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {

                    string[] a = s.Split('#');
                    list.Add(new hanghoa(a[0], a[1],int.Parse (a[2]),int.Parse(a[3])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi hàng hóa vào tệp
        public void themhanghoa(hanghoa hh)
        {
            string mahang = DateTime.Now.ToString("tt");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahang + "#" + hh.Tenhang + "#" + hh.Slnhap + "#" + hh.Slhienco);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void update(List<hanghoa> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Mahang + "#" + list[i].Tenhang + "#" + list[i].Slnhap + "#" + list[i].Slhienco);
            fwrite.Close();
        }
    }
}
