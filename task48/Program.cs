/*Задача 48: Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: A = m+n. 
Выведите полученный массив на экран.*/

using static System.Console;
using System.Linq;
Clear();

WriteLine("Введите размерность двумерного массива через пробел");
int[] startArray = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray();

int[,] result = XYArray(startArray[0], startArray[1]);
PrintMatrixArray(result);


int[,] XYArray (int m, int n)
{
    int[,] inArray = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i,j] = i + j;
        }
    }
    return inArray;
}

// int[,] ArrayXY (int m, int n)
// {
//     int[,] inArray = new int [m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             inArray[i,j] = (m-1-i) + (n-1-j);
//         }
//     }
//     return inArray;
// }



void PrintMatrixArray (int [,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
    WriteLine();
    }
}