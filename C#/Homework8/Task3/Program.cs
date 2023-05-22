Console.WriteLine("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[rows1, columns1];
int[,] secondMartrix = new int[rows2, columns2];
int[,] resultMatrix = new int[rows1, columns2];

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 6);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}
if (columns1 == rows2)
{
    GetArray(firstMartrix);
    Console.WriteLine("Первая матрица:");
    PrintArray(firstMartrix);
    GetArray(secondMartrix);
    Console.WriteLine("Вторая матрица:");
    PrintArray(secondMartrix);
    MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
    Console.WriteLine("Произведение первой и второй матриц:");
    PrintArray(resultMatrix);
}
else
{
    Console.WriteLine("необходимо чтобы число столбцов матрицы 1 было равно числу строк матрицы 2.");
}