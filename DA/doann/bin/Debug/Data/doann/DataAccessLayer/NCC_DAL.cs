using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using System.IO;
using doann.DataAccessLayer.Interface;

namespace doann.DataAccessLayer
{
    class NCC_DAL:INCC_DAL
    {
        private string txtfile = "Data/NCC.txt";
        //lay du lieu tu nhà cung cấp dua vao danh sach

        public List<NCC> GetAllNCC()
        {
            List<NCC> list = new List<NCC>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    string[] a = s.Split('#');
                    list.Add(new NCC(a[0], a[1],a[2],int.Parse(a[3])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }

        //Chèn một bản ghi nhà cung cấp vào tệp
        public void themNCC(NCC ncc)
        {
            string mancc = DateTime.Now.ToString("ss");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mancc  + "#" + ncc.Tenncc + "#" + ncc.Diachi+"#"+ncc.Sdt);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void update(List<NCC> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Mancc + "#" + list[i].Tenncc + "#" + list[i].Diachi + "#" + list[i].Sdt);
            fwrite.Close();
        }
    }
}
