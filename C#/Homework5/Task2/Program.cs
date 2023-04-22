int[] numArr = new int[4];

for(int i=0;i<numArr.Length;i++)
{
    numArr[i] = new Random().Next(-10,11);
}
Console.WriteLine(String.Join(",",numArr));
int sum = 0;

for(int a=1; a<numArr.Length; a+=2)
{
    sum+=numArr[a];
}
Console.WriteLine(sum);


