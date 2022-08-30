/*Задача 50:
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;

Clear();

Write("Введите номер строки от 0: ");
int strok = Convert.ToInt32(ReadLine());

Write("Введите номер столбца от 0: ");
int stolb = Convert.ToInt32(ReadLine());

int n = 8; int m = 8; // размерность двумерного массива
int[,] arr = new int[n, m];


WriteLine("МАССИВ:");

void FillArray(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Write("{0} ", arr[i, j]);
        }
        WriteLine();
    }
}
// Поиск числа в массиве

void FindNumber(int n, int m)
{
    if (strok < 0 | strok > arr.GetLength(0) - 1 |
        stolb < 0 | stolb > arr.GetLength(1) - 1)
    {
        WriteLine("такого числа в массиве нет");
    }
    else
    {
        WriteLine("Число массива = {0}", arr[strok, stolb]);
    }
}
FillArray(arr);
FindNumber(n, m);