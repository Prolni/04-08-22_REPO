  // Задача 13: 
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
 //78 -> третьей цифры нет
 //32679 -> 6
Console.Clear();

Console.Write("Введите число: ");
long num = long.Parse(Console.ReadLine());
if (num < 100) 
Console.WriteLine($"В введенном числе: {num} третья цифра отсутствует или введенное число отрицательное, введите новое число");
else
    {
    long element = num % 10; 
    while (num > 999)
        { 
        num = (num - element) / 10; 
        element = num % 10; 
        }
    Console.WriteLine($"В введенном числе третья цифра: {element}");
    }