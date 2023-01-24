/* 
Задача 50. Напишите программу, которая на вход принимает позиции э
лемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1,7 -> такого элемента в массиве нет */

int[,] array2d = CreateMatrixRndInt(4, 5, 1, 9);
Console.WriteLine("Программа для вывода элемента двумерного массива по введённой позиции.");
Console.Write("Введите порядковый номер элемента в строке: ");
int rowNumber = Convert.ToInt32(Console.ReadLine());
int rowIndex = rowNumber - 1;
Console.Write("Введите порядковый номер элемента в столбце: ");
int columnNumber = Convert.ToInt32(Console.ReadLine());
int columnIndex = columnNumber - 1;

bool isElementExist = IsElementExist(array2d, rowIndex, columnIndex);
if (isElementExist)
{
    Console.WriteLine($"{rowNumber},{columnNumber} -> {array2d[rowIndex, columnIndex]}");
}
else
{
    Console.WriteLine($"{rowNumber},{columnNumber} -> такого элемента в массиве нет");
}
Console.WriteLine();
Console.WriteLine("Массив для поверки результата:");
PrintMatrix(array2d);


bool IsElementExist(int[,] arr, int indexOfRow, int indexOfColumn)
{
    if (indexOfRow >= 0
        && indexOfRow < arr.GetLength(0)
        && indexOfColumn >= 0
        && indexOfColumn < arr.GetLength(1)) return true;
    return false;
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

