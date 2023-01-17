/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/


int[] generateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end);
    }
    return array;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i<array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int sumOfEvenIndex(int[] array)
{
    int sum= 0;
    for (int i = 0; i < array.Length; i=i+2)
    {
        sum = sum+ array[i];
    }
    return sum;
}

int[] array = generateArray(11,0,10);
printArray(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях {sumOfEvenIndex(array)}");