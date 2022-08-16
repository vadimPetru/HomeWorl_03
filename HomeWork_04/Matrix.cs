using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class Matrix
    {

        private int _max; // MaximunValue for array
        private int _min; // MinimunValue for array
        private double _sum; // Sum of all elements



        int[,] _matrix; //Create array
        /// <summary>
        /// The construct for initialization private variable and initialization array
        /// </summary>
        /// <param name="row">the count of rows for array</param>
        /// <param name="column">the count of columns for array</param>
        /// <param name="lowerBound">The number is lower bound for value's array </param>
        /// <param name="rightBound">The number is higher bound for value's array</param>
        public Matrix(int row, int column, int lowerBound, int rightBound)
        {

            _matrix = new int[row, column];
            _max = lowerBound;
            _min = rightBound;
        }
        /// <summary>
        /// Filling array random numbers 
        /// </summary>
        public void FullArray()
        {
            Random rand = new();
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = rand.Next(-100, 100);
                }
            }
        }
        /// <summary>
        /// Serching Maximum element
        /// </summary>
        /// <returns></returns>
        public int Max()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (_max < _matrix[i, j]) _max = _matrix[i, j];
                }
            }
            return _max;

        }
        /// <summary>
        /// Serching Manimum element
        /// </summary>
        /// <returns></returns>

        public int Min()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    if (_max < _matrix[i, j]) _max = _matrix[i, j];
                }
            }
            return _min;
        }

        /// <summary>
        /// The Metod for finding the sum elements
        /// </summary>
        /// <returns></returns>
        public double Sum()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    _sum += _matrix[i, j];
                }
            }
            return _sum;
        }
        /// <summary>
        /// Finding average value
        /// </summary>
        /// <returns></returns>
        public double ArithmeticValue() => Sum() / _matrix.Length;


        /// <summary>
        /// Showing array in the console
        /// </summary>
        public void Show()
        {
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    Console.Write(_matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Method for returning a string literal
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Maximum:{Max()},\nMinimum:{Min()},\nSum of elements:{Sum()},\n" +
                $"ArithmeticValue:{ArithmeticValue()}.";
        }
        /// <summary>
        /// Sorting Array
        /// </summary>
        public void BubbleSort()
        {
            for(int k = 0; k < _matrix.GetLength(0); k++)
            {
                for (int i = 0; i < _matrix.GetLength(0) - 1; i++)
                {
                    for (int j = 0; j < _matrix.GetLength(1) - 1; j++)
                    {
                        if (_matrix[i, j] < _matrix[i, j + 1])
                        {
                            Swap(ref _matrix[i, j], ref _matrix[i, j + 1]);
                        }
                    }


                }
            }
            
        }


        private static void Swap(ref int first, ref int second)
        {
            int third = first;
            first = second;
            second = third;
        }

    }
}
