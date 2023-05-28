int M = ReadInt("Введите число M: ");
int N = ReadInt("Введтите число N: ");

int functionAkerman = Ack(M, N);

Console.Write($"Функция Аккермана = {functionAkerman} ");

int Ack(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }

    else if (N == 0)
    {
        return Ack(M - 1, 1);
    }
    else
    {
        return Ack(M - 1, Ack(M, N - 1));
    }
}

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}