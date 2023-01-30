/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

PrintFromToo(numberM, numberN);

void PrintFromToo(int first, int second)
{
    if (first > second)
    {
        Console.Write($"{first} ");
        PrintFromToo(first - 1, second);
    }
    else if (first < second)
    {
        Console.Write($"{first} ");
        PrintFromToo(first + 1, second);
    }
    else Console.Write($"{second} ");

}