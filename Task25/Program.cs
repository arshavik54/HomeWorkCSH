// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double Degree(int firstDigit, int secondDigit)
{
    int degree = 1;
    for (int i = 0; i < secondDigit; i++)
    {
        degree *= firstDigit;
    }
    return degree;
}

bool ZeroSD(int B)
{
    if (B < 0)
    {
        Console.WriteLine("Введите число больше нуля");
        return false;
    }
    return true;
}   

int A = GetUserInput("Введите первое число");

int B = GetUserInput("Введите второе число");

double result = Degree(A, B);

if (ZeroSD (B))
{
    Console.WriteLine($"число {A}, в степени {B}  равно {result}");
}


// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string readInput = System.Console.ReadLine();
//     int result = int.Parse(readInput);
//     return result;
// }

// int Power(int powerBase, int exponent)
// {
//     int power = 1;
//     for (int i = 0; i < exponent; i++)
//     {
//         power *= powerBase;
//     }
//     return power;
// }   

// bool ValidateExponent(int exponent)
// {
//     if (exponent < 0)
//     {
//         System.Console.WriteLine("Показатель не должен быть меньше нуля");
//         return false;
//     }
//     return true;
// }   

// int powerBase = Prompt("Введите основание:  ");
// int exponent = Prompt("Введите показатель:  ");
// if (ValidateExponent(exponent))
// {
//     System.Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
// }