using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorl_03;

namespace HomeWorl_03
{
    public class Task1
    {

        Numbers numbers = new(); 

        public void Decision()
        {
            Console.WriteLine("Задание1  " +
                "Составить программу обмена значениями двух переменных (при возможности не создавать третью переменную).");
            do
            {
                Console.WriteLine("Введите первое число:");
                numbers.FirstNumber = numbers.Translation(numbers.FirstNumber);
                Console.WriteLine("Введите второе число:");
                numbers.SecondNumber = numbers.Translation(numbers.SecondNumber);
                numbers.Show();
                numbers.FirstNumber = numbers.FirstNumber + numbers.SecondNumber; // Find the sum of two numbers
                numbers.SecondNumber = numbers.FirstNumber - numbers.SecondNumber; // Find second number
                numbers.FirstNumber = numbers.FirstNumber - numbers.SecondNumber; // Find first number
                numbers.Show();
                Console.WriteLine("Выберите вариант ответа: \n 1)Продолжаем вводить числа \n 2)Заканчиваем программу");
                if (Console.ReadLine() == "2") break;
            } while (true);
        }

    }
}
