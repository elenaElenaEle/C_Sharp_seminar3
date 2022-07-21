/*Напишите программу, которая по заданному номеру четверти, показывает 
диапазон возможных координат точек в этой четверти (x и y).*/

Console.Write("Введите номер четверти ");
int quat = int.Parse(Console.ReadLine());

if (quat == 1)
{
    Console.WriteLine("x > 0, y > 0");
} 
else if (quat == 2)
{
    Console.WriteLine("x < 0, y > 0");
} 
else if (quat == 3)
{
    Console.WriteLine("x < 0, y < 0");
} 
else if (quat == 4)
{
    Console.WriteLine("x > 0, y < 0");
} 
/*if (quat == 0 || quat > 4)
{
    Console.WriteLine("Неправильно введена четверть");
};*/
else
{
    Console.WriteLine("Неправильно введена четверть");
};