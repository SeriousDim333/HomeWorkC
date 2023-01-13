/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int number(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int exponentional(int num,int num2)
{
int expo = num;
for (int i = 1; i < num2; i++)
{
    expo = expo*num;
}
return expo;
}

int num = number("введите число");
int num2 = number("введите степень");
Console.WriteLine($"{num} в степени {num2} = {exponentional(num,num2)}");