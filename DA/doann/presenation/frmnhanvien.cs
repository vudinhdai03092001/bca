﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.businesslayer.Interface;
using doann.businesslayer;
using doann.Entities;


namespace doann.presenation
{
   public class frmnhanvien
    {
        private InhanvienBLL spDLL = new nhanvienBLL();
        public void Nhap()
        {
            Console.Clear();
            Console.WriteLine("           NHAP THONG TIN NHAN VIEN   ");
            nhanvien sp = new nhanvien();
            Console.Write(" Nhap ten nhan vien:"); sp.Tennv = Console.ReadLine();
            Console.Write(" Nhap gioi tinh :"); sp.Gioitinh= Console.ReadLine();
            Console.Write(" Nhap loai nhan vien:"); sp.Loainv= Console.ReadLine();
            Console.Write(" Nhap ngay sinh:"); sp.Ngaysinh = DateTime.Parse(Console.ReadLine());
            Console.Write(" Nhap ngay vao lam viec:"); sp.Ngayvaolv = DateTime.Parse(Console.ReadLine());



            spDLL.themnhanvien(sp);
        }
        public void Hien()
        {
            Console.Clear();
            Console.WriteLine("                    HIEN THI THONG TIN NHAN VIEN");
            Console.WriteLine("\t" + "manv" + "\t" + "tennv" + "\t" + "gioitinh" + "\t" + "loainv" + "\t\t" + "ngaysinh"+"\t\t\t"+"ngayvaolv");
            List<nhanvien> list = spDLL.GetAllnhanvien();
            foreach (var sp in list)
                Console.WriteLine("\t" + sp.Mannv + "\t" + sp.Tennv + "\t" + sp.Gioitinh + "\t\t" + sp.Loainv + "\t\t" + sp.Ngaysinh+"\t\t"+sp.Ngayvaolv);
        }
        public void Sua()
        {
            Console.Clear();
            Console.WriteLine("SUA THONG TIN NHAN VIEN");
            List<nhanvien> list = spDLL.GetAllnhanvien();
            string ma;
            Console.Write("Nhap ma hoa don ban can sua:");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mannv == ma) break;

            if (i < list.Count)
            {
                nhanvien sp = new nhanvien(list[i]);
            
                Console.Write("nhap nhan vien : ");
                string nvn = Console.ReadLine();
                if (nvn != "") sp.Tennv = nvn;
                Console.Write("Nhap gioi tinh:");
                string gt = Console.ReadLine();
                if (gt != "") sp.Gioitinh = gt;
                Console.Write("Nhap loai nhan vien:");
                string lnv = Console.ReadLine();

                if (lnv != "") sp.Loainv= lnv;
                Console.Write("nhap ngay sinh:");
                DateTime ns = DateTime.Parse(Console.ReadLine());
                sp.Ngaysinh = ns;
                Console.Write("Nhap vao lam viec:");
                DateTime nlv = DateTime.Parse(Console.ReadLine());
                sp.Ngayvaolv = nlv;


                spDLL.suanhanvien(sp);
            }
            else
            {
                Console.WriteLine("Khong co nhan vien nay");
            }
        }
        public void xoa()
        {
            Console.Clear();
            Console.WriteLine("XOA THONG TIN NHAN VIEN  ");
            List<nhanvien> list = spDLL.GetAllnhanvien();
            string ma;
            Console.Write("Nhap ma nhan vien can xoa :");
            ma = Console.ReadLine();
            int i = 0;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mannv == ma) break;

            if (i < list.Count)
            {
                nhanvien b = new nhanvien(list[i]);
                spDLL.xoanhanvien(b);
            }
            else
            {
                Console.WriteLine("Khong co nhan vien nay ");
            }
        }
        public void Hientimkiem()
        {
            Console.Clear();
            Console.WriteLine("HIEN THONG TIN TIM KIEM");
            List<nhanvien> list = spDLL.GetAllnhanvien();
            string ma;
            Console.Write("Nhap ma nhan vien can hien thi:");
            ma = Console.ReadLine();
            int i;
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mannv == ma) break;
            if (i < list.Count)
            {

                nhanvien b = new nhanvien(list[i]);
                spDLL.Hientimkiem(b);
            }
        }
        public void timkiem()
        {
            Console.Clear();
            Console.Write("Nhap ma nhan vien can tim :");
            string ma = Console.ReadLine();
            Console.WriteLine("                    HIEN THI THONG TIN TIM KIEM");
            Console.WriteLine("\t" + "manv" + "\t" + "tennhanvien" + "\t" + "gioitinh" + "\t" + "loainhanvien " + "\t" + "ngaysinh"+"\t"+"ngayvaolv");
            foreach (var sp in spDLL.GetAllnhanvien())
                if (sp.Mannv.Contains(ma))
                    Console.WriteLine("\t" + sp.Mannv + "\t" + sp.Tennv + "\t" + sp.Gioitinh + "\t" + sp.Loainv + "\t" + sp.Ngaysinh+"\t"+sp.Ngayvaolv);
            Console.ReadLine();
        }
    }
}
       