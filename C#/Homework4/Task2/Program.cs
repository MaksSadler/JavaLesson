Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= num; i++)
{
    sum = sum + num % 10;
    num /= 10;
}
Console.WriteLine(sum);