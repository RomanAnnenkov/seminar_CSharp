/* Задача 59: Задайте двумерный массив из целых чисел.

Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 2 3
4 2 4
2 6 7 
*/

int[,] array2d = CreateMatrixRndInt(4, 4, -5, 40);
PrintMatrix(array2d);
Console.WriteLine();

int[] indexMinVal = IndexMinVal(array2d);
PrintArray(indexMinVal);
Console.WriteLine();

int[,] cuttedArray = RemoveRowColumn(array2d, indexMinVal[0], indexMinVal[1]);
PrintMatrix(cuttedArray);



int[,] RemoveRowColumn(int[,] matrix, int removeRow, int removeColumn)
{
    int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (i == removeRow) indexRow++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            if (j == removeColumn) indexColumn++;
            newMatrix[i,j] = matrix[indexRow,indexColumn];
            indexColumn++;
        }
        indexRow++;
        indexColumn = 0;
    }
    return newMatrix;
}


int[] IndexMinVal(int[,] matrix)
{
    int min = matrix[0, 0];
    int indexRow = 0;
    int indexColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexColumn = j;
            }
        }
    }
    return new int[] { indexRow, indexColumn, min };
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

void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"{inputArray[i]} ");
    }
    Console.WriteLine();
}
