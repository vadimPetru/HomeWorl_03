using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkAttribute
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true )]
    internal class AccessLevelAttribute : Attribute
    {
        private readonly string _text;
        private readonly int _number;

        public AccessLevelAttribute(int number ,string text)
        {
            _number = number;
            _text = text;
        }

        public string Text
        {
            get { return (_text); }
        }

        public int Number
        {
            get { return (_number); }
        }
    }
}
