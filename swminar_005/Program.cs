/*
Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
*/
/*

int[] CreatArray(int sizeArray, int minVal, int maxVal)
{
    int[] newArray = new int[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    
    return newArray;
}

void PrintArray(int[] arrayToPrint)
{
    int arraySize = arrayToPrint.Length;
    Console.WriteLine(arraySize);
    for (int i = 0; i < arrayToPrint.Length; i++)
        Console.Write(arrayToPrint[i] + " ");
    Console.WriteLine();
}

void FindSumNegativeElem(int[] array)
{
    int SumNegativeElem = 0;
    for (int i = 0; i < array.Length; i++)
    
        if (array[i] < 0)
            SumNegativeElem += array[i];
        Console.WriteLine($"Summ of negative elements of array is {SumNegativeElem}");
    
}

int FindSumPosElem(int[] array1)
{
    int sumPosElem = 0;
    for (int i = 0; i < array1.Length; i++)
        if (array1[i] > 0)
            sumPosElem += array1[i];
    return sumPosElem;
}

int sizeOfArray = 12;
int minArrayVal = -9;
int maxArrayVal = 9;

int[] createdArray = CreatArray(sizeOfArray, minArrayVal, maxArrayVal);
PrintArray(createdArray);
FindSumNegativeElem(createdArray);
int positiveSum = FindSumPosElem(createdArray);
Console.WriteLine($"Summ of positive elements if {positiveSum}");
*/


//Напишите программу замены элементов массива: положительные элементы замените на соответствующие
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/*
int[] RandomArray()
{
    int size = new Random().Next(4,10);
    int[] randomArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-10,10);
    }
    return randomArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.WriteLine();
}

int[] InvertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = array[i] * (-1); // array[i] *= (-1); += -= /=
    return array;
}

int[] massiv = RandomArray();
ShowArray(massiv);
ShowArray(InvertArray(massiv));

*/

//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

/*
int[] RandomArrayNew()
{
    int size = 7;
    int[] randomArrayNew = new int[size];
    for( int i = 0; i < size; i++ )
    {
        randomArrayNew[i] = new Random().Next(1,10);
    }
    return randomArrayNew;
}
/*
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.WriteLine();
}
*/

/*
int[] MultiArray(int[] startArray)
{
    int[] finishArray;
    if (startArray.Length % 2 == 1)
        finishArray = new int[startArray.Length / 2 + 1];
    else
        finishArray = new int[startArray.Length / 2];
    for(int i = 0;i < startArray.Length / 2;i++ )
    {
        finishArray[i] = startArray[i] * startArray[startArray.Length - 1];
    }    
    return finishArray;
}

int[] srArray = RandomArrayNew();
ShowArray(srArray);
int[] multy = MultiArray(srArray);
ShowArray(multy);

*/

//Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

/*
void CountOfElem(int[] countArray)
{
    int count = 0;
    for(int i = 0; i < countArray.Length; i++)
    {
        if (countArray[i] >= 10 && countArray[i] <= 99)
            count++;
    }
    Console.WriteLine($"-> {count}");   
}

int[] newArray = RandomArray();
ShowArray( newArray );
CountOfElem( newArray );
*/