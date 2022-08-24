using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkBYDelegatAndEvent
{
   
    internal class CreditCard
    {
        public delegate void AccountAction(string massege);
        public CreditCard(int wallet)
        {
            Wallet = wallet;
        }

        AccountAction?taken;

        public void RegisterHandler(AccountAction del)
        {
            taken = del;
        }
        public int Wallet { get; set; }
        public void Get(int value)
        {
            if (Wallet >= value) {
                Wallet -= value;
                taken?.Invoke($"The amount on the account:{Wallet}");
                    }
            else taken?.Invoke("Not enough funds");
        }
        public void Put(int value)
        {
            Wallet += value;
            taken?.Invoke($"The amount on the account:{Wallet}");
        }


        }
    }
