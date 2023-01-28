/* *Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

int arrayWidth = 2;
int arrayHeight = 2;
int arrayDepth = 2;
int arrayMinInt = 10;
int arrayMaxInt = 99;

int lengthArray = arrayWidth * arrayHeight * arrayDepth;
int amountUniqElement = 1 + arrayMaxInt - arrayMinInt;
Console.WriteLine(amountUniqElement);

if (lengthArray <= amountUniqElement)
{
    int[,,] array3D = Create3DArrayUniqInt(arrayWidth, arrayHeight, arrayDepth, arrayMinInt, arrayMaxInt);
    Print3DArray(array3D);
}
else Console.WriteLine("В указанном диапазоне недостаточно уникальных элементов для заполнения массива.");



int[,,] Create3DArrayUniqInt(int width, int height, int depth, int minInt, int maxInt)
{
    int[,,] new3DArray = new int[width, height, depth];
    Console.WriteLine(new3DArray.Length);
    int[] uniqElementArray = CreateArrayRndUniqInt(new3DArray.Length, minInt, maxInt);
    int index = 0;

    for (int i = 0; i < new3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < new3DArray.GetLength(1); j++)
        {
            for (int k = 0; k < new3DArray.GetLength(2); k++)
            {
                new3DArray[i, j, k] = uniqElementArray[index];
                index++;
            }
        }
    }
    return new3DArray;
}

int[] CreateArrayRndUniqInt(int length, int min, int max)
{
    int[] resultArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < resultArray.Length; i++)
    {
        int val = rnd.Next(min, max + 1);
        while (Array.IndexOf(resultArray, val) != -1)
        {
            val = rnd.Next(min, max + 1);
        }
        resultArray[i] = val;

    }
    return resultArray;
}

void Print3DArray(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}