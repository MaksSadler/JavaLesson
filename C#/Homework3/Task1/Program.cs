Console.WriteLine("Введите пятизначное значение: ");
string input = Console.ReadLine();
int len = input.Length;

if (len == 5)
{
    if (input[0] == input[4] && input[1] == input[3])
    {
        Console.WriteLine($"{input} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{input} - Не палиндром");
    }
}
else
{
    Console.WriteLine($"{input} - не является пятизначным значением");
}