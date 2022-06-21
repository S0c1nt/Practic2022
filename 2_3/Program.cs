using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3
{
    public static class ArrayExt
    {
        public static void Sort(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 3, 0 };
            a.Sort();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
