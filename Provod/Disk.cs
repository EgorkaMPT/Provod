using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provod
{
    internal class Disk
    {
        public static string kdisk;
        public static string sr;
        public static int pos;
        public static List<Neon1> raze = new List<Neon1>();
        public static List<Neon1> sova = new List<Neon1>();
        public static void Diski()
        {
            DriveInfo[] dr = DriveInfo.GetDrives();

            foreach (DriveInfo dri in dr)
            {
                Console.Write($"  Диск: {dri.Name} ");
                if (dri.IsReady)
                {
                    Console.Write($"Свободное пространство: {dri.TotalFreeSpace}");
                    Menu.max = Menu.max + 1;
                    raze.Add(new Neon1() { Name = dri.Name, Id = Menu.max });
                }
                Console.WriteLine();
                ;
            }
        }
        public static void Papka()
        {
            Menu.max = 0;
            foreach (Neon1 pr in raze)
            {
                if (pr.Id == pos)
                {
                    sr = (pr.Name);
                }
            };
            Papka1();
        }
        private static void Papka1()
        {
            Papka2();
            if (Directory.Exists(sr))
            {
                Console.WriteLine("--------------------Проводник--------------------");
                string[] dirs = Directory.GetDirectories(sr);
                foreach (string s in dirs)
                {
                    sova.Add(new Neon1() { Name = s, Id = Menu.max });
                    Console.WriteLine(s);
                    Menu.max = Menu.max + 1;
                }
                string[] files = Directory.GetFiles(sr);
                foreach (string s in files)
                {
                    sova.Add(new Neon1() { Name = s, Id = Menu.max });
                    Menu.max = Menu.max + 1;
                    Console.WriteLine(s);
                }
            }
        }
        private static void Papka2()
        {
            foreach (Neon1 iPart in sova)
            {
                if (iPart.Id ==  - 1)
                {
                    sr = (iPart.Name);
                }
            }
            sr = kdisk + sr;
        }
        public static void Clear()
        {
            raze.Clear();
            sova.Clear();
        }
    }
}