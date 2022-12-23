// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*int numberOfDigits(int number)
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
    //int count = numberOfDigits(number);
    double threeNum = number % ((Math.Pow(10, numberOfDigits(number))) / 1000);
    double secondNum = number % ((Math.Pow(10, numberOfDigits(number))) / 100);
    double res = (secondNum - threeNum) / ((Math.Pow(10, numberOfDigits(number))) / 1000);
    return res;
}

int number = int.Parse(Console.ReadLine());

if(number>99)
{
    double res = result(number);
    Console.WriteLine(result(number));
}
else
{
    Console.WriteLine("третьей цифры нет");
}*/

int getNumber(string messege)
{
    Console.WriteLine(messege);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int threeDidget( int number)
{
    while (number / 1000 > 0)
    {
        number = number / 10;
    }
    int threeDid = number % 10;
    return threeDid;
}

int number = getNumber("введите число");
if(number/100 == 0)
{
    Console.WriteLine("нету третьей цифры");
}
else
{
int threeDid = threeDidget(number);
Console.WriteLine(threeDid);
}

