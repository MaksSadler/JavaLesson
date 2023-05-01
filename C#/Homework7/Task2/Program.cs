Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию строки: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию столбца: ");
int num2 = Convert.ToInt32(Console.ReadLine());

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
if (num1 <= 0 || num2 <= 0)
Console.WriteLine("Позиции строк не могут быть отрицательными либо равными нулю");
else if (num1 <= columns-1 && num2 <= rows-1)
Console.WriteLine($"Значение элемента равно {array[num1-1,num2-1]}");
else Console.WriteLine("Такого элемента нет в массиве");
