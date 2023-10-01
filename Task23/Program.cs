// 23. Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдает таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.
// 5 -> 1, 8, 27, 64, 125.

void CubeNumbers (int num) 
{
    int count = 1;
    while (count <= num) {
        Console.WriteLine($"{count, 3} -> {count*count*count, 5}");
        count++;
    }
}

Console.WriteLine ("Введите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
CubeNumbers(userNum);
