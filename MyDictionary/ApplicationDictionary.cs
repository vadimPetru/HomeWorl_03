using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class ApplicationDictionary<TKey,TValue>
    {
        private List<TKey> _listKey;
        private List<TValue> _listValue;
 
        public ApplicationDictionary()
        {
            _listKey = new List<TKey>();
            _listValue = new List<TValue>();
        }

        public void AddElement(TKey Key, TValue Value)
        {
            _listKey.Add(Key);
            _listValue.Add(Value);
        }

        public void RemoveElement(TKey Key, TValue Value)
        {
            if((_listKey.Contains(Key) && _listValue.Contains(Value))&&
                (_listKey.IndexOf(Key) == _listValue.IndexOf(Value)))
            {
                _listKey.Remove(Key);
                _listValue.Remove(Value);
            }
            else
            {
                Console.WriteLine("Element isn't with so key and value");
            }
           
        }
       

        public (TKey,TValue) SerchElementByKey(TKey Key)
        {
            try
            {
                return (_listKey[_listKey.IndexOf(Key)], _listValue[_listKey.IndexOf(Key)]);
             }
            catch
            {
                return (default(TKey),default(TValue));
            }
        }
       
        public void ShowKey()
        {
            foreach (var elment in _listKey)
            {
                Console.WriteLine("{0}",elment);
            }
        }
    }
}
