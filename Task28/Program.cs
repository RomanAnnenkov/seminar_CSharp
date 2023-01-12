/* Задача 28: Напишите программу, 
которая принимает на вход число N и выдаёт произведение чисел от 1 до N. 
4 -> 24 
5 -> 120  */

Console.WriteLine("Программа, которая выводит произведение чисел от 1 до A");
Console.Write("Введите целое число N: ");
int number = Convert.ToInt32(Console.ReadLine());

int factorialNumber = FactorialNumber(number);

Console.WriteLine($"Произведение чисел от 1 до {number} = {factorialNumber}");

int FactorialNumber(int inputNumber)
{
    int result = 1;
    for (int i = 1;i <= inputNumber; i++ )
    {
        checked
        {
            result = result * i;
        }
        
    }
    return result;
}