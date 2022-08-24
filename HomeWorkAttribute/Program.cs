using HomeWorkAttribute;
using System.Reflection;

Worker worker = new();
Manager manager = new();
Director director = new();


GetAccess(worker, AccesLevelType.Average);
GetAccess(manager, AccesLevelType.Low);
GetAccess(director, AccesLevelType.High);
void GetAccess(Employee employee , AccesLevelType level)
{
   
    Type type = employee.GetType();
    object [] attributes = type.GetCustomAttributes(typeof(AccessLevelAttribute), true);
    if(attributes.GetLength(0) != 0)
    {
       foreach(AccessLevelAttribute attribute in attributes)
        {
            if (attribute.Number <= (int)level) { Console.WriteLine($"Доступ разрешен"); }
            else { Console.WriteLine($"Доступ запрещен"); }
        }
    }
    

   
}