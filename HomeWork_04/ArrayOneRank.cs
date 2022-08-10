using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class ArrayOneRank
    {
        
        private int _max = -100;
        private int _min =100;
        private double _sum ;
        private double arithmeticValue;
        // Create field
        private int[] _array;
        public ArrayOneRank(int size)
        {
            
            _array = new int[size];
        }

       public void FullArray()
        {
            Random rand = new();
            for(int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next(_max,_min);
            }
        }

       

        public int SerchMax()
        {
            
            for (int i = 0; i < _array.Length; i++)
            {
                _max = Math.Max(_max, _array[i]);
            }

            return _max;
        }


        public int SerchMin()
        {
            for(int i = 0; i < _array.Length; i++)
            {
                _min = Math.Min(_min, _array[i]);
            }
            return _min;
        }


        public double Sum()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                _sum += _array[i]; 
            }
            return _sum;
        }

        public double Arithmetic() => arithmeticValue = _sum / _array.Length;


        public void Show()
        {
            foreach(var variable in _array)
            {
                Console.Write(variable + " ");
            }
        }

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

        public void Swap(ref int first , ref int second)
        {
            int third = first;
            first = second;
            second = third;
        }
    }
}
