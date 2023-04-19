/* Напишите программу, которая принимает 
на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
*/
/*
Создаём массив для двух точек, куда заносим три переменные со значением x, y and z.
Создаём переменную double, для высчета distance
Складываем мы каждые значения. Первое со выторым, третье с четвёртым и пятое с шестым.
И присваиваем им значения.
Так же создаём проверку на число, которое запрашиваем.

Запрашиваем у пользователя две точки с их координатами.
Заносим эти координаты в переменную в массиве.
0   1   2   3   4   5
x   y   z   x1  y1  z1
1   2   3   -1  -2  -3

double distance = Math.Sqrt(Math.Pow())

Дано два массива: название координат.
Верхний массив  : точка координат

Складываем через три.
Корень равен х1 - х2 в квадрате + y1-y2 в квадрате.
Высчитываем квадрат разности, вычитаем каждое из значений и, складывая, получаем корень квадратный

Вводим два первых значения
qp db ij cs
*/

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







/* int i = ReadInt3("х1");
int j = ReadInt4("х2");
int s = ReadInt1("у1");
int c = ReadInt2("у2");
int b = ReadInt5("z1");
int d = ReadInt6("z2");

int ReadInt6(string z2)
{
    Console.Write($"Input {z2}: ");

    int d;

    while (!int.TryParse(Console.ReadLine(), out d))     
    {                                                    
        Console.WriteLine("It's not a number!");        
    }                                                    

    return d;
}



int ReadInt5(string z1)
{
    Console.Write($"Input {z1}: ");

    int b;

    while (!int.TryParse(Console.ReadLine(), out b))     
    {                                                    
        Console.WriteLine("It's not a number!");        
    }                                                    

    return b;
}




int ReadInt1(string y1)
{
    Console.Write($"Input {y1}: ");

    int s;

    while (!int.TryParse(Console.ReadLine(), out s))     
    {                                                    
        Console.WriteLine("It's not a number!");        
    }                                                    

    return s;
}

int ReadInt2(string y2)
{
    Console.Write($"Input {y2}: ");

    int c;

    while (!int.TryParse(Console.ReadLine(), out c))     
    {                                                    
        Console.WriteLine("It's not a number!");        
    }                                                    

    return c;
}

int ReadInt3(string x1)
{
    Console.Write($"Input {x1}: ");
    
    int i;

    while(!int.TryParse(Console.ReadLine(), out i))
    {
        Console.WriteLine("It's not a number");
    }
    return i;
}

int ReadInt4(string x2)
{
    Console.Write($"Input {x2}: ");                                             
    
    int j;

    while(!int.TryParse(Console.ReadLine(), out j))                              // Так читается наша точка.
    {
        Console.WriteLine("It's not a number");
    }
    return j;
}

double distance = Math.Sqrt(Math.Pow(i - j, 2)) + Math.Sqrt(Math.Pow(s - c, 2)) + Math.Sqrt(Math.Pow(b - d, 2)); // рассчитываем длину от точки до точки
if (distance > 0)
{
    Console.WriteLine($"Расстояние между точками [{s}, {i}, {b}] и [{c}, {j}, {d}] равно {distance}");
}
else
{
    Console.WriteLine("Точки находятся в одном месте");
}


 */

/* int [] point = new int[6];

for (int i = 0; i < point.Length; i++)
{
    Console.Write("Введите значение: ");
    int [];
}
 */











/* 
int n = ReadInt("Точку");

int [] сoordinates = new int[6];

for (int i = 0; i < сoordinates.Length; i++)
{
    int ReadInt(string argument);

    coordinates[i] = ReadInt($"Coordinates {i + 1}");
}

int [] point = new int [6]; */



/* int x1 = ReadIntX1("x1");
int x2 = ReadIntX2("x2");
int y1 = ReadIntY1("y1");
int y2 = ReadIntY2("y2");
int z1 = ReadIntZ1("z1");
int z2 = ReadIntZ2("z2"); 
/* System.Console.WriteLine(string.Join(" ", Cube(a))); */