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

void PrintArray(string[] inputArray)
{
    Console.Write("[");
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"\"{inputArray[i]}\"");
        if (i < inputArray.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

string[] FilterArray(string[] oldArray)
{
    bool[] flagsArr = new bool[oldArray.Length];
    int totalNum = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3) 
        {
            flagsArr[i] = true;
            totalNum ++;
        }
    }
    string[] newArray = new string[totalNum];
    int k = 0;
    if (totalNum > 0)
    for (int i = 0; i < flagsArr.Length; i++)
    {
        if (flagsArr[i]) 
        {
            newArray[k] = oldArray[i];
            k++;
        }
    }
    return newArray;
}

string[] MyArray = InputArray();
Console.WriteLine();
PrintArray(MyArray);
string[] filteredArray = FilterArray(MyArray);
Console.Write(" -> ");
PrintArray(filteredArray);