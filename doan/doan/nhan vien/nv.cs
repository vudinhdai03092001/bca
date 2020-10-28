using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doan.nhan_vien
{
    public class nhanvien
    {
        private string manv, tennv;
        private DateTime ngayvao;
        private string loainv;
        private DateTime ngaysinh;
        private int gioitinh;
        public string MASV
        {
            get { return manv; }
            set
            {
                if (value !="")
                    manv = value;
            }
        }
        public string TENNV
        {
            get { return tennv; }
            set
            {
                if (value !="")
                        tennv = value;
            }

        }
        public DateTime NGAYVAO 
        { get 
        }
        class nv
    {
    }
}
