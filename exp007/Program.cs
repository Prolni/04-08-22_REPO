Console.Clear();
Console.WriteLine("Задаем цикл поиска середины отрезка: ");
//Console.SetCursorPosition(6, 2);
//Console.WriteLine("*");
int ax = 40;
int ay = 1;
int bx = 1;
int by = 20;
int cx = 80;
int cy = 20;
Console.SetCursorPosition(ax, ay);
Console.WriteLine("A");
Console.SetCursorPosition(bx, by);
Console.WriteLine("B");
Console.SetCursorPosition(cx, cy);
Console.WriteLine("C");
int x = ax;
int y = ay;
int count = 0;
while (count < 100000)
{
    int rand = new Random().Next(0, 3); // из интервала 0,1,2
    if (rand == 0)
    {x = (x + ax)/2;
     y = (y + ay)/2;        
    }
    if (rand == 1)
    {x = (x + bx)/2;
     y = (y + by)/2;        
    }
    if (rand == 2)
    {x = (x + cx)/2;
     y = (y + cy)/2;        
    }
Console.SetCursorPosition(x+1, y+1); // добавили смещение +1 чтобы не стирал вршины АВС
Console.WriteLine("*");
count = count + 1;
}
Console.SetCursorPosition(22, 22);
Console.WriteLine("Получаем треугольник Серпинского");