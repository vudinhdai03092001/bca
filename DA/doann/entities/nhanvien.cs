using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.entities
{
    class nhanvien
    {
        private int mannv { get => mannv; set => mannv = value; }
        private string gioitinh { get => gioitinh; set => gioitinh = value; }
        private string loainv { get => loainv; set => loainv = value; }
        private DateTime ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        private DateTime ngayvaolv { get => ngayvaolv; set => ngayvaolv = value; }
        public nhanvien()
        {
            mannv = 0;
            gioitinh = "";
            loainv = "";
            ngaysinh = new DateTime();

            ngayvaolv = new DateTime();
        }
        public nhanvien(int mannv1, string gioitinh1, string loainv1, DateTime ngaysinh1,DateTime ngayvaolv1)
        {
            mannv1 = mannv;
            gioitinh1 = gioitinh;
            loainv1 = loainv;
            ngaysinh1 = ngaysinh;
            ngayvaolv1 = ngayvaolv;

        }
    }
}
        
    

