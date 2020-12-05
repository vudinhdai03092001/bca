using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using System.IO;
using doann.Utility;
using doann.DataAccessLayer.Interface;



namespace doann.DataAccessLayer
{
    class nhanvienDAL: InhanvienDAL
    {
        private string txtfile = "Data/nhanvien.txt";
        //lay du lieu tu nhân viên dua vao danh sach

        public List<nhanvien> GetAllnhanvien()
        {
            List<nhanvien> list = new List<nhanvien>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new nhanvien(a[0],a[1],a[2],a[3],DateTime.Parse(a[4]),DateTime.Parse(a[5])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi nhan viên vào tệp
        public void themnhanvien(nhanvien nv)
        {
            string manv = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(manv + "#" + nv.Mannv + "#"+nv.Tennv +"#"+ nv.Gioitinh + "#" + nv.Loainv+"#"+nv.Ngaysinh+"#"+nv.Ngayvaolv);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void update(List<nhanvien> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Mannv + "#" + list[i].Tennv + "#" + list[i].Gioitinh + "#" + list[i].Loainv + "#" + list[i].Ngaysinh+"#"+list[i].Ngayvaolv);
            fwrite.Close();
        }
    }
}
