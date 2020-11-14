using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
    class giaban
    {
        private int magiaban { get => magiaban; set => magiaban = value; }
        private double gia { get => gia; set => gia = value; }
        private string donvitinh { get => donvitinh; set => donvitinh= value; }
        
        public giaban()
        {
            magiaban = 0;
            gia = 0;
            donvitinh = "";
            
        }
        public giaban(giaban gb)
        {
            this.magiaban = gb.magiaban;
            this.gia = gb.gia;
            this.donvitinh = gb.donvitinh;

        }
        public giaban(int magiaban1,double gia1, string donvitinh1)
        {
            magiaban1 = magiaban;
            gia1 = gia;
            donvitinh1 = donvitinh;

        }
    }
}

