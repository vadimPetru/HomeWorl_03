using Homework_05;


CurrencyConverter converter = new();
Print print = new();
InputData data = new();

converter.AddExchangeRates(data.EnterData()); // Entering the date in list
Console.WriteLine(converter); // showing console
Console.WriteLine($"Input exchange rate which you want to Convert from this list: {print}");
var firstAnswer = Converts(); // Converting with Boxing unboxing

Console.WriteLine($"Input  the currency you want to convert to from this list: {print}");
var secondAnswer = Converts();// Converting with Boxing unboxing

Console.WriteLine($"Input count");
var count = Convert.ToInt32(CheackCount()); // Converting with cheack on numners
Console.Clear();

converter.ConvertObject(firstAnswer, secondAnswer, count); // Add new ExchangeRate
Console.WriteLine(converter);


Currence Converts()
{
    while (true)
    {
        if (Enum.TryParse(typeof(Currence), Console.ReadLine().ToUpper(), out object firstConvert))
        {
            return (Currence)firstConvert;
        }
        else
        {
            Console.WriteLine($"You need to input from this list: {print}");
        }
    }

    return 0;
}

static string CheackCount()
{
    string right;
    while (true)
    {
        right = Console.ReadLine();
        foreach (var c in right)
        {

            if (!Char.IsDigit(c))
            {
                Console.WriteLine("You can input only numbers");
                break;
            }
            else
            {
                return right;
            }
        }
        
    }
   
}



