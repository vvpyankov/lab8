using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Program Files (x86)\Microsoft Visual Studio";
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("Подпапки");
                foreach (var it in item.GetDirectories())
                {
                    Console.WriteLine("{0,30}",it.Name);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
