/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);

double[] array = AverageOfColumns(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArrayDouble(array);
Console.WriteLine(".");


double[] AverageOfColumns(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < result.Length; i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        double beforeRound = (double)sum / matrix.GetLength(0);
        result[i] = Math.Round(beforeRound, 1);
    }
    return result;
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

void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
}
