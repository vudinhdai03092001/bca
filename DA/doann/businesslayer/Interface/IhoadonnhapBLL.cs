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
        List<hoadonnhap> GetAllhoadonnhap();
        void themhoadonnhap(hoadonnhap hdn);
        void xoahoadonnhap(hoadonnhap mahdn);
        void suahoadonnhap(hoadonnhap hdn);
        List<hoadonnhap> timhoadonnhap(hoadonnhap hdn);
        void Hientimkiem(hoadonnhap hdn);


    }
}
