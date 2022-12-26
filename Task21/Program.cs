/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите координаты двух точек, для определения расстояния между ними:");
Console.Write("Точка A координата X: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A координата Y: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка A координата Z: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата X: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата Y: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Точка B координата Z: ");
int bz = Convert.ToInt32(Console.ReadLine());

double distanceAB = Math.Sqrt(DistanceAB(ax, ay, az, bx, by, bz));
double distanceABRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero);

Console.WriteLine($"A ({ax},{ay},{az}); B ({bx},{by},{bz}) -> {distanceABRound}");

int DistanceAB(int firstX, int firtsY, int firtsZ, int secondX, int secondY, int secondZ)
{
    int legX = firstX - secondX;
    int legY = firtsY - secondY;
    int legZ = firtsZ - secondZ;
    int result = (int)(Math.Pow(legX, 2) + Math.Pow(legY, 2) + Math.Pow(legZ, 2));
    return result;
}