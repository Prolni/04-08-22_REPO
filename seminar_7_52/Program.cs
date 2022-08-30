﻿/* Задача 52:
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

using System;
using static System.Console;

Clear();

Random random = new Random();
int[,] arr = new int[random.Next(2, 5), random.Next(2, 5)];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}

void FindSrednee()
{
   for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Write($"{sum / arr.GetLength(0)}; ");
    }
}
FillArray(arr);
WriteLine("Среднее арифметическое по столбцам:");
FindSrednee();
