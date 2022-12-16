/*
Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8
*/

Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    Console.WriteLine($"Последняя цифра введённого числа {number % 10}");
}
else if (number <= -100 && number >= -999)
{
    Console.WriteLine($"Последняя цифра введённого числа {-(number % 10)}");
}
else
{
    Console.WriteLine($"Вы ввели число \"{number}\" - это не соответствует условию");
}