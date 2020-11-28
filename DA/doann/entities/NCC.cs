using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
   public class NCC
    {

        private int mancc { get => mancc; set => mancc = value; }
        private string tenncc { get => tenncc; set => tenncc = value; }
        private string diachi { get => diachi; set => diachi = value; }
        private int sdt { get => mancc; set => mancc = value; }
        public NCC()
        {
            mancc = 0;
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

        public NCC(int mancc1, string tenncc1, string diachi1, int sdt1)
        {
            mancc1 = mancc;
            tenncc1 = tenncc;
            diachi1 = diachi;
            sdt1 = sdt;
        }
    } 
 }
        