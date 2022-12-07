//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void ShowNumbers (int N)
{
    if (N >= 1)
    {
        Console.Write(N + " ");
        ShowNumbers(N - 1);
    }
}
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
ShowNumbers (N);

//Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

/*int FindSum (int M, int N)
{
    if (N < M) return 0;
    else
    {
        return N + FindSum (M, N - 1);
    }
}

Console.WriteLine ("Введите начало промежутка");
int M = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите конец промежутка");
int N = Convert.ToInt32 (Console.ReadLine());
Console.Write ($"{M} -> {N} = {FindSum (M, N)}");*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*int Ackerman (int n, int m)
{
    while (n != 0)
    {
        if (m == 0)
        {
            m = 1;
        }
        else
        {
            m = Ackerman (n, m - 1);
        }
        n = n - 1;
    }
    return m + 1;
}

Console.WriteLine ("Введите число n");
int n = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите число m");
int m = Convert.ToInt32 (Console.ReadLine());
Console.Write($"m = {n}, n = {m} -> {Ackerman (n, m)}");*/