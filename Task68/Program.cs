/*Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.*/

int numberM = GetNumberFromUser("Введите число M: ", "Введено неверное число");
int numberN = GetNumberFromUser("Введите число N: ", "Введено неверное число");
Console.WriteLine();


Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");




int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int AckermannFunction(int numberM, int numberN)
{
    if (numberM == 0)
        return numberN + 1;
    if (numberM != 0 && numberN == 0)
    {
        return AckermannFunction(numberM - 1, 1);
    }

    if (numberM > 0 && numberN > 0)
    {
        return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    }
    return AckermannFunction(numberM, numberN);
}
