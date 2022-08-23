/*Задача 36: 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

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
 array[index] = new Random().Next(-1000, 1000);
 int print = array[index];
 Write(print);
 if (index == length - 1)  Write("]");
 else Write(", ");
 index++;
 }
}

// Задаем второй метод для нахождения элементов на нечетных позициях, подсчета их суммы и вывода на экран полученного значения
void ChetnNumber_Array(int[] array1)
{
int length1 = array1.Length;
int index1 = 1;
int sum = 0;
while (index1 < length1)
{
 sum = sum + array1[index1];
index1 = index1 + 2;
   }
Write($"Сумма элементов на нечетных позициях в массиве равна: {sum}");
}