/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/


int arraySize(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[,] array2D(int row, int column, int start, int end)
{
    double[,] array = new double[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(start, end) + (double)new Random().Next(start,end)/10;
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
        Console.Write(i+"\t");
    }
    Console.ResetColor();
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(i+"\t");
        Console.ResetColor();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+"\t");
        }
        Console.WriteLine();
    }
}

int row = arraySize("введите количество строк");
int column = arraySize("введите количество столбцов");
double[,] array = array2D(row,column,0,10);
print2DArray(array);