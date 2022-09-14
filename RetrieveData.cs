using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RetrieveData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\RetData.txt";
            string contents = File.ReadAllText(path);
            Console.WriteLine(contents);
            Console.ReadLine();
        }
    }
}
