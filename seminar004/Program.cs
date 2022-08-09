// Задача 8: 
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if(num <= 0)
Console.WriteLine($"Введенное число: {num}, меньше или равно 0, введите число более 0!");

int control = num % 2;
if (control == 0)
{

while( num > 0)
{
Console.WriteLine(num);
num = num -2;
}
}
else
{while( num > 1)
{
Console.WriteLine(num-1);
num = num -2;
}
}

// Итог: принимает число (N), а на выходе показывает все чётные числа от 1 до N.

