﻿/* Задача 48: Задайте двумерный массив размера m на n,
каждый элемент в массиве находится по формуле: Amn = m+n.
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

int[,] array2d = CreateMatrixSumIndex(3, 4);
PrintMatrix(array2d);


int[,] CreateMatrixSumIndex(int rows, int columns)
{
    int[,] newMatrix = new int[rows, columns];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = i + j;
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