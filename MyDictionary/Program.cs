using MyDictionary;

ApplicationDictionary<string , string> Dictionary = new();



Dictionary.AddElement("Book", "Книга");
Dictionary.AddElement("Snake", "Змея");
Dictionary.AddElement("Car", "Машина");

Dictionary.ShowKey();
Console.WriteLine(new string('-', 30));


Dictionary.RemoveElement("Book", "Книга");
Dictionary.ShowKey();


Console.WriteLine(new string('-', 30));
Console.WriteLine(Dictionary.SerchElementByKey("Car")  ); 

