/* Задача 47. Задайте двумерный массив размером m×n, заполненный 
случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] array2d = CreateMatrixRndDouble(3,4,-9,9);
PrintMatrixDouble(array2d);

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] newMatrix = new double[rows, columns];
    var rnd = new Random();
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            double value = rnd.NextDouble() * (max - min) + min;
            newMatrix[i, j] = Math.Round(value, 1);
        }
    }
    return newMatrix;
}

void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}