int [] x = new int [2];
int [] y = new int [2];
int [] z = new int [2];

for (int i = 0; i < 2; i ++)
{
    Console.WriteLine($"Введите координаты точки {i + 1}: ");
    x[i] = ReadInt($"x{i + 1}");
    y[i] = ReadInt($"y{i + 1}");
    z[i] = ReadInt($"z{i + 1}");
}

double distance = Math.Sqrt(Math.Pow(x[0] - x[1], 2) + Math.Pow(y[0] - y[1], 2) + Math.Pow(z[0] - z[1], 2));

if (distance > 0)
{
    Console.WriteLine($"Расстояние между точками [{x[0]}, {y[0]}, {z[0]}] и [{x[1]}, {y[1]}, {z[1]}] равно {distance}");
}
else
{
    Console.WriteLine("Точки лежат друг на друге");
}


int ReadInt(string coordinates)
{
    Console.Write($"Введите значение {coordinates}: ");
    int s;

    while (!int.TryParse(Console.ReadLine(), out s))
    {
        Console.WriteLine("Ошибка при вводе числа");
        Console.Write($"Введите значение {coordinates}: ");
    }
    return s;
}