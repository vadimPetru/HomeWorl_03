


using SerializationAndDeserializationExample;
using Newtonsoft.Json;



Processing processing = new();
processing.Working();

Console.WriteLine("Newtonsoft.Json");
string result = JsonConvert.SerializeObject(processing.Array);
Console.WriteLine(result);
processing.array2 = JsonConvert.DeserializeObject<Shape[]>(result);
foreach(var variable in processing.array2)
{
    Console.WriteLine($"Name:{variable.Name}, Height:{variable.Height}, Length{variable.Length}" +
        $", X:{variable.ShapePoint.X} , Y:{variable.ShapePoint.Y}");
}








//В методе Main создать массив из заполненных элементов типа Shape.
//Выполнить сериализацию и десериализацию этого массива.
//Название файла для сериализации и десериализации вводить с клавиатуры.
//Сериализуемые форматы XML и JSON. Так же необходимо использовать блоки для обработки исключений.
//После выполнения задания, скачать nuget-пакет Newtonsoft.Json.
//Попробовать выполнить сериализацию с помощью Json сериализатора из этого пакета