using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorl_03

{
    public class Numbers
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        private int _number;
        public void Show() => Console.WriteLine($"FirstNumber is {FirstNumber} and secondNumber is {SecondNumber} ");
        public  int Translation()
        {
            
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out _number))
                {
                   
                    break;
                }
                else
                {
                    Console.WriteLine("Ввести надо число:");
                }
            }
            return _number;
        }

        
    }
    
   


   
}
