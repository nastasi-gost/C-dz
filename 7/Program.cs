//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

/*double[,] Create2DRandomArray (int minValue, int maxValue, int rows, int columns)
{
    double[,] newArray = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }
    return newArray;
}
void Show2DArray (double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write ($"{Math.Round(array[i,j], 1)}; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите количество строк");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите минимальное значение элемента");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите максимальное значение элемента");
int max = Convert.ToInt32 (Console.ReadLine());
double[,] MyArray = Create2DRandomArray (min, max, rows, columns);
Show2DArray (MyArray);*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

/*int[,] Create2DRandomArray (int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElement (int[,] array, int rowId, int columnId)
{
    if (rowId > array.GetLength(0) || columnId > array.GetLength(1))
    Console.WriteLine ($"Элемент с индексом [{rowId}, {columnId}] не найден");
    else Console.WriteLine (array [rowId, columnId]);
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(min, max, rows, columns);
Show2DArray (myArray);
Console.WriteLine ("Введите строку элемента");
int rowId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите столбец элемента");
int columnId = Convert.ToInt32(Console.ReadLine());
Console.Write ($"Элемент с индексом [{rowId}, {columnId}] -> ");
FindElement (myArray, rowId, columnId);*/

//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*int[,] Create2DRandomArray (int minValue, int maxValue, int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return newArray;
}
void Show2DArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write (array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageColumn (int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
   {
        double sum = 0;
        int i = 0;
        while (i < array.GetLength(0))
       {
          sum = sum + array[i,j];
          i++;
       }
       Console.Write ($"{Math.Round(sum / i, 1)}; ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите количество строк");
int rows = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите количество столбцов");
int columns = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2DRandomArray(min, max, rows, columns);
Show2DArray(myArray);
AverageColumn (myArray);*/