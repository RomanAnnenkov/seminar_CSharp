/*
16. Напишите программу, которая принимает 
на вход два числа и проверяет, является 
ли одно число квадратом другого. 
5, 25 -> да 
-4, 16 -> да 
25, 5 -> да 
8,9 -> нет 
*/

bool IsOneNumberSuquareOfAnother(int oneNumber, int anotherNumber)
{
    return oneNumber * oneNumber == anotherNumber || anotherNumber * anotherNumber == oneNumber;
}

Console.Write("Введите первое число : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

bool isOneNumberSuquareOfAnother = IsOneNumberSuquareOfAnother(firstNumber, secondNumber);
Console.WriteLine(isOneNumberSuquareOfAnother ? "да" : "нет");