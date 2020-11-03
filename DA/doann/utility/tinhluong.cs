using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doann.utility
{
    class tinhluong
    {
        private int matl { get => matl; set => matl = value; }
        private float songaylv { get => songaylv; set => songaylv = value; }
        private double thuong { get => thuong; set => thuong = value; }
        private double luongcoban { get => luongcoban; set => luongcoban = value; }
        private double thanhtien { get => thanhtien; set => thanhtien = value; }
        public tinhluong()
        {
            matl = 0;
            songaylv = 0;
            thuong = 0;
            luongcoban = 0;
            thanhtien = 0;
        }
        public tinhluong(int matl1, float songaylv1, double thuong1, double luongcoban1,double thanhtien1)
        {
            matl1 = matl;
            songaylv1 = songaylv;
            thuong1 = thuong;
            luongcoban1 = luongcoban;
            thanhtien1 = thanhtien;
            
        }
    }
}
        
