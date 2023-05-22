Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

int columns = rows;

int[,] result = new int[rows, columns];

void GetArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            Console.Write(result[i, j]);
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinSum()
{
    int[] sumInLines = new int[result.GetLength(0)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            sumInLines[i] += result[i, j];
        }
    }
    int minI = 0;
    for (int i = 0; i < sumInLines.Length; i++)
    {
        if (sumInLines[minI] > sumInLines[i])
        {
            minI = i;
        }

    }
    Console.Write($"Наименьшая сумма элементов: {minI+1}-ая строка.");
}
GetArray();
PrintArray();
MinSum();
