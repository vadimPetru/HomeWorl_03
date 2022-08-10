using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_04
{
    internal class Task3
    {


        
        Dictionary<string, string> russianEnglish = new Dictionary<string, string>()
        {
            { "Book" , "Книга" },
            { "Pen" , "Ручка" },
            { "Pensil" , "Карандаш" },
            { "Mirror" ,"Зеркало" },
            { "Candy", "Конфета" },
            { "Phone", "Телефон" },
            { "Notebook", "Записная книга" },
            { "Newspapper", "Газета" },
            { "HardDriver" , "Жесткий диск" },
            { "Knife","Нож" },




        };
        


        public void CheackWord(string word)
        {
            
            foreach(KeyValuePair<string, string> variable in russianEnglish)
            {
                if(variable.Key == word || variable.Value == word)
                {
                    Console.WriteLine(variable.Key + "-" + variable.Value);
                }
                
            }


        }



    }
}
