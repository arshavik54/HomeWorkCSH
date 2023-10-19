// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int UserNumber (string message)
{
Console.WriteLine(message);
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

void PrintNaturalNumbers (int m, int n)
{
if (m>n)
{
PrintNaturalNumbers(m, n+1);
Console.Write($"{n} ");
}
else if (m<n)
{
PrintNaturalNumbers(m, n-1);
Console.Write($"{n} ");
}
else Console.Write($"{n} ");
}

int m = UserNumber("Enter digit m: ");
int n = UserNumber("Enter digit n: ");
PrintNaturalNumbers(m,n);