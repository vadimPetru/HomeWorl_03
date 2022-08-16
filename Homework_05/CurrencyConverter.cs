using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_05
{
    internal class CurrencyConverter
    {
        List<ExchangeRate> ExchangeRates;

        public CurrencyConverter()
        {
            ExchangeRates = new();
        }
        public void AddExchangeRates(params ExchangeRate[] ExchangeRate) => ExchangeRates.AddRange(ExchangeRate);
        public void AddExchangeRate(ExchangeRate ExchangeRate) => ExchangeRates.Add(ExchangeRate);
        public void TryDeleteExchangeRate(Currence firstCurrency, Currence secondCurrency)
        {
            for(int i = 0; i < ExchangeRates.Count; i++)
            {
                if(ExchangeRates[i].FirstCurrency == firstCurrency && ExchangeRates[i].SecondCurrency == secondCurrency)
                {
                    ExchangeRates.RemoveAt(i);
                }
            }
        }
        public ExchangeRate FindExchangeRate(Currence firstCurrency, Currence secondCurrency)
        {
            int searchField =0;
            for (int i = 0; i < ExchangeRates.Count; i++)
            {
                if (ExchangeRates[i].FirstCurrency == firstCurrency && ExchangeRates[i].SecondCurrency == secondCurrency)
                {
                    searchField = i; 
                }
              
            }
            return ExchangeRates[searchField];
        }

        public override string ToString()
        {

            StringBuilder str = new();
            foreach(var variable in ExchangeRates)
            {
                str.Append(variable);
               
            }
            return str.ToString();
        }

        public void ConvertObject(Currence firstCurrency, Currence secondCurrency, int count)
        {
            var SerchExchangeRate =  FindExchangeRate(firstCurrency, secondCurrency);
            SerchExchangeRate.CurrencyCount = count;
            SerchExchangeRate.Value *= SerchExchangeRate.CurrencyCount;
            AddExchangeRate(SerchExchangeRate);
        }






    }
    
}
