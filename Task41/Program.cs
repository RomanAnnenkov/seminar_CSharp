/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Программа для подсчета введённых положительных чисел.");
Console.Write("Введите количество чисел для создания массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayFromInput(arraySize);
int countPositiveNumber = CountPositiveNumber(array);
Console.WriteLine($"Количество положительных чисел : {countPositiveNumber}");

int CountPositiveNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] CreateArrayFromInput(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
