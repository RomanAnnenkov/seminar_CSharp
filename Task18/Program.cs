/* Задача 18: Напишите программу, 
которая по заданному номеру четверти, 
показывает диапазон возможных 
координат точек в этой четверти (x и y).  */

Console.Write("Введите номер четверти для вывода возможных координат: ");
string quarter = Console.ReadLine();
string result = CoordinatesOfQuorter(quarter);
Console.WriteLine(result);

string CoordinatesOfQuorter(string inputQuorter)
{
    if (inputQuorter == "1") return "X > 0 и Y > 0";
    if (inputQuorter == "2") return "X < 0 и Y > 0";
    if (inputQuorter == "3") return "X < 0 и Y < 0";
    if (inputQuorter == "4") return "X > 0 и Y < 0";
    return "Некорректные данные";
}
