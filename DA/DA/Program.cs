﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DA
{ class hanghoa
    {
        private string mahang { get => mahang; set => mahang = value; }
        private string tenhang { get => tenhang; set => tenhang = value; }
        private int slnhap { get => slnhap; set => slnhap = value; }
        private int slhienco { get => slhienco; set => slhienco = value; }
        public hanghoa()
        {
            mahang = "";
            tenhang = "";
            slnhap = 0;
            slhienco = 0;

        }
        public hanghoa(string mahang1,string tenhang1,int slnhap1,int slhienco1)
        {
            mahang1 = mahang;
            tenhang1 = tenhang;
            slnhap1 = slnhap;
            slhienco1 = slhienco;
        }
        public void nhap()
        {
            Console.Write("nhập mã hàng hóa :");mahang = Console.ReadLine();
            Console.Write("nhập tên hàng:");tenhang = Console.ReadLine();
            Console.Write("số lượng nhập :"); slnhap =int.Parse( Console.ReadLine());
            Console.Write("số lượng hiện có :"); slhienco =int.Parse( Console.ReadLine());
        }

    }class ncc
    {
        private int mancc { get => mancc; set => mancc = value; }
        private string tenncc { get => tenncc; set => tenncc = value; }
        private string diachi { get => diachi; set => diachi = value; }
        private int sdt { get => mancc; set => mancc = value; }
        public ncc()
        {
            mancc = 0;
            tenncc = "";
            diachi = "";
            sdt = 0;
        }
        public ncc(int mancc1,string tenncc1,string diachi,int sdt1)
        {

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}