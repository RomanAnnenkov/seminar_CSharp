/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

SortRowsDecrease(array2d);
PrintMatrix(array2d);

void SortRowsDecrease(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sortedIndex = 0;
        int index = 0;
        while (sortedIndex < matrix.GetLength(1) - 1)
        {
            if (matrix[i, index] < matrix[i, index + 1])
            {
                int tmp = matrix[i, index];
                matrix[i, index] = matrix[i, index + 1];
                matrix[i, index + 1] = tmp;
            }
            index++;
            if (index == matrix.GetLength(1) - 1)
            {
                index = 0;
                sortedIndex++;
            }
        }
    }
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