using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using doann.Entities;
//using System.Threading.tasks;
//using doann.Utility;
using doann.DataAccessLayer.Interface;

namespace doann.DataAccessLayer
{
    class hoadonbanDAL :IhoadonbanDAL
    {
        private string txtfile = "Data/hoadonban.txt";
        //Lấy toàn bộ dữ liệu có trong file hoadonban.txt đưa vào một danh sách 
        public List<hoadonban> GetAllhoadonban()
        {
            List<hoadonban> list = new List<hoadonban>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    
                    string[] a = s.Split('#');
                    list.Add(new hoadonban(a[0], DateTime.Parse(a[1]), double.Parse(a[2])));
                }
                s = fread.ReadLine();
            }
            fread.Close(); 
            return list;
        }
        //Chèn một bản ghi hóa đơn bán vào tệp
        public void themhoadonban(hoadonban hd)
        {
            string mahdb = DateTime.Now.ToString("tt");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write( mahdb +"#"+hd.Giaban+"#"+hd.Ngayban);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void update(List<hoadonban> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Mahdb + "#" + list[i].Giaban + "#" + list[i].Ngayban);
            fwrite.Close();
        }
    }
}

