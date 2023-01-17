/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);
double minValue = GetMinValue(array);
double maxValue = GetMaxValue(array);
double diffMaxMin = maxValue - minValue;
Console.WriteLine($" -> {Math.Round(diffMaxMin, 1)}");


double GetMaxValue(double[] arr)
{
    double result = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > result) result = arr[i];
    }
    return result;
}

double GetMinValue(double[] arr)
{
    double result = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < result) result = arr[i];
    }
    return result;
}

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] newArray = new double[size];
    var rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        double value = rnd.NextDouble() * (max - min) + min;
        newArray[i] = Math.Round(value, 1);
    }
    return newArray;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + "; ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");

}