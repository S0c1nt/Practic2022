using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание2_1
{
    class MyMatrix
    {
        private int[,] matrix = null;

        private int numberOfCols;
        private int numberOfRows;

        public int NumberOfCols
        {
            get { return numberOfCols; }
        }
        public int NumberOfRows
        {
            get { return numberOfRows; }
        }

        public MyMatrix()
        {
        }

        public MyMatrix(int numberOfCols, int numberOfRows)
        {
            if (numberOfCols < 0 || numberOfRows < 0)
            {
                Console.WriteLine("Значения не могут быть отрицательынми");
            }
            else
            {
                this.numberOfCols = numberOfCols;
                this.numberOfRows = numberOfRows;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void ChangeMatrix(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                Console.WriteLine("Значения не могут быть отрицательынми");
            }
            else
            {
                this.numberOfCols = x;
                this.numberOfRows = y;
                matrix = new int[numberOfCols, numberOfRows];
            }
        }

        public void FeedMatrix()
        {
            Random rand = new Random();
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    matrix[i, j] = rand.Next(30, 99);
                }
            }
        }
        public void ShowMatrix()
        {
            for (int i = 0; i < numberOfCols; i++)
            {
                for (int j = 0; j < numberOfRows; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public int this[int col, int row]
        {
            set
            {
                if ((col > 0 && row > 0) && (col < numberOfCols && row < numberOfRows))
                    matrix[col, row] = value;
                else
                    Console.WriteLine("Недопустимые значения индексов {0} и {1}", col, row);
            }
            get
            {
                return matrix[col, row];
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix(2, 2);

            matrix.FeedMatrix();
            matrix.ShowMatrix();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Число столбцов - {0}\nЧисло строк - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            Console.WriteLine(new string('-', 30));

            matrix.ChangeMatrix(4, 4);
            matrix.FeedMatrix();
            matrix.ShowMatrix();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("Число столбцов - {0}\nЧисло строк - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
            Console.WriteLine(new string('-', 30));

            matrix[-9, 9] = 123;
            matrix[2, 10] = 2;
        }
    }
}
