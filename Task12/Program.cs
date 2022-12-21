/*
12. Напишите программу, которая будет 
принимать на вход два числа и выводить, 
является ли первое число кратным второму. 
Если число 1 не кратно числу 2, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно 
*/

int MultiplicityOfTwoNumbers(int firstNum, int secondNum)
{
    return firstNum % secondNum;
}

Console.Write("Введите первое число : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber < 0) firstNumber = -firstNumber;
if (secondNumber < 0) secondNumber = -secondNumber;
if (firstNumber < secondNumber)
{
    Console.WriteLine($"Показать кратность первого числа второму невозможно, т.к. {firstNumber} < {secondNumber}");
}
else
{
    int multiplicityOfTwoNumbers = MultiplicityOfTwoNumbers(firstNumber, secondNumber);
    Console.WriteLine(multiplicityOfTwoNumbers == 0 ? "кратно" : $"не кратно, остаток {multiplicityOfTwoNumbers}");
}