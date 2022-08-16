using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class ArrayOneRank
    {

        private int _max; // MaximunValue for array
        private int _min; // MinimunValue for array
        private double _sum; // Sum of all elements
       
        
        private int[] _array; // Create array
        /// <summary>
        /// The construct for initialization private variable and initialization array
        /// </summary>
        /// <param name="size">The number for array size</param>
        /// <param name="LeftBound">The number is lower bound for value's array </param>
        /// <param name="RightBound">The number is higher bound for value's array </param>
        public ArrayOneRank(int size, int LeftBound , int RightBound) 
        {
            
            _array = new int[size];
            _max = LeftBound;
            _min = RightBound;
        }

        /// <summary>
        /// The Method for filling the array
        /// </summary>
        public void FullArray() 
        {
            Random rand = new();
            for(int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(_max,_min);
            }
        }

       /// <summary>
       /// The Metod for chose maximum number from array
       /// </summary>
       /// <returns></returns>

        public int SerchMax()
        {
            
            for (int i = 0; i < _array.Length; i++)
            {
                if (_max < _array[i]) _max = _array[i];
            }

            return _max;
        }
        /// <summary>
        /// The Metod for chose minimum number from array
        /// </summary>
        /// <returns></returns>

        public int SerchMin()
        {
            for(int i = 0; i < _array.Length; i++)
            {
                if (_min > _array[i]) _min = _array[i];
            }
            return _min;
        }

        /// <summary>
        /// The Metod for finding the sum elements
        /// </summary>
        /// <returns></returns>
        public double Sum()
        {
            foreach(var variable in _array)
            {
                _sum += variable;
            }
            return _sum;
        }
        /// <summary>
        /// Finding average value
        /// </summary>
        /// <returns></returns>
        public double Arithmetic() => Sum() / _array.Length;

        /// <summary>
        /// Showing array in the console
        /// </summary>
        public void Show()
        {
            foreach(var variable in _array)
            {
                Console.Write(variable + " ");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method for returning a string literal
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Maximum:{SerchMax()},\nMinimum:{SerchMin()},\nSum of elements:{Sum()},\n" +
               $"ArithmeticValue:{Arithmetic()}.";
        }

        /// <summary>
        /// This is Method for sorting element array
        /// </summary>
        public void  BubbleSort()
        {
            for(int j = 0; j < _array.Length; j++)
            {
                for (int i = 1; i < _array.Length; i++)
                {
                    if (_array[i - 1] < _array[i])
                    {
                        Swap(ref _array[i - 1], ref _array[i]);
                    }
                }
            }
           
             
        }
        /// <summary>
        /// The static metod for position elements in the array.
        /// </summary>
        /// <param name="first">The first element</param>
        /// <param name="second">The second element</param>
        private static void Swap(ref int first , ref int second)
        {
            int third = first;
            first = second;
            second = third;
        }
    }
}
