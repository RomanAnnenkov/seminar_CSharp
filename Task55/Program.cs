/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */
//новый массив

int[,] array2d = CreateMatrixRndInt(3, 3, -5, 40);


if (array2d.GetLength(0) == array2d.GetLength(1))
{   PrintMatrix(array2d);
    Console.WriteLine();
    ReplaceRowsColumns(array2d);
    PrintMatrix(array2d);
}
else Console.WriteLine("невозможно выполнить операцию замены строк на столбцы");




void ReplaceRowsColumns(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tmp;
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
