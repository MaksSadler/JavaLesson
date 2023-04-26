int n = 2;

double[] numArr = new double[5];

for (int i = 0; i < numArr.Length; i++)
{
    numArr[i] = Math.Round((new Random().NextDouble()) * 100, n);

}
Console.WriteLine($"Массив значений: {String.Join(" | ", numArr)}");

double min = numArr[0];
double max = numArr[0];
for (int i = 0; i < numArr.Length; i++)
{
    if (numArr[i] < min)
    {
        min = numArr[i];
    }
    if (numArr[i] > max)
    {
        max = numArr[i];
    }
}
double a = max - min;

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine("Разница между максимальным и минимальным значением =  " + "{0:0.00}", a);