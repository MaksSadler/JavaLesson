int M = ReadInt("Введите число M: ");
int N = ReadInt("Введтите число N: ");

Sum(M, N);

void Sum(int M, int N)
{
    Console.Write(SumMN(M - 1, N));
}

int SumMN(int M, int N)
{
    int res = M;
    if (M == N)
    {
            return 0;
    }
    else
    {
        M++;
        res = M + SumMN(M, N);
        return res;
    }
}

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
