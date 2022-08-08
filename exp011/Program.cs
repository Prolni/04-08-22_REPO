Console.Clear();
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index  = 0;
    while (index < lenght)
    {
       collection[index] = new Random().Next(1, 10);

       index++;

    }
}

void PrintArray(int[] collect)
{
    int position = collect.Length;
    int count  = 0;
    while (count < position)
    {
       Console.WriteLine(collect[position]);
       count++;

    }
}

int []array = new int[10];
FillArray(array);
PrintArray(array);






