using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class Matrix
    {
  
        private int _max = -100;
        private int _min = 100;
        private double _sum;
        private double _arithmeticValue;


        int[,] matrix;
        
        public Matrix(int row ,int column)
        {
         
            matrix = new int[row, column];
        }

        public void FullArray()
        {
            Random rand = new();
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rand.Next(-100, 100);
                }
            }
        }

        public int Max()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    _max = Math.Max(_max, matrix[i, j]);
                }
            }
            return _max;

        }


        public int Min()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    _min = Math.Min(_min, matrix[i, j]);
                }
            }
            return _min;
        }


        public double Sum()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    _sum += matrix[i,j];
                }
            }
            return _sum;
        }

        public double arithmeticValue() => Sum() / matrix.Length;
       


        public void Show()
        {
           
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j]+ " ");
                    }
                        Console.WriteLine();
                }
                
            
        }

        public void BubbleSort()
        {
            int[] array = new int[matrix.Length];
            int index = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    array[index] = matrix[i, j];
                    index++;
                }
            }


            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1])
                        Swap(ref array[j - 1], ref array[j]);
                }
            }
            index = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = array[index];
                    index++;
                }
            }



        }
        public void Swap(ref int first, ref int second)
        {
            int third = first;
            first = second;
            second = third;
        }



    }
}
