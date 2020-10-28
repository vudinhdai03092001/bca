    using System;
using System.Collections.Generic;
using System.Text;

namespace doan1
{
    class nhanvien
    {
        private string manv, tennv;
        private DateTime ngayvao;
        private string loainv;
        private DateTime ngaysinh;
        private int gioitinh;
        public string MASV
        {
            get { return manv; }
            set { if (value >= 1)
                    manv = value; }
        }
        public string TENNV
        {
            get { return tennv; }
            set { if(value 1=0)
                        tennv = value; }
        
        }public DateTime NGAYVAO { }
        public nhanvien()
        {
            this.manv = "";
            this.tennv = "";
            this.ngaysinh = new DateTime;
            this.loainv = "";
            this.gioitinh = 0;
               

                
        }
      
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
