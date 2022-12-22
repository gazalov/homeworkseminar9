Console.Clear();

int AkkermanFunction(int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AkkermanFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AkkermanFunction(numberM - 1, AkkermanFunction(numberM, numberN - 1));
    return AkkermanFunction(numberM, numberN);
}

int NumberEntry(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int numberM = NumberEntry("Введите неотрицательное число M: ");
int numberN = NumberEntry("Введите неотрицательное число N: ");

if (numberM >= 0 && numberN >= 0 )
{
    Console.WriteLine($"Функция Аккермана для чисел {numberM} и {numberN} равна {AkkermanFunction(numberM, numberN)}.");
}
else
{
    Console.WriteLine($"Вы ввели отрицательные числа, повторите ввод.");
}