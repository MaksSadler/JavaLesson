int[] numArr = new int[4];

int temp = 0;
for(int i=0;i<numArr.Length;i++)
{
    numArr[i] = new Random().Next(100,1000);

    if(numArr[i]%2 == 0)
    {
        temp+=1;
    }

}
Console.WriteLine(String.Join(",",numArr));
Console.WriteLine("Количество чётных чисел в массиве: "+temp);
