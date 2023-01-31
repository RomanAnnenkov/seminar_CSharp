/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM >= 0 && numberN >= 0)
{
    Console.WriteLine(GetAkkermanNumber(numberM, numberN));
}
else Console.WriteLine("Ошибка ввода.");

int GetAkkermanNumber(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return GetAkkermanNumber(numM - 1, 1);
    else return GetAkkermanNumber(numM - 1, GetAkkermanNumber(numM, numN - 1));
}