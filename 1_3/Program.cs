using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    public class Converter
    {
        private double usd;
        private double eur;
        private double rub;

        public Converter(double USD, double EUR, double RUB)
        {
            usd = USD;
            eur = EUR;
            rub = RUB;
        }

        public double ToUSD(double UAH)
        {
            return Math.Round(UAH / usd, 2);
        }
        public double FromUSD(double USD)
        {
            return Math.Round(USD * usd, 2);
        }

        public double ToEUR(double UAH)
        {
            return Math.Round(UAH / eur, 2);
        }
        public double FromEUR(double EUR)
        {
            return Math.Round(EUR * eur, 2);
        }

        public double ToRUB(double UAH)
        {
            return Math.Round(UAH / rub, 2);
        }
        public double FromRUB(double RUB)
        {
            return Math.Round(RUB * rub, 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Converter Con = new Converter(29.55, 30.96, 0.52);
            Console.WriteLine("250 UAH: ");
            Console.WriteLine(Con.ToUSD(250) + " USD");
            Console.WriteLine(Con.ToEUR(250) + " EUR");
            Console.WriteLine(Con.ToRUB(250) + " RUB");

            Console.WriteLine("\n250 USD = " + Con.FromUSD(250) + " UAH");
            Console.WriteLine("250 EUR = " + Con.FromEUR(250) + " UAH");
            Console.WriteLine("250 RUB = " + Con.FromRUB(250) + " UAH");

            Console.ReadKey();
        }
    }
}
