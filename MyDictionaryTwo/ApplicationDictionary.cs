using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionaryTwo
{
    public class ApplicationDictionary<TKey, TValue>
    {
        private List<Part<TKey, TValue>> _listObject;
        Part<TKey, TValue> _item;
        public ApplicationDictionary()
        {
            _listObject = new List<Part<TKey, TValue>>();
        }

        public void AddElement(TKey key, TValue value)
        {
            _listObject.Add(new Part<TKey, TValue>(key, value));
        }

        public void RemoveElement(TKey key, TValue value)
        {
            try
            {
                for (int i = 0; i < _listObject.Count; i++)
                {
                    if (_listObject[i].Key.Equals(key) && _listObject[i].Value.Equals(value))
                        _listObject.RemoveAt(i);
                 
                   
                }

            }
            catch
            {
                Console.WriteLine("There isn't the element in this list");
            }

        }

        

        public Part<TKey, TValue> SerchElement(TKey key)
        {
           
                foreach (var item in _listObject)
                {
                    if (item.Key.Equals(key))
                    {
                        _item = item;
                    }
                }

                return _item;
         
            
        }

        public void Show()
        {
            foreach (var variable in _listObject)
            {

                Console.WriteLine(variable.Key);
            }
        }

        public void ShowAllElements()
        {
            foreach (var variable in _listObject)
            {

                Console.WriteLine(variable);
            }
        }


    }
}
