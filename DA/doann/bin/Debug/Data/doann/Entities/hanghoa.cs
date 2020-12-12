using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class hanghoa
    {
        private string mahang;
        private string tenhang;
        private int slnhap;
        private int slhienco;
        public string Mahang
        {
            get
            {
                return mahang;
            }
            set
            {
                if (value !="")
                    mahang = value;
            }
        }
        public string Tenhang
        {
            get
            {
                return tenhang;
            }
            set
            {
                if (value !="")
                    tenhang = value;
            }
        }
        public int Slnhap
        {
            get
            {
                return slnhap;
            }
            set
            {
                if (value > 0)
                    slnhap= value;
            }
        }
        public int Slhienco
        {
            get
            {
                return slhienco;
            }
            set
            {
                if (value > 0)
                    slhienco= value;
            }
        }
        public hanghoa()
        {
        }
        public hanghoa(string mahang1, string tenhang1, int slnhap1, int slhienco1)
        {
            mahang = mahang1;
            tenhang = tenhang1;
            slnhap = slnhap1;
            slhienco = slhienco1;
        }        
        public hanghoa(hanghoa hh)
        {
            this.mahang = hh.mahang;
            this.tenhang = hh.tenhang;
            this.slnhap = hh.slnhap;
            this.slhienco = hh.slhienco;

        }       
    }
}
        