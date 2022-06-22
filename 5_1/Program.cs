using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Desktop\Dir";
            string subpath = @"Folder_";

            for (int i =0; i < 100; i++)
            {
                Directory.CreateDirectory($"{path}/{subpath+i}");
            }

            for (int i = 0; i < 100; i++)
            {
                Directory.Delete($"{path}/{subpath + i}");
            }
        }
    }
}
