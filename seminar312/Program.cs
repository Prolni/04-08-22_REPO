/* Решение через методы!
Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Clear();

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

//int itog = Itogi(a); // вероятно это лишний шаг и можно сделать сразу в консоле Write

Console.Write($"Сумма цифр числа {a} равна:  {Itogi(a)}");

// Добавляем метод/функцию Itogi:

int Itogi(int x)
{
    if(x < 0) x = -1 * x;
    
    int sum = x % 10;
    
    while (x / 10 > 0)
    {
        sum = sum + x / 10 % 10;
        x = x / 10;
    }
    return sum;
}