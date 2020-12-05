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
    class hanghoaBLL:IhanghoaBLL
    {
        private IhanghoaDAL lhh = new hanghoaDAL();
        //Thực thi các yêu cầu
        public List<hanghoa> GetAllhanghoa()
        {
            return lhh.GetAllhanghoa();
        }
        public void themhanghoa(hanghoa thh)
        {
            if (thh.Mahang != "")
            {
                lhh.themhanghoa(thh);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void xoahanghoa(hanghoa xhh)
        {
            int i;
            List<hanghoa> list = lhh.GetAllhanghoa();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == xhh.Mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhh.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suahanghoa(hanghoa hh)
        {
            int i;
            List<hanghoa> list = lhh.GetAllhanghoa();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == hh.Mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hh);
                lhh.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void timhanghoa(hanghoa hh)
        {
            int i;
            List<hanghoa> list = lhh.GetAllhanghoa();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == hh.Mahang) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hh);
                lhh.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void Hientimkiem(hanghoa hh)
        {
            int i;
            List<hanghoa> list = lhh.GetAllhanghoa();
            Console.WriteLine("mahang" + "\t" + "tenhang" + "\t" + "soluongnhap"+"\t"+"soluonghienco");
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mahang == hh.Mahang)
                    Console.WriteLine(hh.Mahang + "\t" + hh.Tenhang + "\t\t" + hh.Slnhap+"\t\t"+hh.Slhienco);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}
    

