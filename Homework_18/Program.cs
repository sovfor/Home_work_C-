﻿//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданых уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2, k2 задаются пользователем.

Console.WriteLine("Введите число b1:");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k1:");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine("Точка пересечения A находится в координате (" + x + "," + y + ")");