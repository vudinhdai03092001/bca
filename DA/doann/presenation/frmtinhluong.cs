using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer.Interface;
using doann.businesslayer;
using doann.Entities;

namespace doann.presenation
{
  public  class frmtinhluong
    {
        private     ItinhluongBLL spDLL = new tinhluongBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN TINH LUONG  ");
            tinhluong sp = new tinhluong();
            Console.Write(" Nhap so ngay lam viec:"); sp.Songaylv =float.Parse( Console.ReadLine());
            Console.Write(" Nhap thuong :"); sp.Thuong =double.Parse( Console.ReadLine());
            Console.Write(" Nhap luong co ban:"); sp.Luongcoban =double.Parse( Console.ReadLine());
           
            spDLL.themtinhluong(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN BANG LUONG");
            Console.WriteLine("\t" + "matl" + "\t" + "songaylamviec" + "\t" + "thuong" + "\t\t" + "luongcb" + "\t\t" + "thanhtien");
            List<tinhluong> list = spDLL.GetAlltinhluong();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Matl + "\t" + sp.Songaylv + "\t\t" + sp.Thuong + "\t\t" + sp.Luongcoban+ "\t\t" + sp.Thanhtien );
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN BANG LUONG");
            List<tinhluong> list = spDLL.GetAlltinhluong();
            string ma;
            Console.Write("Nhap ma bang luong can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Matl == ma) break;

            if (i < list.Count)
            {
                tinhluong sp = new tinhluong(list[i]);
                Console.Write("Nhap thuong:");
                double nt =double.Parse( Console.ReadLine());
                if (nt >=0) sp.Thuong= nt;
                Console.Write("Nhap luong co ban:");
                double cb = double.Parse(Console.ReadLine());
                if (cb >=0) sp.Luongcoban = cb;
               


                spDLL.suatinhluong(sp);
            }
            else
            {
                Console.WriteLine("Khong co bang luong ");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN BANG LUONG ");
            List<tinhluong> list = spDLL.GetAlltinhluong();
            string ma;
            Console.Write("Nhap ma bang luong :");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Matl == ma) break;

            if (i < list.Count)
            {
                tinhluong b = new tinhluong(list[i]);
                spDLL.xoatinhluong(b);
            }
            else
            {
                Console.WriteLine("Khong co bang luong ");
            }
        }
        public void Hientimkiem()
        {
            Console.Clear();
            Console.WriteLine("HIEN THONG TIN TIM KIEM");
            List<tinhluong> list = spDLL.GetAlltinhluong();
            string ma;
            Console.Write("Nhap ma hoa don ban can hien thi:");
            ma = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Matl== ma) break;
            if (i < list.Count)
            {

                tinhluong b = new tinhluong(list[i]);
                spDLL.Hientimkiem(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma bang luong can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "matl" + "\t" + "songaylv" + "\t" + "thuong" + "\t" + "luongcoban " + "\t" + "thanhtien" );
            foreach (var sp in spDLL.GetAlltinhluong())
                if (sp.Matl.Contains(ma))
                    Console.WriteLine("\t" + sp.Matl + "\t" + sp.Songaylv + "\t" + sp.Thuong + "\t" + sp.Luongcoban + "\t" + sp.Thanhtien);
            Console.ReadLine();
        }
    }
}
                        