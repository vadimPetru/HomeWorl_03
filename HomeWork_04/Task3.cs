using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class Task3
    {


        public void MethodCheack()
        {
            Console.WriteLine("Enter  english word ");
            string word = Console.ReadLine();

            Dictionary<string, string> russianEnglish = new()
            {
                { "Book", "Книга" },
                { "Pen", "Ручка" },
                { "Pensil", "Карандаш" },
                { "Mirror", "Зеркало" },
                { "Candy", "Конфета" },
                { "Phone", "Телефон" },
                { "Notebook", "Записная книга" },
                { "Newspapper", "Газета" },
                { "HardDriver", "Жесткий диск" },
                { "Knife", "Нож" },
            };
            
            if (russianEnglish.TryGetValue(word,out var value))
            {
                Console.WriteLine($"Word translation : {word} - {value}") ;
            }
            else
                Console.WriteLine("This dictionary isn't this word");



        }
        






    }



}
    
