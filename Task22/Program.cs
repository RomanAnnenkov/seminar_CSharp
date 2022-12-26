/* 
Задача 22: Напишите программу, которая принимает 
на вход число (N) и выдаёт 
таблицу квадратов чисел от 1 до N. 

1 1
2 4
3 9
4 16
5 25
 */

Console.WriteLine("Генератор таблицы квадратов от 1 до N");
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0) PrintTableSquare(number);
else Console.WriteLine($"Вы ввели число {number} - это не соответствует условию.");;

void PrintTableSquare(int num)
{
    for (int count = 1; count <= num; count++)
    {
        Console.WriteLine($"{count,7}{count * count,7}");
    }
}

