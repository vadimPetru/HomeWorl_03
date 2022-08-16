using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_05
{
    public class ExchangeRate
    {
        

        public Currence FirstCurrency { get; set; }
        public Currence SecondCurrency { get; set; }

        public float Value { get; set; }

        public int CurrencyCount { get; set; } = 1;

        public override string ToString()
        {
            return $"{CurrencyCount:0.00} {FirstCurrency} = {Convert.ToSingle($"{Value:0.00}")} {SecondCurrency}\n";
        }

        public ExchangeRate(Currence FirstCurrency , Currence SecondCurrency)
        {
            this.FirstCurrency = FirstCurrency;
            this.SecondCurrency = SecondCurrency;
        }

        public ExchangeRate(Currence FirstCurrency, Currence SecondCurrency , float value)
            :this( FirstCurrency,  SecondCurrency)
        {
            Value = value;
        }

       
    }
}
