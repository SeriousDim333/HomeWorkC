/*Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int getNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] fill2DArray(int row, int column)
{
    int[,] array = new int[row, column];
    int count = 1;
    for (int i = 0, j = 0; i < row/2+1; i++, j++)
    {
        int k = i;
        int n = j;
        for (; n < column - j; n++)
        {
            array[k, n] = count++;
        }
        for (; k < row - 1 - i; k++)
        {
            array[k+1, column - 1 - j] = count++;
        }
        for (n = column - 1 - j; n > j; n--)
        {
            array[row - 1 - i, n-1] = count++;
        }
        for (k = row - 1 - i; k > i+1; k--)
        {
            array[k-1, n] = count++;
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

int row = getNumber("введите число строк");
int column = getNumber("введите число столбцов");
int[,] array = fill2DArray(row, column);
print2DArray(array);