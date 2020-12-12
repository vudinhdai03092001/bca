using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using System.IO;
using doann.DataAccessLayer.Interface;


namespace doann.DataAccessLayer
{
    class tinhluongDAL:ItinhluongDAL
    {
        private string txtfile = "Data/tinhluong.txt";
        //lay du lieu tu tính lương dua vao danh sach

        public List<tinhluong> GetAlltinhluong()
        {
            List<tinhluong> list = new List<tinhluong>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new tinhluong(a[0],float.Parse(a[1]),double.Parse(a[2]), double.Parse(a[3]),double.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi tinh luong vào tệp
        public void themtinhluong(tinhluong tl)
        {
            string matl = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(matl +"#" + tl.Songaylv + "#" + tl.Thuong+"#"+tl.Luongcoban+"#"+tl.Thanhtien);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void update(List<tinhluong> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Matl + "#" + list[i].Songaylv + "#" + list[i].Thuong + "#" + list[i].Luongcoban + "#" + list[i].Thanhtien);
            fwrite.Close();
        }
    }
}
