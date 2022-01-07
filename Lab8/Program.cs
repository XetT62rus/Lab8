using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "H:\\Visual Studio проект";
            string [] drives = Directory.GetDirectories(path);
            foreach (string folder in drives)
            {
                Console.WriteLine(folder);
            }
            Console.ReadKey();
        }
    }
}
