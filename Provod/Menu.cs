using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provod
{
    internal class Menu
    {
        public static int min;
        public static int max;
        public static int zn;
        public static void Osn() 
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                switch(key.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            Console.SetCursorPosition(0, zn);
                            Console.Write("->");
                            Console.Clear();
                            Console.WriteLine("_______________ПРОВОДНИК ___________ ");
                            Disk.Diski();
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (Disk.pos != min)
                        {
                            Console.SetCursorPosition(0, Disk.pos);
                            Console.WriteLine("  ");
                            Disk.pos--;
                            Console.SetCursorPosition(0, Disk.pos);
                            Console.Write("->");
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Disk.pos != max)
                        {
                            Console.SetCursorPosition(0, Disk.pos);
                            Console.WriteLine("  ");
                            Disk.pos++;
                            Console.SetCursorPosition(0, Disk.pos);
                            Console.Write("->");
                        }
                        else 
                        {
                            break;
                        }
                        break;
                    case ConsoleKey.F1:
                        Console.Clear();
                        Disk.Papka();
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        Disk.Clear();
                        Disk.Papka();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Process.GetCurrentProcess().Kill();
                        break;
                }
            }
        }
    }
}