namespace SerializationAndDeserializationExample
{
    public delegate void EventHandler();  
    public class Processing
    {
        
        public event EventHandler Event = null;
        public void InvokeMethod()
        {
            Event.Invoke();
        }

        public Shape[] Array =  { new Shape (new Point { X = 5, Y = 6 }, 3 ,6, nameof(ShapeType.Rectangle)),
                                new Shape (new Point { X = 1, Y = 1 }, 3 ,3, nameof(ShapeType.Circle)),
                                 new Shape (new Point { X = 3, Y = 2 }, 4 ,4, nameof(ShapeType.Square)),
        };

        public static string GetAnswerByUser()
        {
            Console.WriteLine("What will we use: Json , XML,newtonsoft");
            string answer = Console.ReadLine().ToLower();
            return answer;
        }



        public void Working()
        {
            switch (GetAnswerByUser())
            {
                case "json":
                    JSON.ConverterJson(Array);
                    break;
                case "xml":
                    Xml.ConvertrXML(Array);
                    break;
                case "newtonsoft":
                    Newtonsoft.Converter(Array);
                    break;
                default:
                    Console.WriteLine("You need to choice from json,xml,newtonsoft");
                    Working();
                    break;
            }

        }
    }
}
