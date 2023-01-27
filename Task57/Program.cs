/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных.
*/
int[,] array2d = CreateMatrixRndInt(4, 5, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();

int[] array = MatrixToArray(array2d);
PrintArray(array);
Console.WriteLine();

Array.Sort(array);
PrintArray(array);
Console.WriteLine();

int[,] uniqElementFrequency = UniqElementFrequency(array);
PrintMatrix(uniqElementFrequency);



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

int[,] UniqElementFrequency(int[] arr)
{
    int rows = arr.Distinct().ToArray().Length;
    int[,] result = new int[rows, 2];
    int currentElement = arr[0];
    int currentElementIndex = 0;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == currentElement) count++;
        else
        {
            result[currentElementIndex, 0] = currentElement;
            result[currentElementIndex, 1] = count;
            currentElementIndex++;
            currentElement = arr[i];
            count = 1;
        }
    }
    if (currentElement != result[result.GetLength(0) - 1, 0])
    {
        result[currentElementIndex, 0] = currentElement;
        result[currentElementIndex, 1] = count;
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

void PrintArray(int[] arr)
{
    Console.Write("[");

    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length - 1)
        {
            Console.Write($"{arr[i]}");
            break;
        }
        Console.Write($"{arr[i]}, ");
    }

    Console.WriteLine("]");
}