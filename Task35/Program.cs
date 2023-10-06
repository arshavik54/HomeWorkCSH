// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CreateArrRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = rnd.Next(min, max + 1);
}

return arr;
}

void PrintOut(int[] arr)
{
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.Write($"{arr[^1]}");// ^1 последний элемент массива
}

int CountOfNumbersInRange(int[] arr, int min, int max)
{
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] >= min && arr[i] <= max) count++;
}
return count;
}

int[] randArr = CreateArrRndInt(123, -100, 100);
PrintOut(randArr);
int result = CountOfNumbersInRange(randArr, 10, 99);
Console.WriteLine($" -> {result}");