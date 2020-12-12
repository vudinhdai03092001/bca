using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer.Interface;
using doann.businesslayer;
using doann.Entities;

namespace doann.presenation
{
   public class frmNCC
    {
        private INCC_BLL spDLL = new NCC_BLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN NHA CUNG CAP   ");
            NCC sp = new NCC();
            Console.Write("Nhap ten nha cung cap:"); sp.Tenncc = Console.ReadLine();
            Console.Write(" Nhap dia chi:"); sp.Diachi= Console.ReadLine();
            Console.Write(" Nhap so dien thoai:"); sp.Sdt = int.Parse(Console.ReadLine());
            


            spDLL.themncc(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN NHA CUNG CAP ");
            Console.WriteLine("\t" + "mancc" + "\t" + "tenncc" + "\t" + "diachi" + "\t" + "sđt" );
            List<NCC> list = spDLL.GetAllNCC();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Mancc + "\t" + sp.Tenncc + "\t" + sp.Diachi+ "\t" + sp.Sdt);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN NHA CUNG CAP");
            List<NCC> list = spDLL.GetAllNCC();
            string ma;
            Console.Write("Nhap ma nha cung cap ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mancc == ma) break;

            if (i < list.Count)
            {
                NCC sp = new NCC(list[i]);
                Console.Write("nhap ten nha cung cap: ");
                string tnc = Console.ReadLine();
                if (tnc != "") sp.Tenncc = tnc;
                Console.Write("Nhap dia chi:");
                string dc = Console.ReadLine();
                if (dc != "") sp.Diachi = dc;
                Console.Write("nhap so dien thoai:");
                int dt = int.Parse(Console.ReadLine());
                sp.Sdt = dt;
               


                spDLL.suancc(sp);
            }
            else
            {
                Console.WriteLine("Khong ton tai ma hóa đơn này nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN NHA CUNG CAP ");
            List<NCC> list = spDLL.GetAllNCC();
            string ma;
            Console.Write("Nhap ma hoa don ban can xoa:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mancc == ma) break;

            if (i < list.Count)
            {
                NCC b = new NCC(list[i]);
                spDLL.xoancc(b);
            }
            else
            {
                Console.WriteLine("Khong ton tai nha cung cap nay");
            }
        }
        public void Hientimkiem()
        {
            Console.Clear();
            Console.WriteLine("HIEN THONG TIN TIM KIEM");
            List<NCC> list = spDLL.GetAllNCC();
            string ma;
            Console.Write("Nhap ma nha cung cap can hien thi:");
            ma = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mancc == ma) break;
            if (i < list.Count)
            {

                NCC b = new NCC(list[i]);
                spDLL.Hientimkiem(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma nha cung cap can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "mancc" + "\t" + "tenncc" + "\t" + "diachi" + "\t" + "sđt ");
            foreach (var sp in spDLL.GetAllNCC())
                if (sp.Mancc.Contains(ma))
                    Console.WriteLine("\t" + sp.Mancc + "\t" + sp.Tenncc + "\t" + sp.Diachi + "\t" + sp.Sdt);
            Console.ReadLine();
        }
    }
}
