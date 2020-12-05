using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using doann.DataAccessLayer.Interface;
using doann.businesslayer.Interface;
using doann.Utility;
using doann.DataAccessLayer;

namespace doann.businesslayer
{
   public class giabanBLL:IgiabanBLL
    {
        private IgiabanDAL lhgb = new giabanDAL();
        //Thực thi các yêu cầu
        public List<giaban> GetAllgiaban()
        {
            return lhgb.GetAllgiaban();
        }
        public void themgiaban(giaban tgb)
        {
            if (tgb.Magiaban != "")
            {
                lhgb.themgiaban(tgb);
            }
            else
                throw new Exception("Du lieu sai");
        }
        public void xoagiaban(giaban xgb)
        {
            int i;
            List<giaban> list = lhgb.GetAllgiaban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == xgb.Magiaban) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhgb.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suagiaban(giaban gb)
        {
            int i;
            List<giaban> list = lhgb.GetAllgiaban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == gb.Magiaban) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(gb);
                lhgb.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void timgiaban(giaban gb)
        {
            int i;
            List<giaban> list = lhgb.GetAllgiaban();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == gb.Magiaban) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(gb);
                lhgb.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public void Hientimkiem(giaban gb)
        {
            int i;
            List<giaban> list = lhgb.GetAllgiaban();
            Console.WriteLine("magiaban" + "\t" + "gia" + "\t" + "donvi");
            for (i = 0; i < list.Count; ++i)
                if (list[i].Magiaban == gb.Magiaban)
                    Console.WriteLine(gb.Magiaban + "\t" + gb.Gia + "\t\t" + gb.Donvitinh);

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}

