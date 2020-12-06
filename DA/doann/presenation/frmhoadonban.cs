using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer.Interface;
using doann.businesslayer;
using doann.Entities;

namespace doann.presenation
{
   public class frmhoadonban
    {
        private IhoadonbanBLL spDLL = new hoadonbanBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN HOA DON BAN   ");
            hoadonban sp = new hoadonban();
           
            Console.Write("Nhap ma hoa don ban:"); sp.Mahdb = Console.ReadLine();
            Console.Write("Nhap gia ban :"); sp.Giaban =double.Parse( Console.ReadLine());
            Console.Write(" Nhap ngay ban:"); sp.Ngayban = DateTime.Parse(Console.ReadLine());
           
            spDLL.themhoadonban(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN HOA DON BAN");
            Console.WriteLine("\t" + "mahdb" + "\t" + "giaban" + "\t" + "ngayban" );
            List<hoadonban> list = spDLL.GetAllhoadonban();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Mahdb+ "\t" + sp.Giaban + "\t" + sp.Ngayban );
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN HOA DON BAN");
            List<hoadonban> list = spDLL.GetAllhoadonban();
            string ma;
            Console.Write("Nhap ma hoa don ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdb == ma) break;

            if (i < list.Count)
            {
                hoadonban sp = new hoadonban(list[i]);
                Console.Write("Nhap ma hoa don ban:");
                string mahdb = Console.ReadLine();
                if (mahdb != "") sp.Mahdb = mahdb;
                Console.Write("gia ban:");
                double gb  =double.Parse( Console.ReadLine());
                sp.Giaban = gb;
                Console.Write("Nhap ngay ban:");
                DateTime nb = DateTime.Parse(Console.ReadLine());
                 sp.Ngayban = nb;
              
                
                spDLL.suahoadonban(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hóa đơn này nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN HOA DON BAN ");
            List<hoadonban> list = spDLL.GetAllhoadonban();
            string ma;
            Console.Write("Nhap ma hoa don ban can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdb == ma) break;

            if (i < list.Count)
            {
                hoadonban b = new hoadonban(list[i]);
                spDLL.xoahoadonban(b);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma san pham nay");
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma hoa don ban can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mahdb" + "\t" + "gia ban" + "\t" + "ngayban" );
            foreach (var sp in spDLL.GetAllhoadonban())
                if (sp.Mahdb.Contains(ma))
                    Console.WriteLine("\t" + sp.Mahdb + "\t" + sp.Giaban + "\t" + sp.Ngayban );
            Console.ReadLine();
        }
    }
}

    

