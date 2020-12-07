using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Entities;

namespace doann.businesslayer.Interface
{
   public interface InhanvienBLL
    {
        List<nhanvien> GetAllnhanvien();
        void themnhanvien(nhanvien nv);
        void xoanhanvien(nhanvien manv);
        void suanhanvien(nhanvien nv);
        List<nhanvien> Timnhanvien(nhanvien nv);
        void Hientimkiem(nhanvien nv);

    }
}
