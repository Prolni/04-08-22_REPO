/*Задача 43: 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
using static System.Console;
Clear();


WriteLine("Введите через Enter коэф-ты b1, k1, b2 , k2");
Point(double.Parse(ReadLine()!), double.Parse(ReadLine()!), double.Parse(ReadLine()!), double.Parse(ReadLine()!));
double Point(double b1, double k1, double b2, double k2)
{
    double x = 0;
    x = (b2 - b1) / (k1 - k2);
    Write($"({x}, ");
    Write($"{(k1 * (b2 - b1)) / (k1 - k2) + b1})");
    return x;

}


