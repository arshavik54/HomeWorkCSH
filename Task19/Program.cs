
// 19. Напишите программу, которая 
// 1. принимает на вход пятизначное число и 
// 2. проверяет, является ли оно палиндромом.
// 14212 -> нет.
// 23432 -> да.
// 12821 -> да.

    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());

bool FifthDigit(int number)
{ 
    if (number > 9999 && number < 99999)
    {
        return true;
    }
    else 
    {
    Console.Write("Число не пятизначное");
    return false;    
    }
    
}
    
bool IsPalindrome(int number)
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

// int number = GetUserInput("Введите пятизначное число");
bool fifthDigit = FifthDigit(number);
Console.WriteLine(fifthDigit  ? "Число не пятизначное");

bool result = IsPalindrome(number);
Console.WriteLine(result ? true : false);

// int firstDigit = number / 10000;
// int fifthDigit = number % 10;
// int secondDigit = number / 1000 % 10;
// int fourthDigit = number % 100 /10;

 