﻿/* Напишите программу, которая принимает на вход пятизначное число 
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