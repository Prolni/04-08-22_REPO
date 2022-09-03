/*Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

using static System.Console;
Clear();

int n = 4;
int[,] matrix = new int[n, n];

int contr = 1;
int i = 0;
int j = 0;

while (contr <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = contr;
  contr++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(matrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Write($" {array[i,j]} ");

      else Write($"{array[i,j]} ");
    }
    WriteLine();
  }
}