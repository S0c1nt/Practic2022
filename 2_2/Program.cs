using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2
{
    class Program
    {
        public class Article
        {
            private string name;
            private string store;
            private double price;

            public string Name { get { return name; } }
            public string Store { get { return store; } }
            public double Price { get { return price; } }

            public Article(string Name, string Store, double Price)
            {
                name = Name;
                store = Store;
                price = Price;
            }
        }

        public class Store
        {
            private Article[] art = null;

            public Store(Article[] a)
            {
                art = a;
            }

            public void GetArticle(int n)
            {
                try
                {
                    Console.WriteLine(art[n].Name + " --- " + art[n].Store + " --- " + art[n].Price);
                }
                catch
                {
                    Console.WriteLine("Индекс за пределами массива!");
                }
            }

            public void FindArticle(string n)
            {
                List<Article> l = new List<Article>();
                for (int i = 0; i < art.Length; i++)
                {
                    if (art[i].Name.Contains(n))
                    {
                        l.Add(art[i]);
                    }
                }

                if (l.Count > 0)
                {
                    for (int i = 0; i < l.Count; i++)
                    {
                        Console.WriteLine(l[i].Name + " --- " + l[i].Store + " --- " + l[i].Price);
                    }
                }
                else
                {
                    Console.WriteLine("Товар не найден!");
                }
            }
        }

        static void Main(string[] args)
        {
            Article a1 = new Article("Кружка", "Fix Price", 100);
            Article a2 = new Article("Гитара", "Музыкальный", 5000);
            Article a3 = new Article("Ноутбук", "МВидео", 25000);

            Store store = new Store(new Article[] { a1, a2, a3 });

            Console.Write("Поиск по индексу: ");
            store.GetArticle(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Поиск по названию: ");
            store.FindArticle(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
