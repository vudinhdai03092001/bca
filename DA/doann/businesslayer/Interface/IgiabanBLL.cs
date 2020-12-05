using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;
using doann.DataAccessLayer;

namespace doann.businesslayer.Interface
{
  public  interface IgiabanBLL
    {
        List<giaban> GetAllgiaban();
        void themgiaban(giaban gb);
        void xoagiaban(giaban magb);
        void suagiaban(giaban gb);
        void timgiaban(giaban gb);
        void Hientimkiem(giaban gb);
        
    }
}
