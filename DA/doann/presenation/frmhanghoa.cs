using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer.Interface;
using doann.Entities;
using doann.businesslayer;

namespace doann.presenation
{
  public   class frmhanghoa
    {
        private IhanghoaBLL spDLL = new hanghoaBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN HANG HOA   ");
            hanghoa sp = new hanghoa();
            Console.Write("Nhap ten hang :"); sp.Tenhang = Console.ReadLine();
            Console.Write("Nhap so luong nhap :"); sp.Slnhap = int.Parse(Console.ReadLine());
            Console.Write("Nhap so luong hien co :"); sp.Slhienco = int.Parse(Console.ReadLine());
            spDLL.themhanghoa(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN HANG HOA");
            Console.WriteLine("\t" + "mahh" + "\t" + "tenhang" + "\t" + "soluongnhap" + "\t" + "Soluonghienco");
            List<hanghoa> list = spDLL.GetAllhanghoa();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Mahang + "\t" + sp.Tenhang + "\t" + sp.Slnhap + "\t" + sp.Slhienco );
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HANG HOA");
            List<hanghoa> list = spDLL.GetAllhanghoa();
            string ma;
            Console.Write("Nhap ma hoa don ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == ma) break;

            if (i < list.Count)
            {
                hanghoa sp = new hanghoa(list[i]);
                Console.Write("ten hang:");
                string th = Console.ReadLine();
                sp.Tenhang = th;
                Console.Write("Nhap so luong nhap:");
                int sln = int.Parse(Console.ReadLine());
                if (sln > 0) sp.Slnhap = sln;
                Console.Write("Nhap so luong hien co:");
                int slhc = int.Parse(Console.ReadLine());
                if (slhc > 0) sp.Slhienco = slhc;
                spDLL.suahanghoa(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hang hoa nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HANG HOA ");
            List<hanghoa> list = spDLL.GetAllhanghoa();
            string ma;
            Console.Write("Nhap ma hoa don  can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == ma) break;

            if (i < list.Count)
            {
                hanghoa b = new hanghoa(list[i]);
                spDLL.xoahanghoa(b);
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
            List<hanghoa> list = spDLL.GetAllhanghoa();
            string ma;
            Console.Write("Nhap ma hang can hien thi:");
            ma = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == ma) break;
            if (i < list.Count)
            {

                hanghoa b = new hanghoa(list[i]);
                spDLL.Hientimkiem(b);
            }
        }
            public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma hang hoa can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mahh" + "\t" + "ten hang hoa" + "\t" + "soluongnhap" + "\t" + "Soluonghienco");
            foreach (var sp in spDLL.GetAllhanghoa())
                if (sp.Mahang.Contains(ma))
                    Console.WriteLine("\t" + sp.Mahang + "\t" + sp.Tenhang + "\t" + sp.Slnhap+ "\t" + sp.Slhienco );
            Console.ReadLine();
        }
    }
}
