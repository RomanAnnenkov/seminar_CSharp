/*
14. Напишите программу, которая 
принимает на вход число 
и проверяет, 
кратно ли оно одновременно 7 и 23. 
14 -> нет 
46 -> нет 
161 -> да 
*/

bool MultiplicityOfTwoNumbers(int num, int firstMultiply = 7, int secondMultiply = 23)
{
    return num % firstMultiply == 0 && num % secondMultiply == 0;
}

Console.Write("Введите число для проверки кратности : ");
int number = Convert.ToInt32(Console.ReadLine());
bool multiplicityOfTwoNumbers = MultiplicityOfTwoNumbers(number);
Console.WriteLine(multiplicityOfTwoNumbers ? "да" : "нет");
