using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "Log/Директории.txt";
            StreamWriter sw = new StreamWriter(path);
            int[] mass = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                mass[i] = random.Next();
                sw.WriteLine("{0}", mass[i]);                
            }
            sw.Close();
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
