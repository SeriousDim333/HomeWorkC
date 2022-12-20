// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void dayOfWeek(int dayNum)
{
    if (dayNum>0 && dayNum<8)
    {
        if(dayNum==7 || dayNum==6)
        {
            Console.WriteLine("да");
        }
        else
        {
            Console.WriteLine("нет");
        }
    }
    else
    {
        Console.WriteLine("нет такого дня");
    }
}


int dayNum = int.Parse(Console.ReadLine());
dayOfWeek(dayNum);