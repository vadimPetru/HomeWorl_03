using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class Task2
    {
        public void Decision()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the count of the row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the count of the column:");
            int column = int.Parse(Console.ReadLine());
            Matrix matrix = new(row, column);
            matrix.FullArray();
            matrix.Show();
            Console.WriteLine();
            Console.WriteLine($"Maximum:{matrix.Max()},\nMinimum:{matrix.Min()},\nSum of elements:{matrix.Sum()},\n" +
                $"ArithmeticValue:{matrix.arithmeticValue()}.");
            Console.WriteLine();
            matrix.BubbleSort();
            matrix.Show();

        }
    }
}
