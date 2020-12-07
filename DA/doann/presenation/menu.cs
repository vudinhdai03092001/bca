using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using doann.Utility;
using doann.businesslayer;
using doann.businesslayer.Interface;

namespace doann.presenation
{
    class menu
    {
        private static frmgiaban gb = new frmgiaban();
        private static frmhanghoa hh = new frmhanghoa();
        private static frmhoadonban hdb = new frmhoadonban();
        private static frmhoadonnhap hdn = new frmhoadonnhap();
        private static frmNCC ncc = new frmNCC();
        private static frmnhanvien nv = new frmnhanvien();
        private static frmtinhluong tl = new frmtinhluong();

        public static void HienMN()
        {
            ConsoleKeyInfo key;
            string[][] mn = new string[7][];
            mn[0] = new string[] { "1.Nhân viên", "A.Nhập nhân viên", "B.Sửa nhân viên", "C.Xóa nhân viên","^.Hiển thị", "D.Tim kiem" };

            mn[1] = new string[] { "2.Hàng hóa", "E.Nhập hàng hóa", "G.Sửa hàng hóa", "H.Xóa hàng hóa", "I.Hiển thị", "K.Tim kiem" };

            mn[2] = new string[] { "3.Nhà cung cấp ", "N.Nhập nhà cung cấp", "M.Sửa nhà cung cấp", "P.Xóa nhà cung cấp",":.Hiển thị", "Q.Tim kiem" };

            mn[3] = new string[] { "4.Gia bán ", "V.Nhập giá bán", "S.Sửa giá bán", "R.Xóa giá bán", "T.Hiển thị", "O.Hiển thị", "U.Tìm kiếm" };

            mn[4] = new string[] { "5.Hóa đơn bán ", "Z.Nhập hóa đơn bán", "Ư.Sửa hóa đơn bán", "@.Xóa hóa đơn bán","(.Hiển thị", "#.Tìm kiếm"};

            mn[5] = new string[] { "6.Hóa đơn nhập ", "$.Nhập hóa đơn nhập", "%.Sửa hóa đơn nhập", "&.Xóa hóa đơn nhập",").Hiển thị", "*.Tìm kiếm" };

            mn[6] = new string[] { "7.Tính lương ", "Đ.Nhập tính lương", "W.Sửa bảng lương", "J.Xóa bảng lương","+.Hiển thị" ,"0.Tìm kiếm" };
            //Hien thi chuc năng đầu tiên
            int muc = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\t     QUẢN LÝ NHÀ HÀNG \n\n");
                //Hiển thị các chức năng
                for (int i = 0; i < mn.Length; ++i)
                {
                    Console.WriteLine("\t\t" + mn[i][0]);
                    if (i == muc)
                        for (int j = 1; j < mn[i].Length; ++j)
                            Console.WriteLine("\t\t\t" + mn[i][j]);
                }
                key = Console.ReadKey(true);
                if (key.KeyChar >= '0' && key.KeyChar <= '9')
                    muc = key.KeyChar - 49;
                else if (key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Alt)
                    Environment.Exit(0);
                else
                {
                    ThucHien(key.KeyChar);
                }
            } while (true);
        }
        public static void ThucHien(char ch)
        {
            switch (char.ToUpper(ch))
            {
                case 'A':
                    Console.Clear();
                    nv.Nhap();
                    break;
                case 'B':
                    Console.Clear();
                    nv.Sua();
                    break;
                case 'C':
                    Console.Clear();
                    nv.xoa(); break;
                case '^':
                    Console.Clear();
                    nv.Hien();break;
                case 'D':
                    Console.Clear();
                    nv.Hien();
                    Console.ReadKey(); break;
                    ///
                case 'E':
                    Console.Clear();
                    hh.Nhap();
                    break;
                case 'G':
                    Console.Clear();
                    hh.Sua();
                    break;
                case 'H':
                    Console.Clear();
                    hh.xoa(); break;
                case 'I':
                    Console.Clear();
                    hh.Hien();
                    Console.ReadKey(); break;
                case 'K':
                    Console.Clear();
                    hh.timkiem();
                    Console.ReadKey();break;
                    //
                case 'N':
                    Console.Clear();
                    ncc.Nhap();
                    break;
                case 'M':
                    Console.Clear();
                    ncc.Sua();
                    break;
                case 'P':
                    Console.Clear();
                    ncc.xoa(); break;
                case ':':
                    Console.Clear();
                    ncc.Hien();
                    Console.ReadKey(); break;
                case 'Q':
                    Console.Clear();
                    ncc.timkiem();
                    Console.ReadKey(); break;
               //
                case 'V':
                    Console.Clear();
                    gb.Nhap();
                    break;
                case 'S':
                    Console.Clear();
                    gb.Sua();
                    break;
                case 'R':
                    Console.Clear();
                    gb.xoa(); break;
                case 'T':
                    Console.Clear();
                    gb.Hien();
                    Console.ReadKey(); break;
                case 'O':
                    Console.Clear();
                    gb.Hien();
                    Console.ReadKey(); break;
                case 'U':
                    Console.Clear();
                    gb.timkiem();
                    break;
                    //
                case 'Z':
                    Console.Clear();
                    hdb.Nhap();
                    break;
                case 'Ư':
                    Console.Clear();
                    hdb.Sua(); break;
                case '@':
                    Console.Clear();
                    hdb.xoa();
                    Console.ReadKey(); break;
                case '(':
                    Console.Clear();
                    hdb.Hien();
                    break;
                case '#':
                    Console.Clear();
                    hdb.timkiem();
                    break;
                    ///
                case '$':
                    Console.Clear();
                    hdn.Nhap();
                    break;
                case '%':
                    Console.Clear();
                    hdn.Sua(); break;
                case '&':
                    Console.Clear();
                    hdn.xoa();
                    Console.ReadKey(); break;
                case ')':
                    Console.Clear();
                    hdn.Hien();
                    break;
                case '*':
                    Console.Clear();
                    hdn.timkiem();
                    break;
                    ////
                case 'Đ':
                    Console.Clear();
                    tl.Nhap();
                    break;
                case 'W':
                    Console.Clear();
                    tl.Sua(); break;
                case 'J':
                    Console.Clear();
                    tl.xoa();
                    Console.ReadKey(); break;
                case '+':
                    Console.Clear();
                    tl.Hien();
                    break;
                case '0':
                    Console.Clear();
                    tl.timkiem();
                                  
                 Console.ReadKey(); break;

            }
        }
    }
}
