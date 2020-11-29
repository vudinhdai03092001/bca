using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class giaban
    {
        private int magiaban;
        private double gia;
        private string donvitinh;
        public int Magiaban
        {
            get
            {
                return magiaban;
            }
            set
            {
                if (value > 0)
                    magiaban = value;
            }
        }
        public double Gia
        {
            get
            {
                return gia;
            }
            set
            {
                if (value > 0)
                    gia = value;
            }
        }
        public string Donvitinh
        {
            get
            {
                return donvitinh;
            }
            set
            {
                if (value !="")
                    donvitinh = value;
            }
        }
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

