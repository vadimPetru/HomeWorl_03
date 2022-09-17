using Newtonsoft.Json;


namespace SerializationAndDeserializationExample
{
    public static class Newtonsoft
    {
        public static void Converter(Shape [] Array)
        {
            Processing instance = new();
            try
            {
                Console.WriteLine("Input filename for Serialization");
                string path = @$"C:\Users\6ddd1\source\repos\HomeWorl_03\SerializationAndDeserializationExample\bin\Debug\net6.0\{Console.ReadLine()}";
                Processing processing = new Processing();
                string result = JsonConvert.SerializeObject(Array);
                File.WriteAllText(path, result);
                Console.WriteLine("Input filename for Deserialization");
                string path2 = @$"C:\Users\6ddd1\source\repos\HomeWorl_03\SerializationAndDeserializationExample\bin\Debug\net6.0\{Console.ReadLine()}";
                Shape[]? array2 = JsonConvert.DeserializeObject<Shape[]>(File.ReadAllText(path2));
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
