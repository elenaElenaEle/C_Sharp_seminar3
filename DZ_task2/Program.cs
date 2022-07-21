/*Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.*/

Console.Write("Введите координаты x точки a ");
int ax = int.Parse(Console.ReadLine());

Console.Write("Введите координаты y точки a ");
int ay = int.Parse(Console.ReadLine());

Console.Write("Введите координаты z точки a ");
int az = int.Parse(Console.ReadLine());

Console.Write("Введите координаты x точки b ");
int bx = int.Parse(Console.ReadLine());

Console.Write("Введите координаты y точки b ");
int by = int.Parse(Console.ReadLine());

Console.Write("Введите координаты z точки b ");
int bz = int.Parse(Console.ReadLine());

double R = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2) + Math.Pow(bz - az, 2));
Console.WriteLine("Расстояние между точками " + Math.Round(R, 4));