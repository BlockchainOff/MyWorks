/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void ShowNumber(int numberN)   // write 5
{
    if (numberN >= 1)
    {
        Console.Write(numberN + " ");
        if (numberN > 1) { ShowNumber(numberN - 1); }
    }
    else { Console.WriteLine("Число отрицательное !"); }
}

int numb = Convert.ToInt32(Console.ReadLine());
ShowNumber(numb);
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int SumMN(int numM, int numN)
{
    int result = numM;
    if (numM == numN)
    { 
        return 0; 
    }
    else
    { 
        numM++;
        result = numM + SumMN(numM, numN);
        return result; 
    }
}

void SummaMN(int numM, int numN)
{
    Console.WriteLine(SumMN(numM - 1, numN));
}

int numM = Convert.ToInt32(Console.ReadLine());
int numN = Convert.ToInt32(Console.ReadLine());
SummaMN(numM, numN);
*/

