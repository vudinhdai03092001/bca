using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.DataAccessLayer.Interface;
using doann.DataAccessLayer;
using doann.businesslayer.Interface;
using doann.Entities;

namespace doann.businesslayer
{
    class hoadonnhapBLL : IhoadonnhapBLL
    {
        private IhoadonnhapDAL lhdn = new hoadonnhapDAL();
        //Thực thi các yêu cầu
        public List<hoadonnhap> GetAllhoadonnhap()
        {
            return lhdn.GetAllhoadonnhap();
        }
        public void themhoadonnhap(hoadonnhap hdn)
        {
            if (hdn.Gianhap >0)
            {
                lhdn.themhoadonnhap(hdn);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void xoahoadonnhap(hoadonnhap mahdn)
        {
            int i;
            List<hoadonnhap> list = lhdn.GetAllhoadonnhap();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdn == mahdn.Mahdn) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhdn.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suahoadonnhap(hoadonnhap hdn)
        {
            int i;
            List<hoadonnhap> list = lhdn.GetAllhoadonnhap();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdn == hdn.Mahdn) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdn);
                lhdn.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<hoadonnhap> timhoadonnhap(hoadonnhap hdn)
        {
            List<hoadonnhap> list = lhdn.GetAllhoadonnhap();
            List<hoadonnhap> kq = new List<hoadonnhap>();
            //Voi gai tri ngam dinh ban dau
            if (hdn.Mahdn == null && hdn.Nvgiao == null && hdn.Manvnhap == null && hdn.Ngaynhan == null && hdn.Gianhap == 0)
            {
                kq = list;
            }
            //Tim theo mancc
            if (hdn.Mahdn != "")
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Mahdn.IndexOf(hdn.Mahdn) >= 0)
                    {
                        kq.Add(new hoadonnhap(list[i]));
                    }
            }
            // Tim theo tong tien
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
        public void Hientimkiem(hoadonnhap hdn)
        {
            int i;
            List<hoadonnhap> list = lhdn.GetAllhoadonnhap();
            Console.WriteLine("mahoadonnhap" + "\t" + "nhanviengiao" + "\t" + "manhanviennhap" + "\t" + "ngaynhap" + "\t" + "gianhap");
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdn == hdn.Mahdn)
                    Console.WriteLine(hdn.Mahdn + "\t" + hdn.Nvgiao + "\t\t" + hdn.Manvnhap + "\t\t" + hdn.Ngaynhan + "\t\t" + hdn.Gianhap);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}
