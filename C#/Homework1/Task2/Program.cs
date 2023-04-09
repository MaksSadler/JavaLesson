Console.WriteLine("Введите первое число: ");
int number1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3=Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (number1 > number2 && number1 > number3)
{
   Console.WriteLine("Максимальное число: " + number1); 
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine("Максимальное число: " + number2);
}
else if (number3 > number1 && number3 > number2)
{
    Console.WriteLine("Максимальное число: " + number3);
}
else 
{
    Console.WriteLine("Пожалуйста, введите три разных числа");
}