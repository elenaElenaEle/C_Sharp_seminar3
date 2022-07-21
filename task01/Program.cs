/* Напишите программу, которая принимает на вход координаты точки (X и Y), 
 причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
положит. x и y - 1, далее против часовой стрелки*/

Console.Write("Введите x ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите y ");
int y = int.Parse(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая плоскость");
} 
else if(x < 0 && y > 0)
{
    Console.WriteLine("Вторая плоскость ");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Третья плоскость ");}
else 
if(x > 0 &&  y < 0)
{
    Console.WriteLine("Четвертвя плоскость ");
}
else
{
    Console.WriteLine("Координаты не пренадлежат ни одной плоскости");
};
