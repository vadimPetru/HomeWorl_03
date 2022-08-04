using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorl_03
{
    internal class Task2
    {
        Numbers numbers = new();

        public void Decision()
        {
            Console.WriteLine("Задание2 " +
                "Реализовать сравнение двух введенных с клавиатуры чисел." +
                " После сравнения, программа не должна закрываться, а должна ожидать ввод следующих цифр для сравнения");
            do
            {
                Console.WriteLine("Введите первое число:");
                numbers.FirstNumber = numbers.Translation(numbers.FirstNumber);
                Console.WriteLine("Введите второе число:");
                numbers.SecondNumber = numbers.Translation(numbers.SecondNumber);
                if (numbers.FirstNumber == numbers.SecondNumber)
                {
                    Console.WriteLine("Числа  равны");
                }
                else
                {
                    Console.WriteLine($"Число {Math.Max(numbers.FirstNumber, numbers.SecondNumber)} > " +
                        $"Числа {Math.Min(numbers.FirstNumber, numbers.SecondNumber)}");
                }
                Console.WriteLine("Выберите вариант ответа: \n 1)Продолжаем вводить числа \n 2)Заканчиваем программу");
                if (Console.ReadLine() == "2") break;
            } while (true);
        }


    }
}
