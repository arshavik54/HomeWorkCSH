﻿// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// using Internal;

int number = new Random().Next(10, 100); //99+1
Console.WriteLine($"Случайное число из отрезка [10, 99] -> {number}");

int firstDigit = number / 10; // 78 / 10 = 7
int secondDigit = number % 10; // 78 = 70 + 8
