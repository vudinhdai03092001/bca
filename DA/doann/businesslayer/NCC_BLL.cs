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
    class NCC_BLL :INCC_BLL
    {
        private INCC_DAL lhncc = new NCC_DAL();
        //Thực thi các yêu cầu
        public List<NCC> GetAllNCC()
        {
            return lhncc.GetAllNCC();
        }
        public void themncc(NCC ncc)
        {
            if (ncc.Mancc != "" && ncc.Diachi != "")
            {
                lhncc.themNCC(ncc);
            }
            else
                throw new Exception("Du lieu sai");
        }

        public void xoancc(NCC xncc)
        {
            int i;
            List<NCC> list = lhncc.GetAllNCC();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mancc == xncc.Mancc) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                lhncc.update(list);
            }
            else
                throw new Exception("Khong ton tai ma nay");
        }
        public void suancc(NCC ncc)
        {
            int i;
            List<NCC> list = lhncc.GetAllNCC();
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mancc == ncc.Mancc) break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(ncc);
                lhncc.update(list);
            }
            else
                throw new Exception("Khong ton tai hs nay");
        }
        public List<NCC> Timncc(NCC ncc)
        {
            List<NCC> list = lhncc.GetAllNCC();
            List<NCC> kq = new List<NCC>();
            //Voi gai tri ngam dinh ban dau
            if (ncc.Mancc == null && ncc.Tenncc == null && ncc.Diachi == null && ncc.Sdt == 0)
            {
                kq = list;
            }
            //Tim theo ten ncc
            if (ncc.Tenncc != null)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Tenncc.IndexOf(ncc.Tenncc) >= 0)
                    {
                        kq.Add(new NCC(list[i]));
                    }
            }
            else if (ncc.Sdt != 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Sdt == ncc.Sdt)
                    {
                        kq.Add(new NCC(list[i]));
                    }
            }

            //Tim theo diachi
            else if (ncc.Diachi != null)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].Diachi == ncc.Diachi)
                    {
                        kq.Add(new NCC(list[i]));
                    }
            }
            //Cac truong hop khac cac ban tu lam
            else kq = null;
            return kq;
        }
        public void Hientimkiem(NCC ncc)
        {
            int i;
            List<NCC> list =lhncc.GetAllNCC();
            Console.WriteLine("manhacungcap" + "\t" + "tennhacungcap" + "\t" + "diachi" + "\t" + "sodienthoai" );
            for (i = 0; i < list.Count; ++i)
                if (list[i].Mancc == ncc.Mancc)
                    Console.WriteLine(ncc.Mancc + "\t" +ncc.Tenncc + "\t\t" + ncc.Diachi + "\t\t" + ncc.Sdt );

                else
                    throw new Exception("Khong ton tai hs nay");
        }
    }
}
