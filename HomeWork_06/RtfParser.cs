using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_06
{
    internal class RtfParser : FileParser
    {
        public RtfParser(string FileName) : base(FileName)
        {

        }

        public override string ParserFormat => String.Format($".{nameof(FileFormat.rtf)}");

        public override void Analize() => Console.WriteLine($"{nameof(RtfParser)}: File {FileName}, analized");


        public override void Close() => Console.WriteLine($"{nameof(RtfParser)}: File {FileName}, closed");


        public override void Open() => Console.WriteLine($"{nameof(RtfParser)}: File {FileName}, opened");


        public override void Read() => Console.WriteLine($"{nameof(RtfParser)}: File {FileName}, read");

    }
}
