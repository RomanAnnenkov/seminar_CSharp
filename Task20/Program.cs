/* 
Задача 20: Напишите программу, которая 
принимает на вход координаты двух 
точек и находит расстояние между ними в 2D пространстве. 
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 
 */

/*  double d = Math.Sqrt(345);
 Math.Pow(d, 2);

 double num = 5.099876554;
 double numRound = Math.Round(num, 2, MidpointRounding.ToZero);  */


Console.WriteLine("Введите координаты двух точек, для определения расстояния между ними:");
Console.Write("Точка A координата X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A координата Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата Y: ");
int by = Convert.ToInt32(Console.ReadLine());

double distanceAB = Math.Sqrt(DistanceAB(ax,ay,bx,by));
double distanceABRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero);

Console.WriteLine($"A ({ax},{ay}); B ({bx},{by}) -> {distanceABRound}");

int DistanceAB(int firstX, int firtsY, int secondX, int secondY)
{
    int legX = firstX - secondX;
    int legY = firtsY - secondY;
    int result = (int)(Math.Pow(legX, 2) + Math.Pow(legY, 2));
    return result;
}


