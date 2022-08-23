/*Задача 38: 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

using static System.Console;
Clear();
Write("Введите число для задания размера массива: ");
int a = Convert.ToInt32(ReadLine());
double[] array = new double[a];
Array(array);
WriteLine();
ChetnNumber_Array(array);

// Задаем первый метод для заполнения рандомно массива и вывода его на экран

void Array(double[] array)
{
int length = array.Length;
int index = 0;
Write("[");
while (index < length)
{
 array[index] = new Random().Next(1, 1000);
 double print = array[index];
 Write(print);
 if (index == length - 1)  Write("]");
 else Write(", ");
 index++;
 }
}

// Задаем второй метод для нахождения max и min элементов массива, вычисления их разницы и вывода на экран полученного значения
void ChetnNumber_Array(double[] array1)
{
int length1 = array1.Length;
int index1 = 1;
double max = array1[0];
double min = array1[0];
while (index1 < length1)
{
 if (max < array1[index1]) max = array1[index1];
 if (min > array1[index1]) min = array1[index1];
index1 = index1 + 1;
   }
double result = max - min;
Write($"Максимальный элемент массива: {max}, минимальный: {min}. Их разница равна: {result}");
}