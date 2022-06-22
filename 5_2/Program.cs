using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2
{
    class Program
    {
        static string path = @"\Users\user\Desktop\Dir\File.txt";
        static void Main(string[] args)
        {
            using (FileStream fs = File.Create(path)) { }

            using (StreamWriter sw = new StreamWriter(path))
            {
                    sw.WriteLine("Не отчисляйте!");
            }
            
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                    Console.WriteLine(sr.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
