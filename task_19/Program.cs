int number = ReadInt("number");
int numberCopy = number;

int ReadInt(string argument)
{
    int n;
    bool checkingNumber;
    do
    {
        Console.Write($"Input {argument} check on palindrom: ");

        checkingNumber = int.TryParse(Console.ReadLine(), out n);

        if (!checkingNumber || n < 10000 || n > 99999)
        {
            Console.WriteLine("It's not a number or not a five-digit number");
        }
    }

    while (!checkingNumber || n < 10000 || n > 99999);
    return n;
}

int[] number2 = new int[5];

for (int i = number2.Length - 1; i >= 0; i--)
{
    number2[i] = number % 10;
    number /= 10;
}

int[] number3 = new int[5];

for (int i = number3.Length - 1; i >= 0; i--)
{
    number3[i] = number2[number3.Length - 1 - i];
}

bool isPalindrome = true;
for (int i = 0; i < number2.Length; i++)
{
    if (number2[i] != number3[i])
    {
        isPalindrome = false;
        break;
    }
}

if (isPalindrome)
    Console.WriteLine($"{numberCopy} is a palindrome");
else
    Console.WriteLine($"{numberCopy} is not a palindrome");