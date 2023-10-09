// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих
//  на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateCustomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

int SumOddPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
        if (i % 2 == 1) sum += arr[i];
    return sum;
}


void PrintOut(int[] arr)
{

    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[^1]}] -> ");// ^1 последний элемент массива
}

Console.Write("[");
int[] randArr = CreateCustomArray(4, -10, 99);
int result = SumOddPosition(randArr);
PrintOut(randArr);

Console.WriteLine($" {result}");

