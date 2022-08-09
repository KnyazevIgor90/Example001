Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ura, this is Masha");
}
else
{
    Console.Write("Hello,");
    Console.Write(username);
}