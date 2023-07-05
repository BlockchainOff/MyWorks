/*Задача 1
напишите программу, которая на вход принимает число и выдаёт его квадрат
*/

/* Console.WriteLine("Input your number: ");
int userNumb = Convert.ToInt32(Console.ReadLine());

int result = userNumb * userNumb;
//Console.WriteLine(result);
Console.WriteLine("Your result is " + result + " and it is nice");
Console.WriteLine($"Entered number is {userNumb}. Square is {result}"); */

/* Напишите программу, которая на входе получает два числа и проверяет, 
являеться ли первое число квадратом второго.*/

/*
Console.WriteLine("input first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if(firstNum == secondNum * secondNum)
{
    Console.WriteLine($"First number {firstNum} is a square of the second one {secondNum}");
}
else
{
  Console.WriteLine($"First number {firstNum} is Not a square of the second one {secondNum}");  
}
*/

//задача 5.
// напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

/*
Console.WriteLine("Enter your number ");
int numbN = Convert.ToInt32(Console.ReadLine());

int numbNegative = numbN * (-1);

while(numbNegative <= numbN)
{
    Console.Write(numbNegative + ", ");
    numbNegative++;
}
*/

//задача 7.
// напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает последнюю цифру этого числа.

/*
Console.WriteLine("input 3-digit number: ");
int usNum = Convert.ToInt32(Console.ReadLine());

if(usNum >= 100 && usNum <= 999)
{
    int lastDigit = usNum % 10;
    Console.WriteLine($"Last digit is {lastDigit}");
}
else
{
    Console.WriteLine($"Your number is NOT 3 digit");
}

*/