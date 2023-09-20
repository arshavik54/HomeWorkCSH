// Написать программу, которая 
// 1. на вход принимает число и 
// 2. выдает его квадрат (число умноженное на само себя).
// 3. вывод результата

// Например:
// 4 -> 16 
// -3 -> 9
// -7 -> 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;
Console.WriteLine($"{number} -> {square}");

