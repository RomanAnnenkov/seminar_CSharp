/* 
Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
*/

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
int[] multiplyElements = MultiplyElements(array);
PrintArray(multiplyElements);


int[] MultiplyElements(int[] arr)
{
    int size = arr.Length / 2;
    if (arr.Length % 2 != 0) size++;
    int[] resultArr = new int[size];
    for (int i = 0; i < resultArr.Length; i++)
    {
        if (arr.Length % 2 != 0 && i == resultArr.Length - 1)
        {
            resultArr[i] = arr[i];
            break;
        }
        resultArr[i] = arr[i] * arr[(arr.Length - 1) - i];
    }
    return resultArr;
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