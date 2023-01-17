
// Задайте массив. Напишите программу, которая опеределяет, присутствует ли заданное число в массиве.

int[] array = CreateArrayRndInt(10,-5,5);
PrintArray(array);
bool isExistNum = IsExistNum(array, 4);
Console.WriteLine(isExistNum);

bool IsExistNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num) return true;
    }
    return false;
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