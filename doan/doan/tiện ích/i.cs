﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace doan.tiện_ích
{

    public class IO
    {

        public static string ReadPassword(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            string s = null;
            ConsoleKeyInfo kt;
            do
            {
                kt = Console.ReadKey(true);
                if (kt.Key != ConsoleKey.Enter && kt.Key != ConsoleKey.Escape && kt.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    s = s + kt.KeyChar.ToString();
                }
                else if (kt.Key == ConsoleKey.Backspace)
                {
                    Clear(x, y, s.Length, ConsoleColor.Black);
                    if (s.Length <= 1) s = "";
                    else s = s.Substring(0, s.Length - 1);
                    if (s == "") { Writexy(" ", x, y); Console.SetCursorPosition(x, y); }
                    else
                    {
                        int i = 0;
                        while (i < s.Length) { Writexy("*", x + i, y); i = i + 1; }

                    }
                }
                else if (kt.Key == ConsoleKey.Enter || kt.Key == ConsoleKey.Escape) break;
            } while (true);
            return s;
        }
        public static string ReadString(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            string s = null;
            ConsoleKeyInfo kt;
            do
            {
                kt = Console.ReadKey(true);
                if (kt.Key != ConsoleKey.Enter && kt.Key != ConsoleKey.Escape && kt.Key != ConsoleKey.Backspace)
                {
                    Console.Write(kt.KeyChar.ToString());
                    s = s + kt.KeyChar.ToString();
                }
                else if (kt.Key == ConsoleKey.Backspace)
                {
                    Clear(x, y, s.Length, ConsoleColor.Black);
                    if (s.Length <= 1) s = "";
                    else s = s.Substring(0, s.Length - 1);
                    if (s == "") { Writexy(" ", x, y); Console.SetCursorPosition(x, y); }
                    else Writexy(s, x, y);
                }
                else if (kt.Key == ConsoleKey.Enter) break;
                else if (kt.Key == ConsoleKey.Escape) doan.Program.Hien();
            } while (true);
            return s;
        }
        public static string ReadNumber(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            string s = null;
            ConsoleKeyInfo kt;
            do
            {
                kt = Console.ReadKey(true);
                if (kt.Key != ConsoleKey.Enter && kt.Key != ConsoleKey.Escape && kt.KeyChar >= '0' && kt.KeyChar <= '9')
                {
                    Console.Write(kt.KeyChar.ToString());
                    s = s + kt.KeyChar.ToString();
                }
                else if (kt.Key == ConsoleKey.Backspace)
                {
                    Clear(x, y, s.Length, ConsoleColor.Black);
                    if (s.Length <= 1) s = "";
                    else s = s.Substring(0, s.Length - 1);
                    if (s == "") { Writexy(" ", x, y); Console.SetCursorPosition(x, y); }
                    else Writexy(s, x, y);
                }
                else if (kt.Key == ConsoleKey.Enter) break;
                else if (kt.Key == ConsoleKey.Escape) doan.Program.Hien();
            } while (true);
            return s;
        }
        public static void Clear(int x, int y, int length, ConsoleColor maunen)
        {
            ConsoleColor mn = Console.BackgroundColor;
            ConsoleColor mc = Console.ForegroundColor;
            int i = x; int j = y; int d = 0;
            while (d < length)
            {
                if (i == 79) { i = 0; j = j + 1; } else i = i + 1;
                Writexy(" ", i, j, maunen, maunen);
                d++;
            }
            Console.BackgroundColor = mn;
            Console.ForegroundColor = mc;
        }
        public static void Writexy(string s, int x, int y, int len)
        {
            Console.SetCursorPosition(x, y);
            if (s.Length > len)
                Console.Write(s.Substring(0, len));
            else
                Console.Write(s);
        }
        public static void Writexy(string s, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }
        public static void Writexy(string s, int x, int y, ConsoleColor maunen, ConsoleColor mauchu)
        {
            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = maunen;
            Console.ForegroundColor = mauchu;
            Console.Write(s);
        }
        public static void Box(int x, int y, int chieucao, int chieurong)
        {
            Writexy("┌", x, y);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y);
            Writexy("┐", x + (chieurong - 1), y);

            for (int i = 1; i <= chieucao - 2; ++i) Writexy("│", x, y + i);
            for (int i = 1; i <= chieucao - 2; ++i) Writexy("│", x + (chieurong - 1), y + i);

            Writexy("└", x, y + (chieucao - 1));
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y + (chieucao - 1));
            Writexy("┘", x + (chieurong - 1), y + (chieucao - 1));
        }
        public static void Box(int x, int y, int chieucao, int chieurong, ConsoleColor maunen, ConsoleColor mauchu)
        {
            Writexy("┌", x, y, maunen, mauchu);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y, maunen, mauchu);
            Writexy("┐", x + (chieurong - 1), y, maunen, mauchu);

            for (int i = 1; i <= chieucao - 2; ++i) Writexy("│", x, y + i, maunen, mauchu);
            for (int i = 1; i <= chieucao - 2; ++i) Writexy("│", x + (chieurong - 1), y + i, maunen, mauchu);

            Writexy("└", x, y + (chieucao - 1), maunen, mauchu);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y + (chieucao - 1), maunen, mauchu);
            Writexy("┘", x + (chieurong - 1), y + (chieucao - 1), maunen, mauchu);
        }

        public static void BoxTitle(string title, int x, int y, int chieucao, int chieurong)
        {

            Writexy("┌", x, y);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y);
            Writexy("┐", x + (chieurong - 1), y);

            Writexy("│", x, y + 1); Writexy(title, x + 2, y + 1); Writexy("│", x + (chieurong - 1), y + 1);

            Writexy("├", x, y + 2);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y + 2);
            Writexy("┤", x + (chieurong - 1), y + 2);



            for (int i = 3; i <= chieucao - 2; ++i) Writexy("│", x, y + i);
            for (int i = 3; i <= chieucao - 2; ++i) Writexy("│", x + (chieurong - 1), y + i);

            Writexy("└", x, y + (chieucao - 1));
            for (int i = 1; i < chieurong - 1; ++i) Writexy("─", x + i, y + (chieucao - 1));
            Writexy("┘", x + (chieurong - 1), y + (chieucao - 1));
        }
        public static void BoxTitle(string title, int x, int y, int chieucao, int chieurong, ConsoleColor maunen, ConsoleColor mauchu)
        {

            Writexy("┌", x, y, maunen, mauchu);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y, maunen, mauchu);
            Writexy("┐", x + (chieurong - 1), y, maunen, mauchu);

            Writexy(title, x + 2, y + 1, maunen, mauchu);

            Writexy("├", x, y + 2, maunen, mauchu);
            for (int i = 1; i <= chieurong - 2; ++i) Writexy("─", x + i, y + 2, maunen, mauchu);
            Writexy("┤", x + (chieurong - 1), y + 2, maunen, mauchu);



            for (int i = 1; i <= chieucao - 2; ++i) Writexy("│", x, y + i, maunen, mauchu);
            for (int i = 1; i <= chieucao - 2; ++i) Writexy("│", x + (chieurong - 1), y + i, maunen, mauchu);

            Writexy("└", x, y + (chieucao - 1), maunen, mauchu);
            for (int i = 1; i < chieurong - 1; ++i) Writexy("─", x + i, y + (chieucao - 1), maunen, mauchu);
            Writexy("┘", x + (chieurong - 1), y + (chieucao - 1), maunen, mauchu);
        }
    }
}
