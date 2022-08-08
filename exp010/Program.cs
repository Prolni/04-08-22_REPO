// поиск индекса заданного числа
int [] array =  {21, 42, 3500, 48, 65, 106, 67, 908, 908};

int n = array.Length;

int find = 908;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //для окончания поиска, чтобы не вывоились все позиции одинаковых чисел
    }
          
    index++; //  index = index + 1

}