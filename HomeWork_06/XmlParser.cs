using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_06
{
    internal class XmlParser : FileParser
    {
        public XmlParser(string FileName) : base(FileName)
        {
        }

        public override string ParserFormat => String.Format($".{nameof(FileFormat.xml)}");

        public override void Analize() => Console.WriteLine($"{nameof(XmlParser)}: File:{FileName}, analized");


        public override void Close() => Console.WriteLine($"{nameof(XmlParser)}: File:{FileName}, closed");


        public override void Open() => Console.WriteLine($"{nameof(XmlParser)}: File:{FileName}, opened");


        public override void Read() => Console.WriteLine($"{nameof(XmlParser)}: File:{FileName}, read");
    }
}
