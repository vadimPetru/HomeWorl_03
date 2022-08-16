using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{

    public enum Currence 
    {
        USD, // Доллар США
        EUR, // Eвро
        CNY, // Юань
        GBP, // Фунт стерлинга
        UAH, // Гривна
       
    }
   
    class Print
    {
        public override string ToString()
        {
            StringBuilder str = new();
            foreach (Currence currence in Enum.GetValues(typeof(Currence)))
            {
                str.AppendFormat(currence + " ");
            }
            return str.ToString();
        }

       


        

       
        
    }

}
