string[] InputArray()
{
    Console.WriteLine("Введите размер массива");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    string[] newArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Введите строку #{i + 1} -> ");
        newArray[i] = Console.ReadLine();
    }
    return newArray;
}

string[] MyArray = InputArray ();