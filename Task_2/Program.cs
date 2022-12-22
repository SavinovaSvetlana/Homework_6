﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
void Points(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые параллельны, точки пересечения нет. ");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые одинаковы. ");
    else Console.WriteLine($"Координаты пересечения : ({x}; {y}) ");
}

Console.WriteLine("Введите значение точки b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение точки k2: ");
double k2 = double.Parse(Console.ReadLine()!);

Points(b1, k1, b2, k2);