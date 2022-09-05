/*Задача 64: Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/
using static System.Console;
Clear();

WriteLine("Задайте два числа через Enter: ");

int n = int.Parse(ReadLine());
int m = int.Parse(ReadLine());

void Natural(int m, int n)
{
       if (m <= n) 
    {
        Write($"{n} ");
        if (m == n) return;
        Natural(n - 1, m);
    }
    else if (m >= n)
    {
        Write($"{m} ");
        if (m == n) return;
        Natural(m - 1, n);        
    }
}
Natural(n, m);