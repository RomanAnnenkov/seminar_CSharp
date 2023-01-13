/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

Console.WriteLine("Программа вычисления суммы цифр в числе");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumOfDigits = SumOfDigits(number);
Console.WriteLine(sumOfDigits);

int SumOfDigits(int inputNumber)
{
    if (inputNumber < 0) inputNumber = inputNumber * -1;
    int result = 0;
    while (inputNumber != 0)
    {
        result += inputNumber % 10;
        inputNumber /= 10;
    }
    return result;
}