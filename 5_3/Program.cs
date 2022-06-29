using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5_3
{
    class Program
    {
        public static string ReadAllText(string filePath)
        {
            using (FileStream stream = File.OpenRead(filePath))
            {
                var encoding = new UTF8Encoding(true);
                var reader = new StreamReader(stream, encoding);
                return reader.ReadToEnd();
            }
        }
        static void Search(DirectoryInfo dr, Regex file)
        {
            FileInfo[] fi = dr.GetFiles();
            foreach (FileInfo info in fi)
            {
                if (file.IsMatch(info.Name))
                {
                    Console.WriteLine("{0,-20} | {1}", info.Directory.Name, info.Name);
                }
            }
            DirectoryInfo[] dirs = dr.GetDirectories();
            foreach (DirectoryInfo directoryInfo in dirs)
            {
                Search(directoryInfo, file);
            }
        }

        static void Main(string[] args)
        {
            Regex file = new Regex(@".*\.txt$");
            DirectoryInfo dr = new DirectoryInfo(@"C:\");
            Search(dr, file);
        }
    }
}
