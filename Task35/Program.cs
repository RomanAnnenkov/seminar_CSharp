
/*
Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
*/

int[] array = CreateArrayRndInt(123,-100,200);
PrintArray(array);
int countElements = CountElements(array);
Console.WriteLine(countElements);

int CountElements(int[] arr, int min = 10, int max = 99)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= min && arr[i] <= 99) count++;
    }
    return count;
}

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] newArray = new int[size];
    var rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1);
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");

}
