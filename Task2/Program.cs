// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("введите первое число");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberTwo = int.Parse(Console.ReadLine());
Console.WriteLine("введите третье число");
int numberThree = int.Parse(Console.ReadLine());

int max = numberOne;

if (max < numberTwo)
{
    max = numberTwo;
}
//else
//{
//    max = max;
//}

if (max < numberThree)
{
    max = numberThree;
}
//else
//{
//    max = max;
//}

Console.WriteLine("боьшее число");
Console.WriteLine(max);