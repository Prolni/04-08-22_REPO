/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
using static System.Console;
Clear();

int m = Convert.ToInt32(ReadLine());
int n = Convert.ToInt32(ReadLine());
int[,] array = new int[m, n];

CreateArray(array);
WriteLine();
PrintArray(array);
WriteLine();
SumStroka();

void CreateArray(int[,] array) //создаем массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

void PrintArray(int[,] array) // печатаем массив
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Write(array[i, j] + " ");
    }
    WriteLine();
  }
}

void SumStroka() //в кач-ве миним принимаем сумму первой строки -> находим минимальную строку -> выводим номер строки
{
  int sumMin = 0;
  for (int j = 0; j < array.GetLength(1); j++)
        {
            sumMin += array[0, j];
        }
   
  int nomberStr = 0;
  for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
            if (sum < sumMin) {sumMin = sum; nomberStr = i;}
    }
        WriteLine($"минимальная сумма по строке - {sumMin},");
    WriteLine($"номер строки с минимальной суммой - {nomberStr},");
}
