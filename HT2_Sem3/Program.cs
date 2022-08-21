// Задача 21
// Напишите программу, которая 
// 1. принимает на вход координаты двух точек 
// 2. и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты x, y и z для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x, y и z для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double cord = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
Console.WriteLine(Math.Round(cord, 2, MidpointRounding.ToZero));