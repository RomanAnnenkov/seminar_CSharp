/* Задача 24: Напишите программу, 
которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А. 
7 -> 28 
4 -> 10 
8 -> 36 
 */

Console.WriteLine("Программа, которая выводит сумму чисел от 1 до A");
Console.Write("Введите целое число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int inputNumber)
{
    int result = 0;
    for (int i = 1;i <= inputNumber; i++ )
    {
        result = result + i;
    }
    return result;
}