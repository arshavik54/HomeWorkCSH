﻿// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на первом
// месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateArrarRndInt(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new Random();

for (int i = 0; i < size; i++)
{
arr[i] = rnd.Next(min, max + 1);
}
return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

void ReverseArray(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int temp = arr[i];// 2
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
}

int[] array = CreateArrarRndInt(5, 1, 9);
PrintArray(array);
ReverseArray(array);
PrintArray(array);

// Array.Reverse(array);
// PrintArray(array);