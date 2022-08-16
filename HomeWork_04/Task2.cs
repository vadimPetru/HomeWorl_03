using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class Task2
    {
        /// <summary>
        /// The Enums for storing constants
        /// </summary>
        enum GetValue
        {
            Max = -100,
            Min = 100
        };
        public void Decision()
        {
            Console.WriteLine();
            Console.WriteLine("Enter the count of the row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the count of the column:");
            int column = int.Parse(Console.ReadLine());
            Matrix matrix = new(row, column ,(int)GetValue.Max, (int)GetValue.Min);
            matrix.FullArray();
            matrix.Show();
            Console.WriteLine(matrix.ToString());
            matrix.BubbleSort();
            matrix.Show();

        }
    }
}
