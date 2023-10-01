﻿// 21. Напишите программу, которая 
// 1. принимает на вход координаты двух точек и 
// 2. находит расстояние между ними в 3D пространстве.
// A (3, 6, 8); B (2, 1, -7) -> 15.84;
// A (7, -5, 0); B (1, -1, 9) -> 11.53

// int n = 5; 
// int nS = n * n;
// double nS2 = Math.Pow(n, 2);

  
int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
  // d = √((х2 –  х1)2 + (у2 – у1)2) +(z2 - z1)2
double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return res;
}
int x1 = GetUserInput("Координаты первой точки\nВведите координату X");
int y1 = GetUserInput("Координаты первой точки\nВведите координату Y");
int z1 = GetUserInput("Координаты первой точки\nВведите координату Z");
Console.WriteLine("------------------------------");
int x2 = GetUserInput("Координаты второй точки\nВведите координату X");
int y2 = GetUserInput("Координаты второй точки\nВведите координату Y");
int z2 = GetUserInput("Координаты первой точки\nВведите координату Z");


double result = Distance(x1, y1, x2, y2, z1, z2);
Console.WriteLine(Math.Pow(result, 2));
  

  
        // Не удаляйте строки ниже
        
        // result = (new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        // Console.WriteLine($"{result:F2}");
  