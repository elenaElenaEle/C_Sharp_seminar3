/* Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.*/

Console.Write("Введите пятизначное число ");
int N = int.Parse(Console.ReadLine());
// A B C D E  35863
int A = N / 10000;
int E = N % 10;
int B = N / 1000 % 10;
int D = (N % 100) / 10; 

if (N <= 99999 && N > 9999)
    if (A == E && B == D)
    {
    Console.Write("Число " + N + " является полиндромом ");
    }
    else 
    {
    Console.Write("Число " + N + " не является полиндромом ");
    }
else 
{
    Console.Write("Вы ввели не пятизначное число");
}

***************************************************************************************************************************

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

*******************************************************************************************************************************************

/*Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while (i <= N)
{
    Console.WriteLine(Math.Pow(i, 3));
    i ++;
}