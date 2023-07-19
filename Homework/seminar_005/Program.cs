/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*

int[] RandomArray() // Метод создания рандомного массива
{
    int size = new Random().Next(5, 10);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(100, 1000);
    }
    return randomArray;
}

void PrintArray(int[] array) // Метод для вывода на консоль
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
     Console.WriteLine();
}

void evenNumber(int[] array)
{
    int count =0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    Console.WriteLine(count);  
}

int[] massiv = RandomArray();
PrintArray(massiv);
evenNumber(massiv);
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0
*/
/*

int[] RandomArray() 
{
    int size = new Random().Next(4, 5);
    int[] randomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        randomArray[i] = new Random().Next(-50, 50);
    }
    return randomArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.WriteLine();
}


void oddNumber(int[] array)
{
    int summ = 0;
    for(int i  = 0; i < array.Length;i++)
    {
        if(i % 2 != 0)
        {
            summ = summ + array[i];
        }
        
    }
    Console.Write(summ);


}

int[] massiv = RandomArray();
PrintArray(massiv);
oddNumber(massiv);

*/