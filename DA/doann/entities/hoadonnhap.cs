using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class hoadonnhap
    {
        private string mahdn;
        private string nvgiao;
        private string manvnhap;
        private DateTime ngaynhan;
        private double gianhap;
        public string Mahdn
        {
            get
            {
                return mahdn;
            }
            set
            {
                if (value !="")
                    mahdn= value;
            }
        }
        public string Nvgiao
        {
            get
            {
                return nvgiao;
            }
            set
            {
                if (value != "")
                    nvgiao = value;
            }

        }
        public string Manvnhap
        {
            get
            {
                return manvnhap;
            }
            set
            {
                if (value !="")
                    manvnhap= value;
            }
        }
        public DateTime Ngaynhan
        {
            get
            {
                return ngaynhan;
            }
            set
            {
                ngaynhan = value;
            }

        }
        public double Gianhap
        {
            get
            {
                return gianhap;
            }
            set
            {
                if (value > 0)
                    gianhap = value;
            }
        }
        public hoadonnhap()
        {
            mahdn = "";
            nvgiao = "";
            manvnhap = "";
            ngaynhan = new DateTime();
            gianhap = 0;
          
        }
        public hoadonnhap(hoadonnhap hdn)
        {
            this.mahdn = hdn.mahdn;
            this.nvgiao = hdn.nvgiao;
            this.manvnhap = hdn.manvnhap;
            this.ngaynhan = hdn.ngaynhan;
            this.gianhap = hdn.gianhap;
        }
        public hoadonnhap(string mahdn1, string nvgiao1, string manvnhap1, DateTime ngaynhan1,double gianhap1)
        {
            mahdn1 = mahdn;
            nvgiao1 = nvgiao;
            manvnhap1 = manvnhap;
            ngaynhan1 = ngaynhan;
            gianhap1 = gianhap;
            
 
           

        }
    }
}


