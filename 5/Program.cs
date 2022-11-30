//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for (int i = 0; i < size; i++)
   {
    newArray[i] = new Random().Next(100, 999);
   }
   return newArray;
}

void ShowArray (int[] array)
{
    Console.Write ("Получившийся массив -> ");
    for (int i=0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
        Console.WriteLine();
 }

void HowManyEvenNumbers (int[] array)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count++;
    }
    Console.Write($"Количество чётных чисел -> {count}");
}

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимум");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимум");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
HowManyEvenNumbers (myArray);*/

//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/*int[] CreateRandomArray (int size, int minValue, int maxValue)
{
   int [] newArray  = new int [size];
   for (int i = 0; i < size; i++)
   {
    newArray[i] = new Random().Next(minValue, maxValue+1);
   }
   return newArray;
}

void ShowArray (int[] array)
{
    Console.Write ("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write (array[i] + " ");
    }
        Console.WriteLine();
 }

 void FindSum (int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    Console.Write ($"Сумма элементов на нечётных позициях равна -> {sum}");
}

Console.WriteLine ("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимум");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимум");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
FindSum (myArray);*/

//Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

/*double[] CreateRandomArray (int size)
{
   double[] newArray  = new double [size];
   for (int i = 0; i < size; i++)
   {
    newArray[i] = new Random().Next();
   }
   return newArray;
}

void ShowArray (double[] array)
 {
    Console.Write ("Получившийся массив -> ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
        Console.WriteLine();
 }

void FindMin (double[] array)
{   
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i] < min)
            min = array[i];
            if (array[i] > max)
            max = array[i];
        }
    }
    Console.WriteLine($"Максимальное значение -> {max}, минимальное значение -> {min}");
    Console.WriteLine($"Разница между максимумом и минимумом равна {max - min}");
}


Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray (a);
ShowArray (myArray);
FindMin (myArray);*/