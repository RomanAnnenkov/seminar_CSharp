/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
https://studwork.org/spravochnik/matematika/matricy/umnojenie-matric
*/

int[,] array2dFirst = CreateMatrixRndInt(4, 2, 1, 9);
PrintMatrix(array2dFirst);
Console.WriteLine();

int[,] array2dSecond = CreateMatrixRndInt(2, 4, 1, 9);
PrintMatrix(array2dSecond);
Console.WriteLine();

bool canMatrixesMultiply = CanMatrixesMultiply(array2dFirst, array2dSecond);
if (canMatrixesMultiply)
{
    int[,] multiplyMatrix = MultiplyMatrix(array2dFirst, array2dSecond);
    PrintMatrix(multiplyMatrix);
}
else Console.WriteLine("Умножение невозможно, т.к. кол-во столбцов первой матрицы не равняется количеству строк второй матрицы.");



bool CanMatrixesMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0)) return true;
    return false;
}

int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
    return resultMatrix;
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