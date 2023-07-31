/*
 Задайте двумерный массив, Напишите программу, которая поменяет местами две любые строки массива.
*/
/*
int[,] Created2dArray(int row, int collumn, int minVal, int maxVal)
{
    int[,] createdarray = new int[row, collumn];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0 ;j< collumn; j++)
        {
            createdarray[i,j] = new Random().Next(minVal,maxVal+1);
        }
        
    }
    return createdarray;
}

void Show2dArray(int[,] arrayToShow)
{
    for(int i = 0;i < arrayToShow.GetLength(0);i++)
    {
        for( int j = 0 ; j < arrayToShow.GetLength(1);j++)
        {
            Console.Write(arrayToShow[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

/*
int[,] ChangeRows(int[,]arrayToChange, int row1, int row2)
{
    int temp;
    for(int i = 0; i < arrayToChange.GetLength(1); i++)
    {
        temp = arrayToChange[row1, i];
        arrayToChange[row1, i] = arrayToChange[row2,i];
        arrayToChange[row2, i] = temp;
    }
    return arrayToChange;
}

Console.Write("Enter count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count of collumns: ");
int userCollumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter minmal value: ");
int userMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter maximal value: ");
int userMax = Convert.ToInt32(Console.ReadLine());

int[,] firstTaskArray = Created2dArray(userRows, userCollumns,userMin,userMax);
Show2dArray(firstTaskArray);

Console.Write("Enter number of the first row to remove: ");
int userRow1 = Convert.ToInt32(Console.ReadLine());
while(userRow1 <= userRows || userRow1 < 0)
{
    Console.WriteLine($"Incorrect input! Number of row should >= 0 & < {userRows}/n Try again!");
    userRow1 = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Enter number of the second row to remove: ");
int userRow2 = Convert.ToInt32(Console.ReadLine());
while (userRow2 <= userRows || userRow1 < 0)
{
    if(userRow2 == userRow1)
    {
        Console.WriteLine("Number of rows are equal!/nTry again!");
    }
    else
    Console.WriteLine($"Incorrect input! Number of row should > 0 & < {userRows}/n Try again!");
    userRow2 = Convert.ToInt32(Console.ReadLine());
}

Show2dArray(ChangeRows(firstTaskArray, userRow1, userRow2));
*/

/*
 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случаи если это невозможно программа должна вывести сообщение для пользователей.
 */

/*
int[,] MatrixChange(int[,] array)
{
    if(array.GetLength(0) != array.GetLength(0))
    {
        Console.WriteLine("Let it be square matrix? 4x4 for example");
    }
    else
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0;j < array.GetLength(0); j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
    }
    return array;
}

int[,] secondTaskArray = Created2dArray(6, 4, 0, 9);
Show2dArray(secondTaskArray);
Show2dArray(MatrixChange(secondTaskArray));
*/

/*
Задайте двумерный массив из целых чисел. Напишите программу которая обнулит строку и слобец,
на пересечении которых расположен первый наименьший элемент массива.
1.найти положение мин элемента массива iMin, jMin.
2.обнулить строку iMin
3.обнулить столбец jMin
 */
/*
int[] FindMin (int[,] arrayTask3)
{
    int[] arrayOfIndex = new int[2];
    int iMin = 0;
    int jMin = 0;
    for(int i = 0; i < arrayTask3.GetLength(0); i++)
    {
        for(int j = 0; j < arrayTask3.GetLength(1); j++)
        {
            if (arrayTask3[i, j] < arrayTask3[iMin,jMin])
            {
                iMin = i;
                jMin = j;
            }
        }
    }
    arrayOfIndex[0] = iMin;
    arrayOfIndex[1] = jMin;
    return arrayOfIndex;
}

int[,] ZeroRowCollumn(int[] arrayIndex, int[,] startArray)
{
    for(int i = 0; i < startArray.GetLength(0); i++)
    {
        startArray[i, arrayIndex[1]] = 0;
    }
    for(int j = 0;j < startArray.GetLength(1);j++)
    {
        startArray[arrayIndex[0],j] = 0;
    }
    return startArray;
}

int[,] thirdTaskArray = Created2dArray(4, 6, 0, 9);
Show2dArray(thirdTaskArray);
Show2dArray(ZeroRowCollumn(FindMin(thirdTaskArray), thirdTaskArray));
*/
