// 11. Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46;
// 782 - 72;
// 918 -> 98;

int number = new Random().Next(100, 1000); //999+1
Console.WriteLine(number);
int firstDigit = number / 100;
int thdDigit = number % 10;