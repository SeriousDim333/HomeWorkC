/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

int number(string messege)
{
    Console.WriteLine(messege);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double len = Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2)+Math.Pow(z2 - z1, 2));
    len = Math.Round(len, 2);
    return len;
}

int x1 = number("введите координату x1");
int y1 = number("введите координату y1");
int z1 = number("введите координату z1");
int x2 = number("введите координату x2");
int y2 = number("введите координату y2");
int z2 = number("введите координату z2");

double len = length(x1, y1,z1,x2,y2,z2);
Console.WriteLine(len);
