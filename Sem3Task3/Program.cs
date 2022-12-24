/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int number(string messege)
{
    Console.WriteLine("введите число");
    int num = int.Parse(Console.ReadLine());
    return num;
}

void cube(int num)
{
    double cubeNum=1;
    for (int count = 1; count < num; count++)
    {
    cubeNum = Math.Pow(count, 3);
    Console.Write(cubeNum + ", ");
    }
    cubeNum = Math.Pow(num, 3);
    Console.Write(cubeNum);
}

int num = number("введите число");
cube(num);