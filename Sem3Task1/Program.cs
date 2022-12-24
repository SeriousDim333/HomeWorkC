/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


int number(string messege)
{
    Console.WriteLine(messege);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void polindrom(int number)
{
    if (number / 10000 == number % 10 && (number / 1000) % 10 == (number / 10) % 10)
    {
        Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

int num = number("введите пятизначное число");
polindrom(num);