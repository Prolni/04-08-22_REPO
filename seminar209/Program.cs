/*Задача 23
Напишите программу, которая принимает
 на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.Clear();

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int n = 1; n <= N; n++)
{
    int cube_n = n * n * n;
    if (n == N)
    {
        Console.Write(cube_n);
    }
    else
    {
        Console.Write(cube_n + ", ");
    }
 }