// 11. Напишите программу, которая 
// 1. выводит случайное трехзначное число и 
// 2. удаляет вторую цифру этого числа.
// 456 -> 46;
// 782 - 72;
// 918 -> 98;

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int thdDigit = num % 10;
    return  firstDigit * 10 + thdDigit;    
}


int number = new Random().Next(100, 1000); //999+1
Console.WriteLine(number);
// int firstDigit = number / 100;
// int thdDigit = number % 10;
// int result = firstDigit * 10 + thdDigit;
Console.WriteLine(DeleteSecondDigit(number));