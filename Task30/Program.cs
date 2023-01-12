// Задача 30: Напишите программу, которая 
// выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке. 
// [1,0,1,1,0,1,0,0] 

int[] array = new int[8];

InitArrayRand01(array);
PrintArray(array);

void InitArrayRand01(int[] inputArray)
{
    Random rnd = new Random();
    for (int i = 0; i < inputArray.Length; i++)
    {
        inputArray[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] inputArray)
{
    for (int i = 0; i < inputArray.Length; i++)
    {
        Console.Write($"{inputArray[i]} ");
    }
    Console.WriteLine();
}
