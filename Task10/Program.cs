/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

456 -> 5
782 -> 8
918 -> 1 */

int SecondDigitOfThreeDigitNumber(int num)
{
    return (num / 10) % 10;
}

Console.Write("Введите трёхзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
if ((number > 99 && number < 1000) || (number < -99 && number > -999))
{
    int secondDigitOfThreeDigitNumber = SecondDigitOfThreeDigitNumber(number);
    Console.WriteLine(secondDigitOfThreeDigitNumber);
}
else Console.WriteLine($"Вы ввели число {number} - оно не соответствует условию");

