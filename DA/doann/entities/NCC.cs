using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class NCC
    {

        private string mancc;
        private string tenncc;
        private string diachi;
        private int sdt;
        public string Mancc
        {
            get
            {
                return mancc;
            }
            set
            {
                if (value !="")
                    mancc = value;
            }
        }
        public string Tenncc
        {
            get
            {
                return tenncc;
            }
            set
            {
                if (value !="")
                    tenncc = value;
            }
        }
        public string Diachi
        {
            get
            {
                return diachi;
            }
            set
            {
                if (value !="")
                    diachi = value;
            }
        }
        public int Sdt
        {
            get
            {
                return sdt;
            }
            set
            {
                if (value > 0)
                    sdt = value;
            }
        }

        public NCC()
        {
            mancc = "";
            tenncc = "";
            diachi = "";
            sdt = 0;
        }
        public NCC(NCC ncc)
        {
            this.mancc = ncc.mancc;
            this.tenncc = ncc.tenncc;
            this.diachi = ncc.diachi;
            this.sdt = ncc.sdt;
        }

        public NCC(string mancc1, string tenncc1, string diachi1, int sdt1)
        {
            mancc1 = mancc;
            tenncc1 = tenncc;
            diachi1 = diachi;
            sdt1 = sdt;
        }
    } 
 }
        