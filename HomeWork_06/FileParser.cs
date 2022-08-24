using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_06
{
    public abstract class FileParser
    {
        protected string FileName;
        public abstract string ParserFormat { get; }
         
        public FileParser(string FileName) => this.FileName = FileName;
        public abstract void Read();
        public abstract void Open();
        public abstract void Analize();
        public abstract void Close();

       public virtual void Parse()
        {
            Open();
            Read();
            Analize();
            Close();

        }

        public static FileParser GetParser(string [] FileName)
        {
            return FileName[FileName.Length-1].ToLower() switch
            {
                nameof(FileFormat.html) => new HtmlParser(FileName[0]),
                nameof(FileFormat.xml) => new XmlParser(FileName[0]),
                nameof(FileFormat.rtf) => new RtfParser(FileName[0]),
                _ => null,
            };
        }

    }
}

/*
 * c абстрактными методами void Read(), void Open(), void Analize(), void Close() и виртуальным методом void Parse().
 * Необходимо создать абстрактное свойство только для чтения string ParserFormat. 
 * Так же класс должен иметь поле только для чтения FileName. Конструктор должен принимать параметр типа string.
 * В конструкторе необходимо устанавливать поле FileName.
 * В классе реализовать статический метод public static FileParser GetParser(string fileName),
 * который создает экземпляр одного из классов XmlParser, RtfParser, HtmlParser, на основании имени файла,
 * т.е. нужно получить формат файла из его имени. Ели такого парсера нет, то возвращать null. 
 * В методе Parse нужно последовательно вызывать методы Open();Read();Analize(); Close()
  - Классы XmlParser, RtfParser, HtmlParser, которые наследуют от класса FileParser. 
Каждый метод реализовать примерно
так:   void Read() { Console.WriteLine("{nameof(XmlParser)}: Файл {fileName}, был открыт"); }.
Реализовать свойство ParserFormat. Например для класса XmlParser - ParserFormat { get => ".xml" }
*/