using System.Text.Json;

namespace SerializationAndDeserializationExample
{
    public class JSON
    {
        public static void ConverterJson(Shape[] Array )
        {
            Processing instance = new();
            instance.Event += new EventHandler(instance.Working);
            Shape[] array2 = null;
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
                foreach (var variable in array2)
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
