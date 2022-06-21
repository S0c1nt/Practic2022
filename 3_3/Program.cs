using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        static class Color
        {
            public static void Print(string stroka, int color)
            {
                switch (color)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.WriteLine(stroka, Console.ForegroundColor);
            }
        }

            static void Main(string[] args)
            {
                Console.Write("Текст: ");
                string stroka = Console.ReadLine();
                Console.WriteLine("Цвет штрифта(0 - белый, 1 - желтый, 2 - серый, 3 - голубой, 4 - пурпурный): ");
                int color = Convert.ToInt32(Console.ReadLine());

                Color.Print(stroka, color);

                Console.ReadKey();
            }
    }
}
