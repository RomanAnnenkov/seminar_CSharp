/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

int indexRowWithMinSum = GetIndexRowWithMinSum(array2d);
int numberRow = indexRowWithMinSum + 1;
Console.WriteLine($"Наименьшая сумма элементов в {numberRow} строке.");

int GetIndexRowWithMinSum(int[,] matrix)
{
    int resultRow = 0;
    int minSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minSum || minSum == 0)
        {
            minSum = sum;
            resultRow = i;
        }
    }
    return resultRow;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] newMatrix = new int[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return newMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}