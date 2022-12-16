/*
Задача 2: Напишите программу, которая на вход принимает два числа
 и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

В условии написано, что вывод программы должен состоять из 2-х чисел,
Но в примере показан вывод только max. Т.к. вариантов решения 2
, один вариант закомментирован.
*/

Console.Write("Введите первое число : ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число : ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.WriteLine($"max = {firstNumber}");
    //Console.WriteLine($"max = {firstNumber}, min = {secondNumber}");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"max = {secondNumber}");
    //Console.WriteLine($"max = {secondNumber}, min = {firstNumber}");
}
else
{
    Console.WriteLine("Введенные числа равны");
}


