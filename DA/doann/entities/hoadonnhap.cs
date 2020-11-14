using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.entities
{
    class hoadonnhap
    {
        private int mahdn { get => mahdn; set => mahdn = value; }
        private string nvgiao { get => nvgiao; set => nvgiao = value; }
        private int manvnhap { get => manvnhap; set => manvnhap = value; }
        private DateTime ngaynhan { get => ngaynhan; set => ngaynhan = value; }
        private double tongtien { get => tongtien; set => tongtien = value; }
        private double thanhtoan { get => thanhtoan; set => thanhtoan = value; }
        public hoadonnhap()
        {
            mahdn = 0;
            nvgiao = "";
            manvnhap = 0;
            ngaynhan = new DateTime();
            tongtien = 0;
            thanhtoan = 0;

        }
        public hoadonnhap(int mahdn1, string nvgiao1, int manvnhap1, DateTime ngaynhan1,double tongtien1,double thanhtoan1)
        {
            mahdn1 = mahdn;
            nvgiao1 = nvgiao;
            manvnhap1 = manvnhap;
            ngaynhan1 = ngaynhan;
            tongtien1 = tongtien;
            thanhtoan1 = thanhtoan;

        }
    }
}


