/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int number(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

void intersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (-b1 + b2) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"точка пересечения ({x}; {y})");
}

double b1 = number("введите число b1");
double k1 = number("введите число k1");
double b2 = number("введите число b2");
double k2 = number("введите число k2");
intersectionPoint(b1, k1, b2, k2);