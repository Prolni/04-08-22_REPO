/* Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
using static System.Console;
Clear();

int[] array = new int[8];
void Insert_Print_Array(int[] array)
{
int length = array.Length;
int index = 0;
Write("[");
while (index < length)
{
 array[index] = new Random().Next(-10000, 10000);
 int print = array[index];
 Write(print);
 if (index == length - 1)  Write("]");
 else Write(", ");
 index++;
}
}
Insert_Print_Array(array);
//////////////////////////////////////////////////////////////////////////////////////////////////////




//////////////////////////////////////////////////////////////////////////////////////////////////////
void FillArray(int[] MyArray)
{
    int length = MyArray.Length;
    int index = 0;
    while (index < length)
    {
        MyArray[index] = new Random().Next(1, 100);
        // MyArray[index] = int.Parse(ReadLine()!);  // -> Ввод с клавиатуры
        index++;
    }
}

void SortArrayMinToMax(int[] AnyArray)
{
    for (int i = 0; i < AnyArray.Length; i++)
        for (int j = i + 1; j < AnyArray.Length; j++)
            if (AnyArray[i] > AnyArray[j])
            {
                int temp = AnyArray[i];
                AnyArray[i] = AnyArray[j];
                AnyArray[j] = temp;
            }
}

void SortArrayMaxToMin(int[] AnyArray)
{
    for (int i = 0; i < AnyArray.Length - 1; i++)
        for (int j = i + 1; j < AnyArray.Length; j++)
            if (AnyArray[i] < AnyArray[j])
            {
                int temp = AnyArray[i];
                AnyArray[i] = AnyArray[j];
                AnyArray[j] = temp;
            }
}

void PrintArray(int[] AnyArray)
{
    int length = AnyArray.Length;
    int index = 0;
    while (index < length)
    {
        Write($"{AnyArray[index]} ");
        index++;
    }
}

//int[] array = new int[8];
FillArray(array);
//PrintArray(array);
WriteLine();
SortArrayMinToMax(array);
//PrintArray(array);
WriteLine();
SortArrayMaxToMin(array);
//PrintArray(array);