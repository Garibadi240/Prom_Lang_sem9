Console.Clear();

/* Задайте значения M и N. Напишите программу, которая
найдёт сумму натуральных элементов в промежутке от M до N.*/


int M = GetNumberFromUser("Введите число M: ", "Введено неверное число");
int N = GetNumberFromUser("Введите число N: ", "Введено неверное число");
Console.WriteLine();

if (N < M)
{
    Console.WriteLine("Ошибка! N < M ");
    return;
}

int result = OutputRecursion(M, N);

Console.WriteLine($"M = {M}, N = {N} -> {result}");




int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int OutputRecursion(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else
        return m + OutputRecursion(m + 1, n);
}
