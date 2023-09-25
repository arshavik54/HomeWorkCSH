// Напишите программу, которая будет принимать 

int GetUserInput(string str);
{
    Console.Write($"{str}" );
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int firstNum = GetUserInput("Введите первое число");
int secondNum = GetUserInput("Введите второе число");

int rem = GetRemainder(firstNum)