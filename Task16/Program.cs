// 16. Напишите программу, которая 
// 1. принимает на вход два числа и 
// 3. проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool IsSquareTwoNum(int number1, int number2)
{
    return number1 == number2 * number2 ||
    number2 == number1 * number1;
}

int num1 = GetUserInput("Ведите первое число");
int num2 = GetUserInput("Ведите второе число");

bool isSquareTwoNum = IsSquareTwoNum(num1, num2);
Console.WriteLine(isSquareTwoNum ? "да" : "нет");
