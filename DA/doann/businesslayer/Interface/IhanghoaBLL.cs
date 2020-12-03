using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;

namespace doann.businesslayer.Interface
{
   public interface IhanghoaBLL
    {
        List<hanghoa> GetAllhanghoa();
        void themhanghoa(hanghoa hh);
        void xoahoadonban(hanghoa mahh);
        void suahoadonban(hanghoa hh);
        List<hanghoa> timhanghoa(hanghoa hh);
    }
}
