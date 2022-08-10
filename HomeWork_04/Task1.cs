using HomeWork_04;

namespace HomeWork_04
{
    internal class Task1
    {
        public void Decision()
        {
            Console.WriteLine("Enter the size of the array");
            ArrayOneRank array = new(Convert.ToInt32(Console.ReadLine()));
            array.FullArray();
            Console.Write("The array before refactoring:");
            array.Show();
            Console.WriteLine();
            Console.WriteLine($"Maximum:{array.SerchMax()},\nMinimum:{array.SerchMin()},\nSum of elements:{array.Sum()},\n" +
                $"ArithmeticValue:{array.Arithmetic()}.");
            Console.Write("The array after refactoring:");
            array.BubbleSort();
            array.Show();
        }
    }
}
