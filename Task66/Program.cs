// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int UserNumber(string message)
{
Console.WriteLine(message);
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

int SumNaturalsNumbers(int m, int n)// 0,15;
{
    if (m == n) return m;
    return n + SumNaturalsNumbers(m, n - 1);
}  

int m = UserNumber("Введите число M: ");
int n = UserNumber("Введите число N: ");
int num = SumNaturalsNumbers(m, n);

int PowerMN = 0;
if (m < n)
PowerMN = SumNaturalsNumbers(m, n);
else
PowerMN = m + SumNaturalsNumbers(n, m - 1);
Console.WriteLine($"Сумма элементов равна: {PowerMN}");
