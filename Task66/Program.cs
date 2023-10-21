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
    if (m == 0) return 0; ;
    return n + SumNaturalsNumbers(m, n - 1);
    // 0+15+14+13+..
}  


int m = UserNumber("Введите число M: ");
int n = UserNumber("Введите число N: ");
int num = SumNaturalsNumbers(m, n);
Console.WriteLine($"Сумма элементов равна: {num}");
