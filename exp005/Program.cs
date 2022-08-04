// See https://aka.ms/new-console-template for more information
Console.WriteLine("Определяем по верности введения имени");
Console.Write("Введите Ваше Имя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
  Console.WriteLine("Здравствуйте, Маша!");
}
else
{
Console.Write("Привет, ");
Console.WriteLine(userName);
}