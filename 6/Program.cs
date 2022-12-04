//Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

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

int HowMuchPozitiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            count++;
        }
    return count;
}

Console.WriteLine ("Введите размер массива");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите минимум");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите максимум");
int max = Convert.ToInt32 (Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray (myArray);
int result = HowMuchPozitiveNumbers (myArray);
Console.WriteLine ($"Количество положительных чисел -> {result}");*/

//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*void FindIntersectionPoint (int k1, int b1, int k2, int b2)
{
    double tangens = k2 - k1;
    if (tangens == 0)
    Console.WriteLine ("Прямые параллельны");
    double x = (b1 - b2) / tangens;
    double y = (k2 * b1 - k1 * b2) / tangens;
    string point = ($"({Math.Round(x, 1)}, {Math.Round(y, 1)})");
    Console.WriteLine ($"k1 = {k1}, b1 = {b1}, k2 = {k2}, b2 = {b2} -> {point}"); 
}

Console.WriteLine ("Please input k1");
int k1 = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Please input b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Please input k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Please input b2");
int b2 = Convert.ToInt32(Console.ReadLine());
FindIntersectionPoint (k1, b1, k2, b2);*/