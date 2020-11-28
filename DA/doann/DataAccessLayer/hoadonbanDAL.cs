using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Utility;
using System.IO;
using doann.Entities;
using doann.DataAccessLayer.Interface;
using System.Text.RegularExpressions;

namespace doann.DataAccessLayer
{
    class hoadonbanDAL : IhoadonbanDAL
    {
        private string txtfile = "Data/hoadonban.txt";
        //Lấy toàn bộ dữ liệu có trong file SanPham.txt đưa vào một danh sách 
        public List<hoadonban> GetAllhoadonban()
        {
            List<hoadonban> list = new List<hoadonban>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = CongCu.CatXau(s);
                    string[] a = s.Split('#');
                    list.Add(new hoadonban(int.Parse(a[0]), DateTime.Parse(a[1]), double.Parse(a[2])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi học sinh vào tệp
        public void themhoadonban(hoadonban hd)
        {
            int maHDB = CongCu.TachSo(mahdb) + 1;
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write("hd" + mahdb + "#" + hd.ngayban+);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<hoadonban> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].mahdb + "#" + list[i].TenSanPham + "#" + list[i].DonGia);
            fwrite.Close();
        }
    }
}

