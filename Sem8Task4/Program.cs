/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int getNumber(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,,] fill3DArray(int row, int column, int deep)
{
    int temp = 10;
    int[,,] array = new int[row, column, deep];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                array[i, j, k] = temp;
                temp++;
            }
        }
    }
    return array;
}

void print3DArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i,j,k]} ({i},{j},{k})");
            }
        }
    }
}

int row = getNumber("введите количество строк");
int column = getNumber("введите количество столбцов");
int deep = getNumber("введите глубину");
int[,,] array =fill3DArray(row,column,deep);
print3DArray(array);