/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
/*
int secondDigit()
{
    int numb = Convert.ToInt32(Console.ReadLine());

    int stageone = numb % 100;
    int stagetwo = stageone / 10;

    return stagetwo;
}

Console.WriteLine(secondDigit());
*/
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
/*
int thirdDigit()
{
    int number = Convert.ToInt32(Console.ReadLine());

    if(number >= 100 &&  number < 1000)
    {
        int digitOne = number % 10;
        
        return digitOne;

    }
    else if(number < 100)
    {
        Console.WriteLine($"No third digit");
        return 0;
    }
    else if (number > 10000 && number < 100000)
    {
        int digitOne = number % 1000;
        int digitTwo = digitOne / 100;
        
        return digitTwo;
    }
    else
    {
        return 0;
    }
    
}

Console.WriteLine(thirdDigit());
*/
/*
void thirdDigit()
{
    int number = Convert.ToInt32(Console.ReadLine());

    if (number >= 100 && number < 1000)
    {
        int digitOne = number % 10;
        Console.WriteLine(digitOne.ToString());
    }
    else if (number < 100)
    {
        Console.WriteLine($"No third digit");
       
    }
    else if (number > 10000 && number < 100000)
    {
        int digitOne = number % 1000;
        int digitTwo = digitOne / 100;
        Console.WriteLine(digitTwo.ToString());
    }
    

}

thirdDigit();
*/
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
/*
int dayoff()
{
    int dayoff = Convert.ToInt32(Console.ReadLine());

    if(dayoff >= 1 && dayoff <= 5 )
    {
        Console.WriteLine("No");
       return dayoff;
    }
    else if (dayoff >= 6 && dayoff <= 7)
    {
        Console.WriteLine("Yes");
        return dayoff;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine(dayoff());
*/
/*
void dayoff()
{
    int dayoff = Convert.ToInt32(Console.ReadLine());

    if (dayoff >= 1 && dayoff <= 5)
    {
        Console.WriteLine("No");

    }
    else if (dayoff >= 6 && dayoff <= 7)
    {
        Console.WriteLine("Yes");

    }
}
dayoff();
*/