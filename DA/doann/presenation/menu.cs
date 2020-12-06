//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using doann.Utility;
//using doann.businesslayer;
//using doann.businesslayer.Interface;

//namespace doann.presenation
//{
//    class menu
//    {
//        private static frmgiaban gb = new frmgiaban();
//        private static frmhanghoa hh = new frmhanghoa();
//        private static frmhoadonban hdb = new frmhoadonban();
//        private static frmhoadonnhan hdn = new frmhoadonnhan();
//        private static frmNCC ncc = new frmNCC();
//        private static frmnhanvien nv = new frmnhanvien();
//        private static frmtinhluong tl = new frmtinhluong();
       
//        public static void HienMN()
//        {
//            ConsoleKeyInfo key;
//            string[][] mn = new string[7][];
//            mn[0] = new string[] { "1.Nhan vien", "A.Nhập nhân viên", "B.Sửa nhân viên", "C.Xóa nhân viên", "E.Tim kiem" };

//            mn[1] = new string[] { "2.Hàng hóa", "G.Nhập hàng hóa", "H.Sửa hàng hóa", "I.Xóa hàng hóa", "J.Hien thi", "K.Tim kiem" };

//            mn[2] = new string[] { "3.Nhà cung cấp ", "1.Nhập nhà cung cấp", "2.Sửa nhà cung cấp", "3.Xóa nhà cung cấp", "5.Tim kiem" };

//            mn[3] = new string[] { "4.Gia bán ", "R.Nhập giá bán", "S.Sửa giá bán", "T.Xóa giá bán", "U.Hiển thị", "V.Tim kiem", "Z.Hientimkiem" };

//            mn[4] = new string[] { "5.Hóa đơn bán ", "G.Nhập hóa đơn bán", "H.Sửa hóa đơn bán", "I.Xóa hóa đơn bán", ", "L.Tim kiem" };

//            mn[5] = new string[] { "6.Hoa don nhap ", "M.Nhập hóa đơn nhập", "N.Sửa hóa đơn nhập", "O.Xóa hóa đơn nhập", "Q.Tim kiem" };

//            mn[6] = new string[] { "7.Tính lương ", "6.Nhập tính lương", "7.Sửa bảng lương", "8.Xóa bảng lương", "0.Tim kiem" };
//            //Hien thi chuc năng đầu tiên
//            int muc = 0;
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("\n\n\t     QUẢN LÝ NHÀ HÀNG \n\n");
//                //Hiển thị các chức năng
//                for (int i = 0; i < mn.Length; ++i)
//                {
//                    Console.WriteLine("\t\t" + mn[i][0]);
//                    if (i == muc)
//                        for (int j = 1; j < mn[i].Length; ++j)
//                            Console.WriteLine("\t\t\t" + mn[i][j]);
//                }
//                key = Console.ReadKey(true);
//                if (key.KeyChar >= '0' && key.KeyChar <= '9')
//                    muc = key.KeyChar - 49;
//                else if (key.Key == ConsoleKey.X && key.Modifiers == ConsoleModifiers.Alt)
//                    Environment.Exit(0);
//                else
//                {
//                    ThucHien(key.KeyChar);
//                }
//            } while (true);
//        }
//        public static void ThucHien(char ch)
//        {
//            switch (char.ToUpper(ch))
//            {
//                case 'A':
//                    Console.Clear();
//                    nv.nhap();
//                    break;
//                case 'B':
//                    Console.Clear();
//                    nv.Sua();
//                    break;
//                case 'C':
//                    Console.Clear();
//                    nv.xoa(); break;
//                case 'D':
//                    Console.Clear();
//                    nv.Hien();
//                    Console.ReadKey(); break;
//                case 'G':
//                    Console.Clear();
//                    hdb.Nhap();
//                    break;
//                case 'H':
//                    Console.Clear();
//                    hdb.Sua();
//                    break;
//                case 'I':
//                    Console.Clear();
//                    hdb.xoa(); break;
//                case 'K':
//                    Console.Clear();
//                    hdb.Hien();
//                    Console.ReadKey(); break;
//                case 'M':
//                    Console.Clear();
//                    hdn.Nhap();
//                    break;
//                case 'N':
//                    Console.Clear();
//                    hdn.Sua();
//                    break;
//                case 'O':
//                    Console.Clear();
//                    hdn.xoa(); break;
//                case 'P':
//                    Console.Clear();
//                    hdn.Hien();
//                    Console.ReadKey(); break;
//                case 'R':
//                    Console.Clear();
//                    gb.Nhap();
//                    break;
//                case 'S':
//                    Console.Clear();
//                    gb.Sua();
//                    break;
//                case 'T':
//                    Console.Clear();
//                    gb.xoa(); break;
//                case 'U':
//                    Console.Clear();
//                    gb.Hien();
//                    Console.ReadKey(); break;
//                case 'E':
//                    Console.Clear();
//                    gb.Hientimkiem();
//                    Console.ReadKey(); break;
//                case 'X':
//                    Console.Clear();
//                    kh.Nhap();
//                    break;
//                case 'Y':
//                    Console.Clear();
//                    kh.Sua();
//                    break;
//                case 'J':
//                    Console.Clear();
//                    kh.xoa(); break;
//                case 'W':
//                    Console.Clear();
//                    kh.Hien();
//                    Console.ReadKey(); break;
//                case '+':
//                    Console.Clear();
//                    ld.Nhap();
//                    break;
//                case '-':
//                    Console.Clear();
//                    ld.Sua();
//                    break;
//                case '!':
//                    Console.Clear();
//                    ld.xoa(); break;
//                case '>':
//                    Console.Clear();
//                    ld.Hien();
//                    Console.ReadKey(); break;
//                case '(':
//                    Console.Clear();
//                    mh.Nhap();
//                    break;
//                case ')':
//                    Console.Clear();
//                    mh.Sua();
//                    break;
//                case '&':
//                    Console.Clear();
//                    mh.xoa(); break;
//                case '%':
//                    Console.Clear();
//                    mh.Hien();
//                    Console.ReadKey(); break;
//                case '@':
//                    Console.Clear();
//                    ncc.Nhap();
//                    break;
//                case '#':
//                    Console.Clear();
//                    ncc.Sua();
//                    break;
//                case '/':
//                    Console.Clear();
//                    ncc.xoa(); break;
//                case '*':
//                    Console.Clear();
//                    ncc.Hien();
//                    Console.ReadKey(); break;

//            }
//        }
//    }
//}
