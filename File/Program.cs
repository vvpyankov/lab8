using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilePath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/Log.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }
        }
    }
}
