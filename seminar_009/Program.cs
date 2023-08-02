//Задача 1
//Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNumbers(int numberN)                   //5
{
    //Console.Write(numberN + " ");              // write 5, 4, 3, 2, 1
  
    if(numberN > 1) {ShowNumbers(numberN - 1); }  // 5>1 => YES => ShowNumbers(4)
    Console.Write(numberN + " ");                 // 1,2,3,4,5
}

ShowNumbers(5);
*/

//Задача 2
// напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//-256
//654
/*
while(num > 0)
{
    %
    /
}
*/

/*
int SumDigit(int num)
{
    if (num < 0) num *= -1;
    if(num > 0) return SumDigit(num/10) + num % 10;
    else return 0;
}

int res = SumDigit(12345);
Console.WriteLine(res);
*/

//Задайте значения М и N. Напишите программу, которая выведет все натуральные числа в промежутке
// от M до N.
// N < M, N = M, M < N
// Math.Min(,); Math.Max(,)

/*
void ShowNumberMN(int numM, int numN)
{
    Console.Write($"{Math.Max(numN,numM)} ");
    if (Math.Min(numN, numM) != Math.Max(numN, numM)) 
        ShowNumberMN(Math.Min(numM, numN), Math.Max(numM, numN) - 1);
}

ShowNumberMN(1, 9);
*/

// Напишите программу которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии.
// 2^(-1) = 1/2
// 2^(-3) = 1/(2^3) = 1/8    2^3 = 8
// -2^(-3) = -1/(2^3)     -2^3 = - 8      -2^4 = 16
// 2^0 = 1    18888^0 = 1
// b > 0
// b < 0
// b = 0

/*

double FindPower (int numA, int numB)
{
    if (numB > 0) return FindPower(numA, numB - 1) *numA;
    if (numB < 0) return FindPower(numA, numB + 1) / numA;
    return 1.0;
}

double res = FindPower(-2, 0);
Console.Write(res);
*/