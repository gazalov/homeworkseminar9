Console.Clear();

int NumbersLineReverse(int numberM, int numberN)
{
    if (numberM == numberN) return numberM;
    return NumbersLineReverse(numberM + 1, numberN) + numberM;
}

int NumberEntry(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numberM = NumberEntry("Введите число M: ");
int numberN = NumberEntry("Введите число N: ");

Console.WriteLine($"Сумма натуральных элементов от {numberM} до {numberN} равна {NumbersLineReverse(numberM, numberN)}.");