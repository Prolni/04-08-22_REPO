using static System.Console;
Clear();

WriteLine("Введите размерность двумерного массива через пробел");
int[] startArray = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=> int.Parse(x)).ToArray();

int[,] result = GetMatrixArray(startArray[0], startArray[1], startArray[2], startArray[3]);
PrintMatrixArray(result);



int[,] GetMatrixArray(int rows,int colums, int minValue, int maxValue)
{
   int[,] result=new int[rows,colums];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue+1);
        }
   }
   return result;
}

void PrintMatrixArray(int[,] inArray)
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
