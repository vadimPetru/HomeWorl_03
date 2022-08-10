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
            string EnterData = Console.ReadLine();
            // Enter the date
            int number1 = Convert.ToInt32(EnterData);
            // 
            char[] arrayChar = EnterData.ToCharArray();
            Array.Reverse(arrayChar);
            int number2 = Convert.ToInt32(new String(arrayChar));
            if(number1 - number2 != 0)
            {
                Console.WriteLine($"Число {number1} и {number2} не полиндром");
            }
            else
            {
                Console.WriteLine($"Число {number1} и {number2}  Полиндром");
            }

            Console.ReadKey();
        }
       
    }
}
