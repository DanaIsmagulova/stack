using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static Stack<DirectoryInfo> s = new Stack<DirectoryInfo>();
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo dir = new DirectoryInfo(path);
            Search(dir);
            while (s.Count != 0)
            {
                Console.WriteLine("В папке \"" + s.Peek().FullName + "\": " + s.Peek().GetFiles().Length + " Файлов");
                Console.WriteLine("В папке \"" + s.Peek().FullName + "\": " + s.Peek().GetDirectories().Length + " Папок");
                s.Pop();
            }

            Console.ReadKey();
        }

        static void Search(DirectoryInfo dir)
        {
            try
            {
                int cnt = dir.GetFiles().Length;
                s.Push(dir);
                foreach (DirectoryInfo ndir in dir.GetDirectories())
                {
                    Search(ndir);
                }
            }
            catch (Exception err)
            {

            }
        }

    }
}