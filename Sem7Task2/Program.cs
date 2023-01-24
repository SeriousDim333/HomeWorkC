/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

int getNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] array2D(int row, int column, int start, int end)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(start, end);
        }
    }
    return array;
}

void print2DArray(double[,] array)
{
    Console.Write("\t");
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write(i + "\t");
    }
    Console.ResetColor();
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(i + "\t");
        Console.ResetColor();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void searchElement(double[,] array, int searchRow, int searchColumn)
{
    if (searchRow > array.GetLength(0) || searchColumn > array.GetLength(1))
    {
        Console.WriteLine("вы вышли за пределы массива");
    }
    else
    {
        Console.WriteLine($"искомый элемент = {array[searchRow, searchColumn]}");
    }
}

int row = getNumber("введите количество строк");
int column = getNumber("введите количество столбцов");
double[,] array = array2D(row, column, 0, 10);
print2DArray(array);
int searchRow = getNumber("введите строку поиска");
int searchColumn = getNumber("введите столбец поиска");
searchElement(array, searchRow, searchColumn);