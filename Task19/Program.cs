
// 19. Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет.
// 23432 -> да.
// 12821 -> да.

int GetUserInput(string str)
{
    Console.Write($"{str}: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool FifthsDigit(int number)
{ 
    if (number > 9999 && number < 100000)
    {
        return true;
    }
    Console.WriteLine("число не пятизначное");
    return false;    
}

bool ValidatePalindrome(int number)
{
    {
        if ((number / 10000 == number % 10) && 
        number /1000 % 10 == number % 100 /10)
        {
            return true;
        }
        else 
        {
        return false;    
        }
        
    }
}
int number = GetUserInput("Введите пятизначное число");

bool result = ValidatePalindrome(number);
Console.WriteLine($"{result}",  - > True )

// int firstDigit = number / 10000;
// int fifthDigit = number % 10;
// int secondDigit = number / 1000 % 10;
// int fourthDigit = number % 100 /10;

