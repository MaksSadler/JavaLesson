Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numArr = new int[n];

Console.WriteLine("Введите " + n + " целых чисел через пробел:");
string[] input = Console.ReadLine().Split(" ");

int count = 0;
for (int i = 0; i < numArr.Length; i++)
{
    numArr[i] = Convert.ToInt32(input[i]);
    if (numArr[i] > 0)
    {
        count++;
    }


}
Console.WriteLine("Количество чисел больше 0: " + count);
