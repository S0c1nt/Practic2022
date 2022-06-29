using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int account = 0;
            Queue<int> costsPurchases = new Queue<int>();
            Random r = new Random();
            int clients = r.Next(1, 10);
            for (int i = 0; i < clients; i++)
            {
                costsPurchases.Enqueue(r.Next(1,10000));
            }

            Console.WriteLine("Клиентов сегодня: " + clients);

            while (costsPurchases.Count >= 0)
            {
                try
                {
                    Console.WriteLine("Осталось клиентов: " + clients);
                    clients -= 1;
                    Console.WriteLine($"На счёте: {account}. Нажмите любую клавишу!\n");
                    Console.ReadKey();
                    Console.Clear();
                    account += costsPurchases.Dequeue();
                    Console.WriteLine("\nДеньги зачислены!");
                }
                catch
                {
                    break;
                }
            }
        }
    }
}
