// 19. Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет.
// 23432 -> да.
// 12821 -> да.

int GetUserInput(string str)
// (string str -> потому что дальше пишем "Введите число")
{
    Console.Write($"{str}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
bool IsPalindrome(int number)
{
    int firstDigit == int fourthDigit;
    int secondDigit == int fifthDigit;
    return IsPalindromePalindrom(int number);
}
bool NoPalindrome(int number)
{
    if (number > 9999 && number < 100000)
    { 
        return true
    }
    Console.WriteLine("Вы ввели не пятизначное число");
    return false
}

int firstDigit = number % 10000;
int secondDigit = number % 10000 + 1;
int result = FirstDigit == FourthDigit && SecondDigit == FifthDigit
int number = GetUserInput("Введите пятизначное число: ");

bool palindrom = Palindrom(number)  
Console.WriteLine(IsPalindrome ? "да" : "нет");