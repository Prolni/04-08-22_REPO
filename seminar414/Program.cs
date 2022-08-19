/* Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

using static System.Console;
Clear();
Write("Введите число для задания размера массива: ");
int a = Convert.ToInt32(ReadLine());
int[] array = new int[a];
Array(array);
WriteLine();
ChetnNumber_Array(array);

// Задаем первый метод для заполнения рандомно массива и вывода его на экран

void Array(int[] array)
{
int length = array.Length;
int index = 0;
Write("[");
while (index < length)
{
 array[index] = new Random().Next(100, 1000);
 int print = array[index];
 Write(print);
 if (index == length - 1)  Write("]");
 else Write(", ");
 index++;
 }
}

// Задаем второй метод для нахождения, подсчета и вывода на экран количества положительных чисел в заполненном выше массиве:

void ChetnNumber_Array(int[] array1)
{
int length1 = array1.Length;
int index1 = 0;
int sum = 0;
while (index1 < length1)
{
 int control = array1[index1];
 control = control % 2;
 if (control == 0)  sum = sum + 1;
 index1++;
   }
Write($"Всего в массиве четных чисел: {sum}");
}