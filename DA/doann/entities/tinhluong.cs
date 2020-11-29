using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.Entities
{
    class tinhluong
    {
        private string matl;
        private float songaylv;
        private double thuong;
        private double luongcoban;
        private double thanhtien;
        public string Matl
        {
            get
            {
                return matl;
            }
            set
            {
                if (value !="")
                    matl = value;
            }
        }
        public float Songaylv
        {
            get
            {
                return songaylv;
            }
            set
            {
                if (value > 0)
                  songaylv = value;
            }
        }
        public double Thuong
        {
            get
            {
                return thuong;
            }
            set
            {
                if (value > 0)
                    thuong = value;
            }

        }
        public double Luongcoban
        {
            get
            {
                return luongcoban;
            }
            set
            {
                if (value > 0)
                    luongcoban = value;
            }
        }
        public double Thanhtien
        {
            get
            {
                return songaylv * luongcoban + thuong;
            }
            set
            {
            
                    thanhtien = value;
            }
        }

        public tinhluong()
        {
            matl = "";
            songaylv = 0;
            thuong = 0;
            luongcoban = 0;
            thanhtien = 0;
        }
        public tinhluong(tinhluong tl)
        {
            this.matl = tl.matl;
            this.songaylv = tl.songaylv;
            this.thuong = tl.thuong;
            this.luongcoban = tl.luongcoban;
            this.thanhtien = tl.thanhtien;

        }
        public tinhluong(string matl1, float songaylv1, double thuong1, double luongcoban1,double thanhtien1)
        {
            matl1 = matl;
            songaylv1 = songaylv;
            thuong1 = thuong;
            luongcoban1 = luongcoban;
            thanhtien1 = thanhtien;
            
        }
    }
}
        
