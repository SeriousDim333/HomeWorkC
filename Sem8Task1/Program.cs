/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

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

int[,] sort2DArray(int[,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1) - 1; i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                if (array[k, i] < array[k, j])
                {
                    int temp = array[k, i];
                    array[k, i] = array[k, j];
                    array[k, j] = temp;
                }
            }
        }
    }
    return array;
}

int row = getNumber("введите число строк");
int column = getNumber("введите число столбцов");
int[,] array = fill2DArray(row, column, 1, 10);
print2DArray(array);
int[,] sortArray = sort2DArray(array);
print2DArray(sortArray);