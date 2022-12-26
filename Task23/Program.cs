/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125 */

Console.WriteLine("Генератор таблицы кубов от 1 до N");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) PrintTableCube(number);
else Console.WriteLine($"Вы ввели число {number} - это не соответствует условию.");;

void PrintTableCube(int num)
{
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count,7} | {Math.Pow(count,3)}");
    }
}

