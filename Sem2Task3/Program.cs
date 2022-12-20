// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int numberOfDigits(int number)
{
    int i = 10;
    int count = 1;
    while (number / i > 0)
    {
        i = i * 10;
        count++;
    }
    return count;
}

double result(int number)
{
    int count = numberOfDigits(number);
    double threeNum = number % ((Math.Pow(10, count)) / 1000);
    double secondNum = number % ((Math.Pow(10, count)) / 100);
    double res = (secondNum - threeNum) / ((Math.Pow(10, count)) / 1000);
    return res;
}

int number = int.Parse(Console.ReadLine());

if(number>100)
{
    double res = result(number);
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("третьей цифры нет");
}