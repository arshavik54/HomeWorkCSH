// Задача 32: Напишите программу 
// 1. замена элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


int[] CreateArrarRndint(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = rnd.Next(min, max + 1);
}

return arr;
}

void SignInversion(int[] numbers)
{
for (int i = 0; i < numbers.Length; i++)
{
// numbers[i] *= -1;
numbers[i] = -numbers[i];
}
}

void PrintOut(int[] arr)
{
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
// arr[^1] последний эллемент массива
Console.WriteLine($"{arr[^1]}");
}
int[] randArr = CreateArrarRndint(5, -10, 11);
PrintOut(randArr);
SignInversion(randArr);
PrintOut(randArr);