Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

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

void SortArray()
{
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1) - 1; k++)
            {
                if (result[i, k] < result[i, k + 1])
                {
                    int temp = result[i, k + 1];
                    result[i, k + 1] = result[i, k];
                    result[i, k] = temp;
                }
            }
        }
    }
}

GetArray();
PrintArray();
SortArray();
PrintArray();
