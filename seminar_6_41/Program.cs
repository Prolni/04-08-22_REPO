/* Задача 41: 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
using static System.Console;
Clear();

Write("Введите числа через запятую: ");
int[] matrix = Array.ConvertAll(ReadLine()!.Split(","), int.Parse);
int itog = matrix.Count(x => x > 0);
WriteLine($"Кол-во введеных чисел, которые больше 0: {itog}");