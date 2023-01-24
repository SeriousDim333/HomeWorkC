/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int arraySize(string message)
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

double[] average(double[,] array)
{
    double[] averageOfColumn = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[j, i];
        }
        averageOfColumn[i] = Math.Round(sum / array.GetLength(1), 1);
    }
    return averageOfColumn;
}

void printArray(double[] averageOfColumn)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.Write("\t");
    for (int i = 0; i < averageOfColumn.Length; i++)
    {
        Console.Write(averageOfColumn[i] + "\t");
    }
    Console.ResetColor();
}

int row = arraySize("введите количество строк");
int column = arraySize("введите количество столбцов");
double[,] array = array2D(row, column, 0, 10);
print2DArray(array);
double[] averageOfColumn = average(array);
Console.WriteLine("Среднее арифметическое каждого столбца:");
printArray(averageOfColumn);

