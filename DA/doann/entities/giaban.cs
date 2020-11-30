using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class giaban
    {
        private string magiaban;
        private double gia;
        private string donvitinh;
        public string Magiaban
        {
            get
            {
                return magiaban;
            }
            set
            {
                if (value !="")
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
            magiaban = "";
            gia = 0;
            donvitinh = "";            
        }
        public giaban(giaban gb)
        {
            this.magiaban = gb.magiaban;
            this.gia = gb.gia;
            this.donvitinh = gb.donvitinh;
        }
        public giaban(string magiaban1,double gia1, string donvitinh1)
        {
            magiaban1 = magiaban;
            gia1 = gia;
            donvitinh1 = donvitinh;

        }
    }
}

