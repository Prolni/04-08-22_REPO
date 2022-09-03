/* Задача 60. .
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

using static System.Console;
Clear();

int x = 2;
int y = 2;
int z = 2;

int[,,] arrayXYZ = new int[x, y, z];
CreateArray(arrayXYZ);
WriteArray(arrayXYZ);

void WriteArray (int[,,] arrayXYZ)
{
  for (int i = 0; i < arrayXYZ.GetLength(0); i++)
  {
    for (int j = 0; j < arrayXYZ.GetLength(1); j++)
    {
        //Write($"({i}, {j}, ");
      for (int k = 0; k < arrayXYZ.GetLength(2); k++)
      {
        WriteLine( $"{arrayXYZ[i,j,k]}({i},{j},{k})");
      }
    }
  }
}

void CreateArray(int[,,] arrayXYZ)
{
  int[] temp = new int[arrayXYZ.GetLength(0) * arrayXYZ.GetLength(1) * arrayXYZ.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < arrayXYZ.GetLength(0); x++)
  {
    for (int y = 0; y < arrayXYZ.GetLength(1); y++)
    {
      for (int z = 0; z < arrayXYZ.GetLength(2); z++)
      {
        arrayXYZ[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
