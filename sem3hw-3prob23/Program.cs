﻿/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
while (i<n+1)
{
    Console.WriteLine($"i = {i}, куб i = {Math.Pow(i, 3)} ");
    i++;
}
/*
Введите число: 
5
i = 1, куб i = 1 
i = 2, куб i = 8
i = 3, куб i = 27
i = 4, куб i = 64
i = 5, куб i = 125
*/