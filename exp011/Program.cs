Console.Clear();
void FillArray(int [] collection)
{
    int lenght = collection.Length;
    int index  = 0;
    while (index < lenght)
    {
       collection[index] = new Random().Next(1, 10);
      //Console.WriteLine(collection[index]);
       index++;

    }
}

void PrintArray(int[] collect)
{
    int position = collect.Length;
    int count  = 0;

    while (count < position)
    {
       Console.WriteLine(collect[count]);
       count++;
       // Console.WriteLine(count);
    }
}

int []array = new int[10];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int[] theArray = { 1, 3, 5, 7, 9 };
theArray[2] = 2;
PrintArray(theArray);




