using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.DataAccessLayer.Interface;
using doann.DataAccessLayer;
using doann.Entities;
using doann.businesslayer.Interface;

namespace doann.businesslayer
{
    class tinhluongBLL:ItinhluongBLL
    {
        private ItinhluongDAL lhtl = new tinhluongDAL();
        //Thực thi các yêu cầu
        public List<tinhluong> GetAlltinhluong()
        {
            return lhtl.GetAlltinhluong();
        }
        public void themtinhluong(tinhluong tl)
        {
            if (tl.Matl != "")
            {
                lhtl.themtinhluong(tl);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void xoatinhluong(tinhluong xtl)
        {
            int i;
            List<tinhluong> list = lhtl.GetAlltinhluong();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Matl == xtl.Matl) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhtl.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suatinhluong(tinhluong tl)
        {
            int i;
            List<tinhluong> list = lhtl.GetAlltinhluong();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Matl == tl.Matl) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(tl);
                lhtl.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void Hientimkiem(tinhluong tl)
        {
            int i;
            List<tinhluong> list = lhtl.GetAlltinhluong();
            Console.WriteLine("matinhluong" + "\t" + "songaylamviec" + "\t" + "thuong"+"\t"+"luongcoban"+"\t"+"thanhtien");
            for (i = 0; i < list.Count; ++i)
                if (list[i].Matl == tl.Matl)
                    Console.WriteLine(tl.Matl + "\t" + tl.Songaylv + "\t\t" + tl.Thuong + "\t\t" +tl.Luongcoban + "\t\t" +tl.Thanhtien);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
   }

