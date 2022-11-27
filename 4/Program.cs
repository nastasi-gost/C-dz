//Напишите цикл, который принимает на вход два числа (A и B),
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

/*int FindResult (int A, int B)
{
    int num = A;
    for (int i = 1; i < B; i++)
        {
            num = num * A;
        }
    return num;
}

Console.WriteLine ("Input number A");
int A = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input number B");
int B = Convert.ToInt32 (Console.ReadLine());
int result = FindResult (A, B);
Console.WriteLine ($"Число {A} в степени {B} -> {result}");*/

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int FindSum (int a)
{
    int sum = 0;
    {
        while (a > 0)
            {
                sum = sum + (a % 10);
                a = a / 10;
            }
    }
    return sum;
}

Console.WriteLine ("Input number");
int number = Convert.ToInt32 (Console.ReadLine());
int result = FindSum (number);
Console.WriteLine ($"{number} -> {result}");*/

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*int[] GreatRandomArray (int size, int min, int max)
{
    int [] newArray = new int [8];
    for (int i = 0; i < 8; i++)
        {
        newArray[i] = new Random().Next(min, max + 1);
        }
    return newArray;
}

void ShowArray (int[] array)
{
    Console.Write ("Массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
}

Console.WriteLine("Введите минимум");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимум");
int max = Convert.ToInt32(Console.ReadLine());
int [] MyArray = GreatRandomArray (8, min, max);
ShowArray (MyArray);*/