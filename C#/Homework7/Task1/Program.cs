Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());

double [,] array =new double [rows,columns];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
       array[i,j] = Convert.ToDouble(random.Next(-100, 101)/10.0);
       Console.Write(array[i,j]+  " ");
    }

    Console.WriteLine();
}

