using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer;
using doann.Entities;
using doann.businesslayer.Interface;
using doann.Utility;
namespace doann.presenation
{
   public class frmgiaban
    {
        private IgiabanBLL spDLL = new giabanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("NHAP THONG TIN GIA BAN");
            giaban sp = new giaban();
            Console.Write("Nhap gia ban :"); sp.Gia = double.Parse(Console.ReadLine());
            Console.Write("don vi tinh:"); sp.Donvitinh = Console.ReadLine();

            spDLL.themgiaban(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("               HIEN THI THONG TIN GIA BAN");
            Console.WriteLine("\t" + "magiaban" + "\t\t" + "giá" + "\t\t" + "donvitinh");
            List<giaban> list = spDLL.GetAllgiaban();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Magiaban + "\t\t\t" + sp.Gia + "\t\t" + sp.Donvitinh);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN GIA BAN");
            List<giaban> list = spDLL.GetAllgiaban();
            
            string ma;
            Console.Write("Nhap ma hoa don ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == ma) break;


            if (i < list.Count)
            {
                giaban sp = new giaban(list[i]);               
                Console.Write("Gia moi:");
                int gia = int.Parse(Console.ReadLine());
                if (gia > 0) sp.Gia = gia;                
                Console.Write("Nhap đơn vị cần sửa:");
                string donvi = Console.ReadLine();
                if (!string.IsNullOrEmpty(donvi)) sp.Donvitinh = donvi;
                spDLL.suagiaban(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN GIA BAN ");
            List<giaban> list = spDLL.GetAllgiaban();
            string ma;
            Console.Write("Nhap ma hang can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == ma) break;

            if (i < list.Count)
            {
                giaban   b = new giaban(list[i]);
                spDLL.xoagiaban(b);
            }
        }       
        public void Hientimkiem()
        {
            Console.Clear();
            Console.WriteLine("HIEN THONG TIN TIM KIEM");
            List<giaban> list = spDLL.GetAllgiaban();
            string ma;
            Console.Write("Nhap ma hang can hien thi:");
            ma = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == ma) break;
            if (i < list.Count)
            {

                giaban b = new giaban(list[i]);
                spDLL.Hientimkiem(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma hang can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("        HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mahang" + "\t\t" + "gia" + "\t\t" + "donvi");
            foreach (var s in spDLL.GetAllgiaban())
                if (s.Magiaban.Contains(ma))
                    Console.WriteLine("\t" + s.Magiaban + "\t\t" + s.Gia + "\t\t" + s.Donvitinh);
            Console.ReadLine();
        }
    }
}
