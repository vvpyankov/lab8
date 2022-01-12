using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\sumRan10.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            int[] array = new int[10];
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0, 10);
                using (StreamWriter sw = new StreamWriter(path,true))
                {

                    sw.WriteLine("{0} ", array[i]);

                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
