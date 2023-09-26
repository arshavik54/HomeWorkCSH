// Напишите программу, которая будет 
// 1. принимать на вход два числа и
// 2. выводить, является ли первое число кратным второму.
// 3. Если первое число не кратно второму, то программа
// 4. выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetRemainder(int num1, int num2)
{
    return num1 % num2;
}

int firstNum = GetUserInput("Введите первое число");
int secondNum = GetUserInput("Введите второе число");

int rem = GetRemainder(firstNum, secondNum);

if (rem == 0)
{
    Console.WriteLine($"Число {firstNum} кратно {secondNum}");
}
else
{
    Console.WriteLine($"Число {firstNum} не кратно, остаток {secondNum} ");
}    

