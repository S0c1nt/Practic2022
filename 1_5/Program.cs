using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_5
{
    public class Invoice
    {
        public readonly int Account;
        public readonly string Customer; 
        public readonly string Provider;

        private string _article;
        private int _quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity) : this(account, customer, provider)
        {
            _article = article;
            _quantity = quantity;
        }

        public Invoice(int account, string customer, string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;
        }

        public double WithNds(double nds = 0.25)
        {
            return Account + (Account * nds);
        }

        public void Show()
        {
            Console.WriteLine("Клиент: {0}\nПоставщик: {1}\nТовар: {4} ({5})\nЦена без НДС: {2}\nЦена с НДС: {3}", Customer, Provider, Account, WithNds(), _article, _quantity);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Клиент: ");
            string client = Console.ReadLine();
            Console.Write("Поставщик: ");
            string postav = Console.ReadLine();
            Console.Write("Счет: ");
            int summa = Convert.ToInt32(Console.ReadLine());
            Console.Write("Товар: ");
            string tovar = Console.ReadLine();
            Console.Write("Количество: ");
            int k = Convert.ToInt32(Console.ReadLine());


            Invoice invoice = new Invoice(summa, client, postav, tovar, k);
            invoice.Show();

            Console.ReadKey();
        }
    }
}
