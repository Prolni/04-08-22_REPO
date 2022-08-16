/* Задача 19
Напишите программу, которая принимает на вход
 пятизначное число и проверяет, является 
 ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите 5-значное число для проверки палиндрома: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10000;
int b = number % 10;
int c = number / 1000 % 10;
int d = number / 10 % 10;
if (number > 99999 || number < 9999) Console.Write("Число не 5-значное. Введите 5-значное число для проверки палиндрома: : ");
else if(a == b && c == d)
Console.WriteLine($"да - число {number} является палиндромом");
else Console.WriteLine($"нет - число {number} не является палиндромом");