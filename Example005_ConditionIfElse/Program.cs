Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "борис")
{
    Console.WriteLine("Ура, это же Борис!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}