using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using doann.Utility;
using doann.Entities;

namespace doann.businesslayer
{
    public  interface IhoadonbanBLL
    {
        List<hoadonban> GetAllhoadonban();
        void themhoadonban(hoadonban hd);
        void xoahoadonban(hoadonban mahdb);
        void suahoadonban(hoadonban hd);
        List<hoadonban> timhoadon(hoadonban hd);
    }
}

