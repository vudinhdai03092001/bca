using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.tasks;

namespace doann.Entities
{
   public class hoadonban
    {
        private string mahdb;
        private double giaban;
        private DateTime ngayban;   
        public string Mahdb
        {
            get
            {
                return mahdb;
            }
            set
            {
                if (value != "")
                    mahdb = value;
            }
        }
        public double Giaban
        {
            get
            {
                return giaban;
            }
            set
            {
                if (value >0)
                  giaban = value;
            }
        }
        public DateTime Ngayban
        {
            get
            {
                return Ngayban;
            }
            set
            {

                Ngayban = value;
            }
        }
        public hoadonban()
        {
            mahdb = "";
            ngayban=new DateTime();
            giaban = 0;
        }
        public hoadonban(hoadonban hd)
        {
            this.mahdb = hd.mahdb;
            this.ngayban = hd.ngayban;
            this.giaban = hd.giaban;
        }        
        public hoadonban(string mahdb1, DateTime ngayban1, double giaban1   )
        {
            mahdb = mahdb1;
            ngayban = ngayban1;
            giaban = giaban1;
    }
}
        
    }

