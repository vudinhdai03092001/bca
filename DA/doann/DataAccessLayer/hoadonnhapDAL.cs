using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using doann.Entities;
using doann.DataAccessLayer.Interface;


namespace doann.DataAccessLayer
{
    class hoadonnhapDAL:IhoadonnhapDAL
    {
        private string txtfile = "Data/hoadonnhap.txt";
        //Lấy toàn bộ dữ liệu có trong file hoadonnhap.txt ađưa vào một danh sách 
        public List<hoadonnhap> GetAllhoadonnhap()
        {
            List<hoadonnhap> list = new List<hoadonnhap>();
            StreamReader fread = File.OpenText(txtfile);
            string s = fread.ReadLine();
            while (s != null)
            {
                if (s != "")
                {

                    string[] a = s.Split('#');
                    list.Add(new hoadonnhap(a[0],a[1],a[2], DateTime.Parse(a[3]), double.Parse(a[4])));
                }
                s = fread.ReadLine();
            }
            fread.Close();
            return list;
        }
        //Chèn một bản ghi hóa đơn nhập vào tệp
        public void themhoadonnhap(hoadonnhap hdn)
        {
            string mahdn = DateTime.Now.ToString("tt");
            StreamWriter fwrite = File.AppendText(txtfile);
            fwrite.WriteLine();
            fwrite.Write(mahdn + "#" + hdn.Mahdn + "#" + hdn.Nvgiao + "#" + hdn.Manvnhap + "#" +hdn.Ngaynhan+ "#" + hdn.Gianhap);
            fwrite.Close();
        }
        //Cập nhật lại danh sách vào tệp        
        public void Update(List<hoadonnhap> list)
        {
            StreamWriter fwrite = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                fwrite.WriteLine(list[i].Mahdn + "#" + list[i].Nvgiao + "#" + list[i].Manvnhap + "#" + list[i].Ngaynhan + "#" + list[i].Gianhap);
            fwrite.Close();
        }
    }
}


    

