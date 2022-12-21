/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

bool IsThisDayDayOff(int numberDayOfWeek)
{
    return numberDayOfWeek == 6 || numberDayOfWeek == 7;
}

Console.Write("Введите номер дня недели: ");
int numberOfDay = Convert.ToInt32(Console.ReadLine());
if (numberOfDay > 0 && numberOfDay < 8)
{
    bool isThisDayDayOff = IsThisDayDayOff(numberOfDay);
    Console.WriteLine(isThisDayDayOff ? "да" : "нет");
}
else Console.WriteLine($"Нет дня недели с номером {numberOfDay}");
