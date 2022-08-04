using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorl_03
{
    internal class Task3
    {
        public void Decision()
        {
            Console.WriteLine("Реализовать алгоритм, который определяет является ли введенное целочисленное число полиндромом " +
                "(читается одинаково слева направо и справа налево, для преобразования к типу int использовать Convert.ToInt32())");
            Console.Write("Введите число:");
            string answer = "Полиндром";
            string line = Console.ReadLine();
            string firstNumber;
            if(int.TryParse(line, out var cheack))
            {
                firstNumber = line;
                string ReversseNumber = new string(firstNumber.Reverse().ToArray());
               
                for (int i = 0; i < firstNumber.Length; i++)
                {
                    if (firstNumber[i] != ReversseNumber[i])
                    {
                        answer = "Не полиндром";
                    }
                }
            }
            else
            {
                throw new Exception("Вводим только цифры");
            }

            Console.WriteLine(answer);

        }
       
    }
}
