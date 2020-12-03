using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;

namespace doann.businesslayer.Interface
{
  public  interface IgiabanBLL
    {
        List<giaban> GetAllgiaban();
        void themhoadonban(giaban gb);
        void xoahoadonban(giaban magb);
        void suahoadonban(giaban gb);
        List<giaban> timgiaban(giaban gb);
    }
}
