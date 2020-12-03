using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using doann.Utility;
using doann.Entities;

namespace doann.businesslayer.Interface
{
  public  interface IhoadonnhapBLL
    {
        List<hoadonnhap> GetAllgiaban();
        void themhoadonnhap(hoadonnhap hdn);
        void xoahoadonnhap(hoadonnhap mahdn);
        void suahoadonnhap(hoadonnhap hdn);
        List<hoadonnhap> timhoanhap(hoadonnhap hdn);
    }
}
