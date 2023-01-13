/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


int number(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int summa(int num)
{
    int sum = 0;
    while (num % 10 > 0 || num/10>0)
    {
        sum += num % 10;
        num = num / 10;
    }
    return sum;
}

int num = number("введите число");
Console.WriteLine($"сумма цифр числа {num} равна: {summa(num)}");