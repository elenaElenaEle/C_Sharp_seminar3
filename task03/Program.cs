/*Напишите программу, которая принимает на вход координаты двух точек и
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21*/

Console.Write("Введите координаты x точки a ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Введите координаты y точки a ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Введите координаты x точки b ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Введите координаты y точки b ");
int by = int.Parse(Console.ReadLine());

double R = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2));
Console.WriteLine("Расстояние между точками " + Math.Round(R, 4));