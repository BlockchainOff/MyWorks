/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
/*
using System.Timers;

void NumbPalendrom()
{
    int num = Convert.ToInt32(Console.ReadLine());

    if (num > 9999 && num < 100000)
    {

        int indx0 = num / 10000;
        int ost0 = num % 10000;

        int indx1 = ost0 / 1000;
        int ost1 = ost0 % 1000;

        int ost2 = ost1 % 100;

        int indx3 = ost2 / 10;

        int indx4 = ost2 % 10;

        if (indx0 == indx4 || indx1 == indx3)
        {
            Console.WriteLine("the numbrs is a palindrome");
        }
        else Console.WriteLine("the numbrs is NOT a palindrome");
    }
    else Console.WriteLine("number is not five digit!");
}
NumbPalendrom();
*/

/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 3D пространстве.
A (3,6,8); B(2, 1, -7), -> 15.84
A(7, -5, 0); B(1, -1, 9)-> 11.53 

x,y,z

*/

/*
using System.Numerics;
using System.Text.RegularExpressions;

double distancePoint(double x1, double x2, double y1, double y2, double z1, double z2)
{
    double pointAB = Math.Sqrt((x2- x1) * (x2 - x1) + (y2- y1) *
                               (y2 - y1) + (z2- z1) *(z2 - z1)); 
    return pointAB;
}

Console.WriteLine("enter x coord A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y coord A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter z coord A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter x coord B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter y coord B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter z coord B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = distancePoint(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance AB is {dist:f2}");
*/


/*
Задача 23
Напишите программу, которая принимает на вход число (N) и
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void tablCub ()
{
    int numCub = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; numCub >= i; i++)
    {
        Console.WriteLine(i*i*i);
    }

}
tablCub ();
*/