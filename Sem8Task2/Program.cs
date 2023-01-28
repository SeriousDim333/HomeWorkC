/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int getNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] fill2DArray(int row, int column, int start, int end)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(start, end);
        }
    }
    return array;
}

void print2DArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(i + "\t");
        Console.ResetColor();
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.Write(i + "\t");
        Console.ResetColor();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] sumElement(int[,] array)
{
    int[] sumOFElem = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumOFElem[i] = sum;
    }
    return sumOFElem;
}

void minSumElement(int[] sumOfElem)
{
    int temp = 0;
    for (int i = 1; i < sumOfElem.Length; i++)
    {
        temp = (sumOfElem[temp] > sumOfElem[i]) ? temp = i : temp;
    }
    Console.WriteLine($"{temp} строка");
}

int row = getNumber("введите число строк");
int column = getNumber("введите число столбцов");
int[,] array = fill2DArray(row, column, 1, 10);
print2DArray(array);
int[] sumOfElem = sumElement(array);
minSumElement(sumOfElem);