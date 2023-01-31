/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int GetNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int SumOfElement(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    else
    {
        return start + SumOfElement(start + 1, end);
    }
}

void Verification(int start, int end)
{
    if (start > end)
    {
        Console.WriteLine("первое число должно быть меньше второго");
    }
    else
    {
        Console.WriteLine(SumOfElement(start, end));
    }
}
int start = GetNumber("введите первое число");
int end = GetNumber("введите второе число");
Verification(start, end);

