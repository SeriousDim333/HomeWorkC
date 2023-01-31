/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void PrintNumber(int num)
{
    if (num == 1)
    {
        Console.Write(1);
    }
    else
    {
        Console.Write(num + ", ");
        PrintNumber(num - 1);
    }
}

int num = GetNumber("введите число");
Console.Write("'");
PrintNumber(num);
Console.Write("'");