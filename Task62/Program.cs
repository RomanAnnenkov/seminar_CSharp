/* *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int arrayRows = 4;
int arrayColumns = 4;
int firstValue = 1;

int[,] array2d = CreateMatrixSpiralInt(arrayRows, arrayColumns, firstValue);
PrintMatrixSameDigitLength(array2d);

int[,] CreateMatrixSpiralInt(int rows, int columns, int startValue = 1)
{
    int[,] newMatrix = new int[rows, columns];
    int rowIndex = 0;
    int columnIndex = 0;
    int countProcessedElement = 0;
    bool toRight = true;
    bool toDown = true;
    int matrixRows = newMatrix.GetLength(0);
    int matrixColumns = newMatrix.GetLength(1);

    while (countProcessedElement < newMatrix.Length)
    {
        for (int i = 0; i < matrixColumns; i++)
        {
            newMatrix[rowIndex, columnIndex] = startValue;
            startValue++;
            countProcessedElement++;
            if (toRight && i != matrixColumns - 1) columnIndex++;
            if (!toRight && i != matrixColumns - 1) columnIndex--;

        }
        if (toRight)
        {
            rowIndex++;
            toRight = false;
        }
        else
        {
            rowIndex--;
            toRight = true;
        }
        matrixRows--;

        for (int j = 0; j < matrixRows; j++)
        {
            newMatrix[rowIndex, columnIndex] = startValue;
            startValue++;
            countProcessedElement++;
            if (toDown && j != matrixRows - 1) rowIndex++;
            if (!toDown && j != matrixRows - 1) rowIndex--;
        }
        if (toDown)
        {
            columnIndex--;
            toDown = false;
        }
        else
        {
            columnIndex++;
            toDown = true;
        }
        matrixColumns--;
    }
    return newMatrix;
}

void PrintMatrixSameDigitLength(int[,] matrix)
{
    int[] matrixToArray = MatrixToArray(matrix);
    int maxValue = matrixToArray.Max();
    int countMaxValueDigit = 0;
    while (maxValue != 0)
    {
        maxValue /= 10;
        countMaxValueDigit++;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int number = matrix[i, j];
            string output = String.Empty;
            int tmpNumber = number;
            int countDigit = 0;
            while (tmpNumber != 0)
            {
                tmpNumber /= 10;
                countDigit++;
            }
            if (countDigit < countMaxValueDigit)
            {
                for (int k = 0; k < countMaxValueDigit - countDigit; k++)
                {
                    output += "0";
                }
            }
            output += number;
            Console.Write($"{output} ");
        }
        Console.WriteLine();
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] result = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[count] = matrix[i, j];
            count++;
        }
    }
    return result;
}