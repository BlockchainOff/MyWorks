/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4-> 16
*/
/*
using System.Runtime.Serialization.Formatters;
void Degree ()
{
    Console.Write("ведите число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите стпень: ");
    int degree = Convert.ToInt32(Console.ReadLine());
    int result = 1;

    for(int i = 1; i <= degree; i++)
    {
        result = result * numb;
    }
    Console.WriteLine(result);
}
Degree();
*/

/*
 Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
void Summa()
{
    Console.Write("Ведите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    Console.WriteLine(result);
}
Summa();
*/
