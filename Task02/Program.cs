﻿// Напишите программу, которая на вход принимает два 
// числа и выдает, какое число больше, а какое меньше.
// a = 5; b = 7 -> max = 7;
// a = 2; b = 10 -> max = 10;
// a = -9; b = -3 -> max = -3;

int a = -9;
int b = -3;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);
