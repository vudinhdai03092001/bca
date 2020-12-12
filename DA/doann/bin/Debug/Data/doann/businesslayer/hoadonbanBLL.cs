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
    public class hoadonbanBLL : IhoadonbanBLL
    {
        private IhoadonbanDAL lhhdb = new hoadonbanDAL();
        //Thực thi các yêu cầu
        public List<hoadonban> GetAllhoadonban()
        {
            return lhhdb.GetAllhoadonban();
        }
        public void themhoadonban(hoadonban hdb)
        {
            if (hdb.Giaban >0)
            {
                lhhdb.themhoadonban(hdb);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void xoahoadonban(hoadonban mahdb)
        {
            int i;
            List<hoadonban> list = lhhdb.GetAllhoadonban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdb == mahdb.Mahdb) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhhdb.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suahoadonban(hoadonban hdb)
        {
            int i;
            List<hoadonban> list = lhhdb.GetAllhoadonban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdb == hdb.Mahdb) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdb);
                lhhdb.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<hoadonban> timhoadonban(hoadonban hdb)
        {
            List<hoadonban> list = lhhdb.GetAllhoadonban();
            List<hoadonban> kq = new List<hoadonban>();
            //Voi gai tri ngam dinh ban dau
            if (hdb.Mahdb == null && hdb.Giaban == 0 && hdb.Ngayban == null)
            {
                kq = list;
            }
            //Tim theo 
            else if (hdb.Mahdb != "")
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Mahdb.IndexOf(hdb.Mahdb) >= 0)
                    {
                        kq.Add(new hoadonban(list[i]));
                    }
            }


            else kq = null;
            return kq;
        }
        public void Hientimkiem(hoadonban hdb)
        {
            int i;
            List<hoadonban> list = lhhdb.GetAllhoadonban();
            Console.WriteLine("mahoadonban" + "\t" + "giaban" + "\t" + "ngay");
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahdb == hdb.Mahdb)
                    Console.WriteLine(hdb.Mahdb + "\t" + hdb.Giaban + "\t\t" + hdb.Ngayban);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}
