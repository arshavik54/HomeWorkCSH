//  Написать программу, которая
// 1. на вход принимает два числа и проверяет
// 2. является ли первое число квадратом второго
// 3. вывод результата

// Например:
// а = 25, b = 5  -> да
// а = 2,  b = 10 -> нет
// а = 9,  b = -3 -> да
// а = -3, b = 9  -> нет

Console.WriteLine("Введите первое целое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 * number2 == number1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}