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
                return ngayban;
            }
            set
            {

                ngayban = value;
            }
        }
        public hoadonban()
        {
        }
        public hoadonban(hoadonban hd)
        {
            this.mahdb = hd.mahdb;
            this.giaban = hd.giaban;
            this.ngayban = hd.ngayban;
           
        }        
        public hoadonban(string mahdb1, double giaban1 , DateTime ngayban1)
        {
            mahdb = mahdb1;
           
            giaban = giaban1;
            ngayban = ngayban1;
        }
}
        
    }

