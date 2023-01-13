// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("введите первое число");
int numberOne = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число");
int numberTwo = int.Parse(Console.ReadLine());

if(numberOne>numberTwo)
{
    Console.WriteLine("большее число: ");
    Console.WriteLine(numberOne);
}
else
{
    Console.WriteLine("большее число: ");
    Console.WriteLine(numberTwo);
}