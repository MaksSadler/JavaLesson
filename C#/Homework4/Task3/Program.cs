
int[] numArr = new int[8];
Console.WriteLine("Введите 8 целых чисел через пробел:");
string[] input = Console.ReadLine().Split(" ");
for(int i=0;i<numArr.Length;i++)
{
    
    numArr[i] = Convert.ToInt32(input[i]);
    
}
Console.Write($"Введенные эелементы массива: {string.Join(",",numArr)}");

    

