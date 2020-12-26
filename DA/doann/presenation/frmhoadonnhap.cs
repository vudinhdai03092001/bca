using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer.Interface;
using doann.businesslayer;
using doann.Entities; 

namespace doann.presenation
{
  public  class frmhoadonnhap
    {
        private IhoadonnhapBLL spDLL = new hoadonnhapBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN HOA DON NHAP   ");
            hoadonnhap sp = new hoadonnhap();          
            Console.Write(" Nhap nhan vien giao:"); sp.Nvgiao = Console.ReadLine();
            Console.Write(" Nhap ma nhan vien nhap:"); sp.Manvnhap =Console.ReadLine();
            Console.Write(" Nhap ngay nhan:"); sp.Ngaynhan =DateTime.Parse( Console.ReadLine()); 
            Console.Write(" Nhap gia nhap:"); sp.Gianhap =double.Parse( Console.ReadLine());         
            spDLL.themhoadonnhap(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN HOA DON NHAP");
            Console.WriteLine("\t" + "mahdn" + "\t" + "nhanviengiao" + "\t" + "manhanviennhap"+"\t"+"ngaynhan"+"\t\t"+"gianhap");
            List<hoadonnhap> list = spDLL.GetAllhoadonnhap();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Mahdn + "\t" + sp.Nvgiao + "\t\t" + sp.Manvnhap+"\t\t" + sp.Ngaynhan + "\t" + sp.Gianhap);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA DON NHAP");
            List<hoadonnhap> list = spDLL.GetAllhoadonnhap();
            string ma;
            Console.Write("Nhap ma hoa don ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdn == ma) break;

            if (i < list.Count)
            {
                hoadonnhap sp = new hoadonnhap(list[i]);               
                Console.Write("nhap nhan vien giao: ");
                string nvn = Console.ReadLine();
                if (nvn != "") sp.Nvgiao= nvn;
                Console.Write("Nhap ma nhan vien nhap:");
                string manv = Console.ReadLine();
                if (manv != "") sp.Manvnhap = manv;
                Console.Write("nhap gia nhap:");
                double gb = double.Parse(Console.ReadLine());
                sp.Gianhap = gb;
                Console.Write("Nhap ngay nhap:");
                DateTime nn = DateTime.Parse(Console.ReadLine());
                sp.Ngaynhan = nn;
                spDLL.suahoadonnhap(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hóa đơn này nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HOA DON NHAP ");
            List<hoadonnhap> list = spDLL.GetAllhoadonnhap();
            string ma;
            Console.Write("Nhap ma hoa don ban can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdn == ma) break;

            if (i < list.Count)
            {
                hoadonnhap b = new hoadonnhap(list[i]);
                spDLL.xoahoadonnhap(b);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void Hientimkiem()
        {
            Console.Clear();
            Console.WriteLine("HIEN THONG TIN TIM KIEM");
            List<hoadonnhap> list = spDLL.GetAllhoadonnhap();
            string ma;
            Console.Write("Nhap ma hoa don nhap can hien thi:");
            ma = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdn == ma) break;
            if (i < list.Count)
            {

                hoadonnhap b = new hoadonnhap(list[i]);
                spDLL.Hientimkiem(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma hoa don  can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mahdn" + "\t" + "nhanviengiao" + "\t" + "manhanviennhap" + "\t" + "ngaynhap "+ "\t" + "gianhap");
            foreach (var sp in spDLL.GetAllhoadonnhap())
                if (sp.Mahdn.Contains(ma))
                    Console.WriteLine("\t" + sp.Mahdn + "\t" + sp.Nvgiao+ "\t" + sp.Manvnhap + "\t" + sp.Ngaynhan + "\t" + sp.Gianhap);
            Console.ReadLine();
        }
    }
}
