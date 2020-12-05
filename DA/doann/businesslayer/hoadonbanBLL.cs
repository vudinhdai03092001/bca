using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using doann.DataAccessLayer.Interface;

namespace doann.businesslayer
{
   public class hoadonbanBLL:IhoadonbanBLL
    {
        private I lhhdb = new HoadonbanDAL();
        //Thực thi các yêu cầu
        public List<Hoadonban> LayDSHoadonban()
        {
            return lhhdb.LayDSHoadonban();
        }
        public void Themhoadonban(Hoadonban hdb)
        {
            if (hdb.manvb != "")
            {
                lhhdb.Themhoadonban(hdb);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void Xoahoadonban(Hoadonban xhdb)
        {
            int i;
            List<Hoadonban> list = lhhdb.LayDSHoadonban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdb == xhdb.mahdb) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhhdb.Update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void Suahoadonban(Hoadonban hdb)
        {
            int i;
            List<Hoadonban> list = lhhdb.LayDSHoadonban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].mahdb == hdb.mahdb) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdb);
                lhhdb.Update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<Hoadonban> Timhoadonban(Hoadonban hdb)
        {
            List<Hoadonban> list = lhhdb.LayDSHoadonban();
            List<Hoadonban> kq = new List<Hoadonban>();
            //Voi gai tri ngam dinh ban dau
            if (hdb.manvb == null && hdb.ngayban == null && hdb.Soluong == 0 && hdb.Gia == 0 && hdb.mahdb == null)
            {
                kq = list;
            }
            //Tim theo mavb
            else if (hdb.mahdb != "")
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].mahdb.IndexOf(hdb.mahdb) >= 0)
                    {
                        kq.Add(new Hoadonban(list[i]));
                    }
            }

            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
    }
}
