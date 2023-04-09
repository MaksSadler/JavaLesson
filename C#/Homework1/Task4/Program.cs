Console.WriteLine("Ввелите число");
int number = Convert.ToInt32(Console.ReadLine());
int even = 1;
while (even < number)
{
    Console.WriteLine(even+1);
    even+=2;
}
