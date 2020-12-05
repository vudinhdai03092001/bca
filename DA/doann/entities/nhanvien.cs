using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class nhanvien
    {
        private string mannv;
        private string tennv;
        private string gioitinh;
        private string loainv;
        private DateTime ngaysinh;
        private DateTime ngayvaolv;
        public string Mannv
        {
            get
            {
                return mannv;
            }
            set
            {
                if (value!="")
                    mannv = value;
            }
        }
        public string Tennv
        {
            get
            {
                return tennv;
            }
            set
            {
                if (value != "")
                    tennv = value;
            }
        }
        public string Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                if (value !="")
                    gioitinh = value;
            }
        }
        public string Loainv
        {
            get
            {
                return loainv;
            }
            set
            {
                if (value !="")
                    loainv = value;
            }
        }
        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }
            set
            {
               
                    ngaysinh= value;
            }
        }
        public DateTime Ngayvaolv
        {
            get
            {
                return ngayvaolv;
            }
            set
            {
 
                    ngayvaolv = value;
            }
        }
        public nhanvien()
        {
            mannv = "";
            tennv = "";
            gioitinh = "";
            loainv = "";
            ngaysinh = new DateTime();
            ngayvaolv = new DateTime();
        }
        public nhanvien(nhanvien nv)
        {
            this.mannv = nv.mannv;
            this.tennv = nv.tennv;
            this.gioitinh = nv.gioitinh;
            this.loainv = nv.loainv;
            this.ngaysinh = nv.ngaysinh;
            this.ngayvaolv = nv.ngayvaolv;
        }

        public nhanvien(string mannv1,string tennv1, string gioitinh1, string loainv1, DateTime ngaysinh1,DateTime ngayvaolv1)
        {
            mannv1 = mannv;
            tennv1 = tennv;
            gioitinh1 = gioitinh;
            loainv1 = loainv;
            ngaysinh1 = ngaysinh;
            ngayvaolv1 = ngayvaolv;

        }
    }
}
        
    

