using HomeWork_04;

namespace HomeWork_04
{
    internal class Task1
    {
        /// <summary>
        /// The Enums for storing constants
        /// </summary>
        enum GetValue 
        {
            Max = -100,
            Min = 100
        };
        /// <summary>
        /// 
        /// </summary>
        public void Decision()
        {
         

            Console.WriteLine("Enter the size of the array");
            ArrayOneRank array = new(Convert.ToInt32(Console.ReadLine()),(int)GetValue.Max,(int)GetValue.Min);
            array.FullArray();
            Console.Write("The array before refactoring:");
            array.Show();
            Console.WriteLine(array.ToString());
            Console.Write("The array after refactoring:");
            array.BubbleSort();
            array.Show();
        }
    }
}
