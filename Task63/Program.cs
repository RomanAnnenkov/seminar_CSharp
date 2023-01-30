/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbers(number);

void PrintNaturalNumbers(int num)
{
    if (num == 0) return;
    PrintNaturalNumbers(num - 1);
    Console.Write($"{num} ");
}