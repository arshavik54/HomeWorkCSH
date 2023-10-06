// Задача 40. Напишите программу, которая 
// 1. принимает на вход три числа и 
// 2. проверяет, может ли существовать треугольник со сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int GetUserInput(string str)
{
    Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

bool IsExistTriangle(int a, int b, int c)
{
    return a < b + c && b < c + a && c < a + b;
}

int sideA = GetUserInput("Введите сторону А: ");
int sideB = GetUserInput("Введите сторону B: ");
int sideC = GetUserInput("Введите сторону C: ");

bool result = IsExistTriangle(sideA, sideB, sideC);

Console.WriteLine(result ? "Треугольник существует." : "Треугольник не существует.");