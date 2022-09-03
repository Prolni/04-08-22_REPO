/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
using static System.Console;
Clear();

int[,] massiv = new int[2, 2];
int[,] massiv1 = new int[2, 2];
int[,] multiMassiv = new int[2, 2];
FillArray(massiv, massiv1);
PrintArray(massiv, massiv1);
WriteLine();
Composition(massiv, massiv1, multiMassiv);
PrintCompArray(multiMassiv);

void FillArray(int[,] array, int[,] array2)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = new Random().Next(1, 5);
        }
    }
    for (int m = 0; m < array2.GetLength(0); m++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            array2[m, n] = new Random().Next(1, 5);
        }
    }
}

void PrintArray(int[,] array, int[,] array2)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Write($"{array[m, n]} ");
        }
        WriteLine();
    }
    WriteLine();
    for (int m = 0; m < array2.GetLength(0); m++)
    {
        for (int n = 0; n < array2.GetLength(1); n++)
        {
            Write($"{array2[m, n]} ");
        }
        WriteLine();
    }
}

void Composition(int[,] array, int[,] array2, int[,] multiMassiv)
{
  for (int i = 0; i < multiMassiv.GetLength(0); i++)
  {
    for (int j = 0; j < multiMassiv.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array.GetLength(1); k++)
      {
        sum += array[i,k] * array2[k,j];
      }
      multiMassiv[i,j] = sum;
    }
  }
}

void PrintCompArray(int[,] multiMassiv)
{
    for (int m = 0; m < multiMassiv.GetLength(0); m++)
    {
        for (int n = 0; n < multiMassiv.GetLength(1); n++)
        {
            Write($"{multiMassiv[m, n]} ");
        }
        WriteLine();
    }
}
