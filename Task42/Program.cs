// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

int GetUserInput(string message)
{
    Console.Write($"{message}: ");
    int quarter = Convert.ToInt32(Console.ReadLine());
    return quarter;
}

string DecimalToBinary(int number, int baseNum)
{
    string result = String.Empty;

    while (number > 0)
    {
        result = number % baseNum + result;
        number /= baseNum;
    }
    return result;
}

int DecimalToBinaryInt(int number, int baseNum)
{
    int result = 0;
    int mult = 1;

    while (number > 0)
    {
        result = (number % baseNum) * mult + result;
        mult *= 10;
        number /= baseNum;
    }
    return result;
}

int num = GetUserInput("Enter a number");
int baeNumber = GetUserInput("Enter base number");
int binNum = DecimalToBinaryInt(num, baeNumber);
Console.WriteLine($"{num} -> {binNum}");