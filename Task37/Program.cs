// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ProductOfPairNumbers(int[] numbers)
{
int size = numbers.Length / 2 + numbers.Length % 2;
int[] prodOfPairs = new int[size];
for (int i = 0; i < size; i++)
{
prodOfPairs[i] = numbers[i] * numbers[numbers.Length - 1 - i];
}
if (numbers.Length % 2 != 0) prodOfPairs[size - 1] = numbers[numbers.Length / 2];
return prodOfPairs;
}

void PrintOut(int[] arr)
{
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.WriteLine($"{arr[^1]}");// ^1 последний элемент массива
}

int[] randArr = CreateArrarRndint(6, 1, 10);
int[] resArr = ProductOfPairNumbers(randArr);
PrintOut(randArr);
Console.Write(" -> ");
PrintOut(resArr);