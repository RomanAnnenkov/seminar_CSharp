/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

Console.WriteLine("Программа для возведения числа А в натуральную степень B");
Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberB > 0)
{
    int mathPow = MathPow(numberA, numberB);
    Console.WriteLine(mathPow);
}
else
{
    Console.WriteLine($"Вы ввели число B '{numberB}' - это не соответствует условию");
}

int MathPow(int inputNumber, int exponent)
{
    int result = 1;
    for (int i = 1; i <= exponent; i++)
    {
        checked
        {
            result = result * inputNumber;
        }
    }
    return result;
}