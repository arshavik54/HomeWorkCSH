// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает
// все четные числа от 1 до N.
// Например:
// 5 -> 2, 4;
// 8 -> 2, 4, 6, 8;

Console.WriteLine("Введите число > 0");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (count <= number)   
{
    while (count % 2 == 0)
    {
          count += 2;
          Console.Write($"{count} "); 
        