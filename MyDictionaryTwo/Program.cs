using MyDictionaryTwo;

ApplicationDictionary<string, string> Dictionary = new();

Dictionary.AddElement("Book", "Книга");
Dictionary.AddElement("Cool", "Класный");
Dictionary.AddElement("Duck", "Утка");
Dictionary.ShowAllElements();
// Elenemt adds in this list
Console.WriteLine(new String('-',100));
Dictionary.RemoveElement("Cool", "Класный");
Dictionary.ShowAllElements();
// Element remove in this list

Console.WriteLine(new String('-', 100));
Console.WriteLine(Dictionary.SerchElement("Duck"));

// I found the element in this list in this line 
Console.WriteLine(new String('-', 100));

Dictionary.Show();