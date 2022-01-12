using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/Log.txt";
            //if (!File.Exists(path))
            //{
            //    File.Create(path);
            //}
            using (StreamWriter sw = new StreamWriter(path, true))
            { sw.WriteLine("Старт программы");
                sw.WriteLine("Ощибка!!!");
            }
            //sw.Close();
            //sw.Flush();
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
        }
    }
}
