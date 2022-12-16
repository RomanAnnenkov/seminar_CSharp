/*
Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите число (N): ");
int number = Convert.ToInt32(Console.ReadLine());
int printNumber = 2;
while (printNumber <= number)
{
    if (number % 2 == 0)
    {
        if (printNumber != number) Console.Write(printNumber + ", ");
        else Console.WriteLine(printNumber);
    }
    else
    {
        if (printNumber != number--) Console.Write(printNumber + ", ");
        else Console.WriteLine(printNumber);
    }
    printNumber = printNumber + 2;
}