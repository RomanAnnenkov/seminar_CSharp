/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет. 
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */

int ThirdDigitOfPositiveNumber(int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        return num % 10;
    }
    else return -1;
}

Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number = -number;
int thirdDigitOfPositiveNumber = ThirdDigitOfPositiveNumber(number);
Console.WriteLine(thirdDigitOfPositiveNumber == -1 ? "третьей цифры нет" : thirdDigitOfPositiveNumber);