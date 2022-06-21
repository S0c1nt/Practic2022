using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public int Experience { get; set; }

        public Employee(string firstName, string lastName, string title, int experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Experience = experience;
        }

        public double Oklad()
        {
            double oklad;
            switch (Title)
            {
                case "Junior":
                    oklad = 45000;
                    break;
                case "Middle":
                    oklad = 100000;
                    break;
                case "Senior":
                    oklad = 150000;
                    break;
                case "Team Lead":
                    oklad = 215000;
                    break;
                default:
                    oklad = 40000;
                    break;
            }
            oklad = oklad + oklad/10 * Experience;

            return Math.Round(oklad, 2);
        }

        public double Nalog() 
        {
            return Math.Round(Oklad() * 0.13, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nДолжность: {2}\nОпыт: {3}\nОклад: {4}\nНалог: {5}", FirstName, LastName, Title, Experience, Oklad(), Nalog());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Имя: ");
            string a = Console.ReadLine();
            Console.Write("Фамилия: ");
            string b = Console.ReadLine();
            Console.Write("Должность(Junior, Middle, Senior, Team Lead): ");
            string c = Console.ReadLine();
            Console.Write("Опыт работы: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Employee person1 = new Employee(a, b, c, d);
            person1.GetInfo();

            Console.ReadKey();
        }
    }
}
