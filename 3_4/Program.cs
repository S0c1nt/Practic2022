using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4
{
    class Program
    {
        public enum Post
        {
            DBA = 105,
            TeamLead = 115,
            Designer = 105
        }

        public static class Accauntant
        {
            public static bool AskForBonus(Post worker, int hours)
            {
                if (hours >= (int)worker)
                    return true;
                else
                    return false;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Отработанные часы: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Должность(1 - DBA; 2 - TeamLead; 3 - Designer): ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b == 1)
            {
                if (Accauntant.AskForBonus(Post.DBA, a) == true)
                {
                    Console.WriteLine("Премия есть");
                }
                else
                {
                    Console.WriteLine("Премии нет");
                }
            }
            if (b == 2)
            {
                if (Accauntant.AskForBonus(Post.TeamLead, a) == true)
                {
                    Console.WriteLine("Премия есть");
                }
                else
                {
                    Console.WriteLine("Премии нет");
                }
            }
            if (b == 3)
            {
                if (Accauntant.AskForBonus(Post.Designer, a) == true)
                {
                    Console.WriteLine("Премия есть");
                }
                else
                {
                    Console.WriteLine("Премии нет");
                }
            }
            Console.ReadKey();
        }
    }
}
