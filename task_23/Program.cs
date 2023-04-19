int a = ReadInt("N");

System.Console.WriteLine(string.Join(" ", Cube(a)));

int ReadInt(string argument)
{
    int j;
    bool checkingOnNumber;
    do
    {
        Console.Write($"Input {argument}: ");
        checkingOnNumber = int.TryParse(Console.ReadLine(), out j);
        
        if (!checkingOnNumber || j <= 0)
        {
            Console.WriteLine("It's not a number");
        }
    }
    while(!checkingOnNumber || j <= 0);

    return j;
}


int [] Cube(int a)
{
    int [] C = new int [a];

    for (int i = 1; i <= a; i ++)
    {
        C[i-1] = (int)Math.Pow(i, 3);
    }

    return C;
}
