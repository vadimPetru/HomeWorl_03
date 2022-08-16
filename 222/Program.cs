int first = int.Parse(Console.ReadLine());
Console.WriteLine("введите кол-во столбцов");
int second = int.Parse(Console.ReadLine());
int[,] array = new int[first, second];
Console.WriteLine("вывод двумерного массива");
for (int i = 0; i < first; i++)
{
    for (int k = 0; k < second; k++)
    {
        array[i, k] = new Random().Next(0, 9);
        Console.Write(array[i, k] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("cортировка элементов матрицы по убыванию");
for (int i = 0; i < first; i++)
{
    for (int k = 0; k < second - 1; k++)
    {
        for (int j = 0; j < second - 1; j++)
        {
            if (array[i, j] < array[i, j + 1])
            {
                int smallerElement2 = array[i, j];
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = smallerElement2;
            }
        }
    }
}
for (int i = 0; i < first; i++)
{
    for (int j = 0; j < second; j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}