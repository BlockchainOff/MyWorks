/*
 Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
double[,] randomArray(int lenght,int width)
{
    double[,] randArray = new double[lenght,width];
    for (int i = 0; i < lenght; i++)
    {
        for(int j = 0; j < width; j++)
        {
            randArray[i,j] = new Random().Next(-10,10) + new Random().NextDouble();
        }
    }
    return randArray;
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0;j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]:f1}" + "; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Enter lenght array: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter width array: ");
int width = Convert.ToInt32(Console.ReadLine());
double[,] newArr = randomArray(lenght,width);
PrintArray(newArr);
*/

/*
 Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> такого числа в массиве нет
 */
/*
using System.Xml.Linq;

int[,] new2dArray (int lenght, int width)
{
    int[,] array2d = new int[lenght,width];
    for(int i = 0; i < array2d.GetLength(0); i++)
    {
        for(int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 20);
        }
    }
    return array2d;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void elements(int lenght, int width)
{
    Console.Write("Введите первый элемент: ");
    int digit1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второй элемент: ");
    int digit2 = Convert.ToInt32(Console.ReadLine());
    if (lenght >= digit1 || width >= digit2)
    {
        Console.Write($"Элемент {digit1},{digit2} присутвует");
    }
    else if(lenght != digit1 || width != digit2)
    {
        Console.Write("Нет такого элемета");
    }
}

Console.Write("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int width = Convert.ToInt32(Console.ReadLine());
int[,] newArr = new2dArray(lenght,width);
PrintArray(newArr);
elements(lenght, width);
*/


/*
 Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
 */

/*
int[,] new2dArray(int lenght, int width)
{
    int[,] array2d = new int[lenght, width];
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            array2d[i, j] = new Random().Next(1, 20);
        }
    }
    return array2d;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}" + "; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void elements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double count = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count += array[i, j];
        }
        Console.WriteLine(count/array.GetLength(0));
    }
    Console.WriteLine();
    
}

Console.Write("Введите длину массива: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива: ");
int width = Convert.ToInt32(Console.ReadLine());
int[,] newArr = new2dArray(lenght, width);
PrintArray(newArr);
elements(newArr);
*/