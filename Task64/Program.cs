Console.Clear();

/* Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от N до M.*/


int M = GetNumberFromUser("Введите число M: ", "Введено неверное число");
int N = GetNumberFromUser("Введите число N: ", "Введено неверное число");

if (N < M){
    Console.WriteLine("Ошибка! N < M ");
    return;
}

string result =OutputRecursion(M, N);

Console.WriteLine($"N = {N}, M = {M} -> {result}");




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

static string OutputRecursion(int m, int n)
{
if(m == n)
{
    return n.ToString();
}
else return   n + ", " + OutputRecursion(m , n - 1);
}
