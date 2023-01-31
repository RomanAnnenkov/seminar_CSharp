/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0)
{
    Console.WriteLine(SumIntBetween(numberM, numberN));
}
else Console.WriteLine("Ошибка ввода.");

int SumIntBetween(int first, int second)
{
    if (first == second) return first;
    if (first > second) return first + SumIntBetween(first - 1, second);
    else return first + SumIntBetween(first + 1, second);
}