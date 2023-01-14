/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
int number(string message)
{
    Console.WriteLine(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}


int [] arrayNum(int num)
{
    int [] arr = new int [num];
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(100);
    }
    return arr;
}

void showArr(int [] arr)
{
Console.Write("[");
for (int i = 0; i < arr.Length -1; i++)
{
    Console.Write( arr[i] + ", ");
}
    Console.Write(arr[arr.Length-1] + "]");
}

int num = number("введите длину массива");
int [] arr = arrayNum(num);
showArr(arr);
