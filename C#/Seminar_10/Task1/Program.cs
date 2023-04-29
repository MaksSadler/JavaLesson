// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array =new  int [rows,columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//        array[i,j] = new Random().Next(0,10);
//        Console.Write(array[i,j]+  " ");
//     }

//     Console.WriteLine();
// }


// Console.WriteLine("Введите число: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int collumns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows,collumns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = i + j;
//         Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
// }


// Задача 49: Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }
// Console.WriteLine("______");
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if ((i % 2 == 0) && (j % 2 == 0))
//         {
//             array[i, j] = array[i, j] * array[i, j];
//         }

//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// Console.WriteLine("Введите число");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[rows, columns];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().Next(0, 10);
//         Console.Write(array[i, j] + " ");
//     }

//     Console.WriteLine();
// }
// Console.WriteLine("______");

// int sum = 0;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if (i == j)
//         {
//             sum = sum + array[i, j];
//         }
//     }
// }

// Console.WriteLine("Сумма " + sum);





