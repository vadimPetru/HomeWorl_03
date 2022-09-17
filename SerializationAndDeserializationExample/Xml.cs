using System.Xml.Serialization;

namespace SerializationAndDeserializationExample
{
    public class Xml
    {
        public static void ConvertrXML(Shape[] Array)
        {
            Shape[] Array2 = null;
            Processing instance = new Processing();
            instance.Event += new EventHandler(instance.Working);
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
                    Array2 = (Shape[])xml.Deserialize(filestream);
                }
                foreach (var variable in Array2)
                    Console.WriteLine(variable);
            }   
            catch
            {
                Console.WriteLine("This file is not found");
                instance.InvokeMethod();

            }
        }
    }
}
