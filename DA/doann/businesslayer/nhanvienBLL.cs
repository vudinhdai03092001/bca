using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using doann.DataAccessLayer.Interface;
using doann.DataAccessLayer;
using doann.businesslayer.Interface;


namespace doann.businesslayer
{
    class nhanvienBLL : InhanvienBLL
    {
        private InhanvienDAL lhnv = new nhanvienDAL();
        //Thực thi các yêu cầu
        public List<nhanvien> GetAllnhanvien()
        {
            return lhnv.GetAllnhanvien();
        }
        public void themnhanvien(nhanvien nv)
        {
            if (nv.Mannv != "" && nv.Gioitinh != "")
            {
                lhnv.themnhanvien(nv);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void xoanhanvien(nhanvien xnv)
        {
            int i;
            List<nhanvien> list = lhnv.GetAllnhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mannv == xnv.Mannv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhnv.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suanhanvien(nhanvien nv)
        {
            int i;
            List<nhanvien> list = lhnv.GetAllnhanvien();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mannv == nv.Mannv) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(nv);
                lhnv.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<nhanvien> Timnhanvien(nhanvien nv)
        {
            List<nhanvien> list = lhnv.GetAllnhanvien();
            List<nhanvien> kq = new List<nhanvien>();
            //Voi gai tri ngam dinh ban dau
            if (nv.Mannv == null && nv.Tennv == null && nv.Gioitinh == null && nv.Loainv == null && nv.Ngaysinh == null && nv.Ngayvaolv == null)
            {
                kq = list;
            }
            //Tim theo ho ten
            if (nv.Mannv != null)
            {

                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Mannv.IndexOf(nv.Mannv) >= 0)
                    {
                        kq.Add(new nhanvien(list[i]));
                    }
            }

            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }

        public void Hientimkiem(nhanvien nv)
        {
            int i;
            List<nhanvien> list = lhnv.GetAllnhanvien();
            Console.WriteLine("manhanvien" + "\t" + "tennhanvien" + "\t" + "gioitinh" + "\t" + "loainhanvien" + "\t" + "ngaysinh" + "\t" + "ngayvaolamviec");
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mannv == nv.Mannv)
                    Console.WriteLine(nv.Mannv + "\t" + nv.Tennv + "\t\t" + nv.Gioitinh + "\t\t" + nv.Loainv + "\t\t" + nv.Ngaysinh + "\t\t" + nv.Ngayvaolv);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}
