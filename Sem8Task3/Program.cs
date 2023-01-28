/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
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

int[,] result(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixA.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}

int rowA = getNumber("введите число строк матрица А");
int columnA = getNumber("введите число столбцов матрицы A");
int[,] matrixA = fill2DArray(rowA, columnA, 1, 10);
print2DArray(matrixA);
int rowB = getNumber("введите число строк матрица B");
int columnB = getNumber("введите число столбцов матрицы В");
int[,] matrixB = fill2DArray(rowB, columnB, 1, 10);
print2DArray(matrixB);
if (matrixA.GetLength(1) == matrixB.GetLength(0))
{
    int[,] resultMatrix = result(matrixA, matrixB);
    Console.WriteLine("результат умножения:");
    print2DArray(resultMatrix);
}
else
{
    Console.WriteLine("такие матрицы не перемножить");
}