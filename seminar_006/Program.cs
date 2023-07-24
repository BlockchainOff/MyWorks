//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]
/*
int[] CreatArray(int size, int minVal, int maxVal)
{
    int[] arrayNew = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i] = new Random().Next(minVal, maxVal + 1);
    }
    return arrayNew;
}
 

 void PrintArray(int[]arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)    
    {
        Console.Write(arrayToPrint[i]);
      //  if(i != arrayToPrint.Length - 1) Console.Write(", ");
      //  else Console.Write(".");
    }
    Console.WriteLine();
}

int[] ReversArray(int[] arrayToRevers)
{
    int k = arrayToRevers.Length;
    int temp;
    for(int i = 0; i < k/2 ; i++)
    {
        temp = arrayToRevers[i];
        arrayToRevers[i] = arrayToRevers[k - 1 - i];
        arrayToRevers[k - 1 - i] = temp;
    }
    return arrayToRevers;
}

int size_array = 7;
int minVal = -9;
int maxVal = 9;
int[] createdArray = CreatArray(size_array, minVal, maxVal);
PrintArray(createdArray);
int[] ReversedArray = ReversArray(createdArray);
PrintArray(ReversedArray);
*/

//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11

/*
int CountOfBynar (int user_num)
{
    int countOfDigit = 0;
    while(user_num != 0)
    {
        user_num = user_num / 2;
        countOfDigit++;
    }
    return countOfDigit;
}

int[] ConvertToBynar(int numToConvert)
{
    int n = CountOfBynar(numToConvert);
    int[] bynarNum = new int[n];
    for (int i = n - 1; i >= 0 ; i--)
    {
       bynarNum[i] = numToConvert % 2;
       numToConvert /= 2;
    }
    return bynarNum;
}

int user_num = 321;
int[] bynary = ConvertToBynar(user_num);
PrintArray(bynary);
*/

//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи:
// a и b (вводит пользователь).
//1 1 2 3 5 8
// a b a+b (b + a+b) (a+b)(b + a+b)
// 1 2 3

/*
void Fibo(int count, int aNumb, int bNumb)
{
    int[] arrayFib = new int[count];
    arrayFib[0] = aNumb;
    arrayFib[1] = bNumb;
    for(int i =2 ; i < count; i++) 
    {
        arrayFib[i] = arrayFib[i - 1] + arrayFib[i - 2];
    }
    PrintArray(arrayFib);
}

Console.Write("Enter count of elements: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num > 0)
{
    Console.WriteLine("enter first num: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter second num: ");
    int secondNum = Convert.ToInt32(Console.ReadLine());

    Fibo(user_num,firstNum,secondNum);

}
else  Console.WriteLine("Error!");
*/

//Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник с сторонами такой длины.
//каждая сторона треугольника меньше суммы двух других сторон.
// a < b + c
// b < a + c
// c < a + b
/*
void Triangle (int firstSide, int secondSide, int thirdSide)
{
    int[] sides = {firstSide, secondSide, thirdSide};
    if(sides[0] < sides[1] + sides[2] &&
     sides[1] < sides[0] + sides[2] &&
     sides[2] < sides[1] + sides[2])
     Console.WriteLine($"Tringle {sides[0]},{sides[1]},{sides[2]} exist!");
     else Console.WriteLine($"Tringle {sides[0]},{sides[1]},{sides[2]} do NOT exist!");
}

Triangle(3,40,5);
*/