/* Задача 43: Напишите программу, которая найдёт точку 
пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/*
y = k1 * x + b1
y = k2 * x + b2

y - y = (k1 * x + b1) - (k2 * x + b2)
0 = k1 * x - k2 * x + b1 - b2
0 = (k1 - k2) * x + b1 - b2
-((k1 - k2) * x) = b1 - b2
-x = (b1 - b2)/(k1 - k2)

x = -(b1 - b2)/(k1 - k2)
y = k2 * x + b2
*/

Console.WriteLine("Программа для расчета точки пересечения 2-х прямых,");
Console.WriteLine("заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double getX = GetX(k1, b1, k2, b2);
double getY = GetY(getX, k2, b2);

Console.WriteLine($"({Math.Round(getX, 1)}; {Math.Round(getY, 1)})");

double GetX(int inputK1, int inputB1, int inputK2, int inputB2)
{
    double x = -(double)(inputB1 - inputB2) / (inputK1 - inputK2);
    return x;
}

double GetY(double inputX, int inputK2, int inputB2)
{
    double y = inputK2 * inputX + inputB2;
    return y;
}
