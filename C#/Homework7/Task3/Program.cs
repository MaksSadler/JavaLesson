Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < array.GetLength(0); i++)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 11);
        Console.Write(array[i, j] + " ");
    }
    
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое элементов в каждом столбце: ");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}


