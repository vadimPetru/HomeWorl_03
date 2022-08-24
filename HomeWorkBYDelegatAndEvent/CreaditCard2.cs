using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBYDelegatAndEvent
{
   
    internal class CreaditCard2
    {
        public delegate void AccountAction(string massege);
        public CreaditCard2(int wallet)
        {
            Wallet = wallet;
        }

        public event AccountAction? Event;
        public void EventInvoke()
        {
            Event?.Invoke("");
        }

        
        public int Wallet { get; set; }
        public void Get(int value)
        {
            if (Wallet >= value)
            {
                Wallet -= value;
                Event?.Invoke($"The amount on the account:{Wallet}");
            }
            else Event?.Invoke("Not enough funds");
        }
        public void Put(int value)
        {
            Wallet += value;
            Event?.Invoke($"The amount on the account:{Wallet}");
        }
    }
}
