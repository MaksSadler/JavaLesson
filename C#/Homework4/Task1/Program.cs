Console.WriteLine("Введите целое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень целого числа");
int num2 = Convert.ToInt32(Console.ReadLine());

int temp = 1;

for (int i = 1; i<=num2; i++)
{
    temp=temp*num1;
}
Console.WriteLine(temp);