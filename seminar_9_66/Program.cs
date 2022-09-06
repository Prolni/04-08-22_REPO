/* Задача 66: 
Задайте значения M и N.
Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;
Clear();


int m = InputNumbers("Ведите первое число диапазона: ");
int n = InputNumbers("Ведите второе число диапазона: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Write($"Сумма чисел в заданном диапазоне: {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}