
TimerCallback tm = new TimerCallback(Square);
Timer timer = new Timer(tm, 2, 0, 2000);
Console.ReadLine();
void Square(object obj)
{
    int number = (int)obj;
    Console.WriteLine(number * number);
}