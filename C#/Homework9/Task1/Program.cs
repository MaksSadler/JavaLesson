Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumbers(N, count);

void PrintNumbers(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        PrintNumbers(n, count + 1);
        Console.Write(count + " ");
    }
}