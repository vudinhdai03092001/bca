using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.entities
{
    class hoadonban
    {
        private int mahdb { get => mahdb; set => mahdb = value; }
        private double tongtien { get => tongtien; set => tongtien = value; }
        private DateTime ngayban { get => ngayban; set => ngayban = value; }
        
        public hoadonban()
        {
            mahdb = 0;
            ngayban=new DateTime();
            tongtien = 0;
        }
        public hoadonban(hoadonban hd)
        {
            this.mahdb = hd.mahdb;
            this.ngayban = hd.ngayban;
            this.tongtien = hd.tongtien;
        }
        public hoadonban(int mahdb1, DateTime ngayban1, double tongtien1)
        {
            mahdb = mahdb1;
            ngayban = ngayban1;
            tongtien = tongtien1;
    }
}
        
    }

