/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("A");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("B");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());


Console.WriteLine(ax - bx);
Console.WriteLine(ay - by);
Console.WriteLine(az - bz);

double AB = Math.Sqrt(Math.Pow(ax - bx,2) + Math.Pow(ay-by,2) + Math.Pow(az-bz,2));
Console.WriteLine(AB);