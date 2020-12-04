using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;

namespace doann.businesslayer.Interface
{
    interface ItinhluongBLL
    {
        List<tinhluong> GetAlltinhluong();
        void themtinhluong(tinhluong tl);
        void xoatinhluong(tinhluong tl);
        void suatinhluong(tinhluong tl);
        List<tinhluong> timtinhluong(tinhluong tl);
    }
}
