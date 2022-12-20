// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1

int number(int num)
{
        int threeNum = num % 10;
        int secondNum = num % 100;
        int res = (secondNum - threeNum) / 10;
        return res;
}

int num = int.Parse(Console.ReadLine());

if(num>99 && num<1000)
{
    int x = number(num);
    Console.WriteLine($"второая цифра {x}");
}
else
{
    Console.WriteLine("введите трех значное число");
}
