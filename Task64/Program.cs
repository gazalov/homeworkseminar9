Console.Clear();

void NumbersLineReverse(int firstNumber, int numberN)
{
    if (firstNumber <= numberN)
    {
        NumbersLineReverse(firstNumber + 1, numberN);
        Console.Write(firstNumber + " ");
    }
}

int NumberEntry(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int firstNumber = 1;

int numberN = NumberEntry("Введите число N: ");

NumbersLineReverse(firstNumber, numberN);
