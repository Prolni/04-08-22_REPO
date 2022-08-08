// массив
int Max(int arg1, int arg2, int arg3) //создаем метод поиска максимального max_array числа из ммассива
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int [] array =  {21, 42, 3500, 48, 65, 106, 67, 98, 98};
array[0] = 12; //для внесения измен в элемент по позиции массива

int max_array = Max(Max(array[0], array[1], array[2]), Max(array[3], array[4], array[5]), Max(array[6], array[7], array[8]));
Console.WriteLine(max_array);
