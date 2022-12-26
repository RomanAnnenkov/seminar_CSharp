/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да
 */


Console.WriteLine("Определяем число палиндром.");
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000 || number > -100000 && number < -9999)
{
    bool isPolindrome = IsPolindrome(number);
    Console.WriteLine(isPolindrome ? "да" : "нет");
}
else Console.WriteLine($"Вы ввели число {number} - это не соответствует условию");


bool IsPolindrome(int inputNumber)
{
    int originNumber = inputNumber;
    int backwardNumber = 0;

    while (inputNumber != 0)
    {
        backwardNumber = backwardNumber * 10 + inputNumber % 10;
        inputNumber /= 10;
    }

    return originNumber == backwardNumber;
}