// Напишите прогорамму, которая принимает на вход 
// трехзначное число и на выходе показывет последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number *= -1;
if (number >= 100 && number <= 999)
{
   int lastDigit = number % 10;
   Console.Write($"последняя цифра вашего числа: {lastDigit}");
}
else Console.WriteLine("Некорректный ввод");