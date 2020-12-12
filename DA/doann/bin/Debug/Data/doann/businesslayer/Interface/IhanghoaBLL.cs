using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using doann.DataAccessLayer;

namespace doann.businesslayer.Interface
{
   public interface IhanghoaBLL
    {
        List<hanghoa> GetAllhanghoa();
        void themhanghoa(hanghoa hh);
        void xoahanghoa(hanghoa mahh);
        void suahanghoa(hanghoa hh);
        void timhanghoa(hanghoa hh);
        void Hientimkiem(hanghoa hh);
    }
}
