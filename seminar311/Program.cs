/* Решение через методы!
Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.Clear();

Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

//int itog = Itogi(a, b); // вероятно это лишний шаг и можно сделать сразу в консоле Write

Console.Write($"{a} в степени {b} равно:  {Itogi(a, b)}");

// Добавляем метод/функцию Itogi:

int Itogi(int c, int d)
{
    int sum = 1;
    for (int i = d; i > 0; i--)
    {
        sum = sum * c;
    }
    return sum;
}
