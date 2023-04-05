Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Max")
{
    Console.WriteLine("Yeaahhh!!!");    
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}