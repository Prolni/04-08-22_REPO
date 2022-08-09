//Задача 4: 
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите первое число: ");
int numb1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numb2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numb3 = int.Parse(Console.ReadLine());

if(numb1 == numb2 & numb1 == numb3)
Console.WriteLine($" Три введеных числа равны: {numb1}, попробуйте снова ввести три разных числа! ");

int max = numb1;
if(numb2 > max) max = numb2;
if(numb3 > max) max = numb3;

Console.WriteLine($" Наибольшее число из введенных: {max}");

// Итог: выводит большее число из 3х введенных или указывает, что введенные числа одинаковы.