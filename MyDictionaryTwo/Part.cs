using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryTwo
{
    public class Part<Tkey,TValue>
    {
        private Tkey _key;
        private TValue _value;

        public Part(Tkey key,TValue value)
        {
            _key = key;
            _value = value;
        }

       
        public Tkey Key {
            get => _key;
            set => _key = value;
        }
        public TValue Value { 
            get => _value;
            set => _value = value;
        }

        public override string ToString()
        {
            return $" This instance have key:{Key} - value:{Value}";
        }
    }
}
