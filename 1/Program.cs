Console.WriteLine("Input number1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
Console.WriteLine ($"max {num1}");
}
else Console.WriteLine ($"max {num1}");


Console.WriteLine("Input number1");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number3");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
    if (number1 > number3)
{
    Console.WriteLine ($"max {number1}");
}
    else Console.WriteLine ($"max {number3}");
else
    if (number2 > number3)
{
    Console.WriteLine ($"max {number2}");
}
    else Console.WriteLine ($"max {number3}");


Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
{
Console.WriteLine ("Да");
}
else Console.WriteLine ("Нет");


Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());
int start = 2;
while (start <= num)
{
Console.WriteLine (start);
start = start + 2;
}