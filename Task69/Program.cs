// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


int UserNumber(string message)
{
Console.WriteLine(message);
int num = Convert.ToInt32(Console.ReadLine());
return num;
}

double PoweringAbyB(int a, int b) // 3,5 - 3,4 - 3,3 - 3,2 - 3,1 - 3,0
{
if (b == 0) return 1; //3,0
return a * PoweringAbyB(a, b - 1); //3,5 - 3,4 - 3,3 - 3,2 - 3,1
//return 1 * 3 * 3 * 3 * 3 * 3 = 243
}


int a = UserNumber("Enter digit a: ");
int b = UserNumber("Enter power b: ");
double powerAB = 0;
if (b >= 0)
powerAB = PoweringAbyB(a, b);
else
powerAB = 1/PoweringAbyB(a, -b);

Console.WriteLine($"A in power B: {powerAB}");