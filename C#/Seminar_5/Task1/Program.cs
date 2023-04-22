// Демонстрация решения
// Задача 24: Напишите программу,
//  которая принимает на вход число (А) 
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.WriteLine("Введите число");                         
// int number = Convert.ToInt32(Console.ReadLine());   

// int GetSumNum()
// {
//     int sum =0;
//     int count =0;

//    while (number>count)
//    {
//     count++;
//     sum+=count;
//     // sum= sum+count;
//    }

//     return sum;
// }

//  Console.WriteLine(GetSumNum());


// Задача 26: Напишите программу,
// которая принимает на вход число
//  и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int value = Convert.ToInt32(Console.ReadLine());
// int count=0;

// while(value > 0)
// {
//     count++;
//     value = value / 10;
// }
// Console.WriteLine(count);


//Вариант 2

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int getNumCount(){
//     return number.ToString().Length;
// }
// Console.WriteLine
// ("Количество цифр в числе: " + getNumCount());


// Задача 28: Напишите программу, 
// которая принимает на вход число N
//  и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int temp = 1;

// for (int i = 1; i<=num; i++)
// {
//     temp=temp*i;
// }
// Console.WriteLine(temp);


// Задача 30: Напишите программу,
// которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] numArr = new int[8];

for(int i=0;i<numArr.Length;i++){
    numArr[i] = new Random().Next(0,2);
    Console.Write(numArr[i] + " ");
}
