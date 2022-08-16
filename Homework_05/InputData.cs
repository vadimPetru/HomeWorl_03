using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    internal class InputData
    {
        private ExchangeRate[] _array ;

 
        public ExchangeRate[] EnterData()
        {
             _array = new ExchangeRate[] {

                    new ExchangeRate(Currence.USD, Currence.EUR, 0.99631f),
                    new ExchangeRate(Currence.USD, Currence.GBP, 0.84538f),
                    new ExchangeRate(Currence.USD, Currence.CNY, 6.83f),
                    new ExchangeRate(Currence.USD, Currence.UAH, 36.73f),
                    new ExchangeRate(Currence.EUR, Currence.USD, 1f),
                    new ExchangeRate(Currence.EUR, Currence.GBP, 0.84938f),
                    new ExchangeRate(Currence.EUR, Currence.CNY, 6.85f),
                    new ExchangeRate(Currence.EUR, Currence.UAH, 36.89f),
                    new ExchangeRate(Currence.GBP, Currence.USD, 1.18f),
                    new ExchangeRate(Currence.GBP, Currence.CNY, 8.2f),
                    new ExchangeRate(Currence.GBP, Currence.EUR, 1.18f),
                    new ExchangeRate(Currence.GBP, Currence.UAH, 44.09f),
                    new ExchangeRate(Currence.UAH, Currence.USD, 0.027227f),
                    new ExchangeRate(Currence.UAH, Currence.EUR, 0.027108f),
                    new ExchangeRate(Currence.UAH, Currence.CNY, 0.18596f),
                    new ExchangeRate(Currence.UAH, Currence.GBP, 0.022682f),
                    new ExchangeRate(Currence.UAH, Currence.CNY, 0.18596f),
                    new ExchangeRate(Currence.CNY, Currence.USD, 0.14642f),
                    new ExchangeRate(Currence.CNY, Currence.EUR, 0.14592f),
                    new ExchangeRate(Currence.CNY, Currence.GBP, 0.12198f),
                    new ExchangeRate(Currence.CNY, Currence.UAH, 5.38f),

               };
            return _array;
        }
    }
}
