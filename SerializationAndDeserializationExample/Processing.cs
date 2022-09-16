

using SerializationAndDeserializationExample;
using System.Text.Json;
using System.Xml.Serialization;


namespace SerializationAndDeserializationExample
{
    public  class Processing
    {


        public Shape[] Array = new Shape[] { new Shape (new Point { X = 5, Y = 6 }, 3 ,6, "Rectangle"),
                                new Shape (new Point { X = 1, Y = 1 }, 3 ,3, "Circle"),
                                 new Shape (new Point { X = 3, Y = 2 }, 4 ,4, "Square"),
};

        public Shape[] array2 = null;



        public static string GetAnswerByUser()
        {
            Console.WriteLine("What will we use: Json , XML");
            string answer = Console.ReadLine().ToLower();
            return answer;
        }
        

     
        public void Working()
        {
            switch (GetAnswerByUser())
            {
               
                case "json":
                    try
                    {
                        Console.WriteLine("Filename Enters for Serialization ");
                        string forSerialization = Console.ReadLine().ToLower();
                        using (Stream filestream = new FileStream(forSerialization, FileMode.OpenOrCreate))
                        {
                            JsonSerializerOptions option = new JsonSerializerOptions();
                            option.WriteIndented = true;
                            JsonSerializer.Serialize(filestream, Array, option);
                        }
                        Console.WriteLine("Filename Enters for Deserialization ");
                        string forDeserialization = Console.ReadLine().ToLower();
                        using (Stream filestream = new FileStream(forDeserialization, FileMode.OpenOrCreate))
                        {
                            array2 = JsonSerializer.Deserialize<Shape[]>(filestream);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("This file is not found");
                        Working();
                        
                    }
                    break;

                case "xml":
                    try
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(Shape[]));
                        Console.WriteLine("Filename Enters for Serialization ");
                        string forSerialization = Console.ReadLine().ToLower();
                        using (Stream filestream = new FileStream(forSerialization, FileMode.OpenOrCreate))
                        {
                            xml.Serialize(filestream, Array);
                        }
                        Console.WriteLine("Filename Enters for Deserialization ");
                        string forDeserialization = Console.ReadLine().ToLower();
                        using (Stream filestream = new FileStream(forDeserialization, FileMode.OpenOrCreate))
                        {
                            array2 = (Shape[])xml.Deserialize(filestream);
                        }
                    }
                    catch
                    {
                        Console.WriteLine("This file is not found");
                        Working();

                    }
                    break;

                
            }

        }
    }
}
