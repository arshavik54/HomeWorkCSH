// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


int[] RandomArray(int arrLength)
{
    int[] arr = new int[arrLength];
    Random rand = new Random();
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    string output = "[";
    for (int i = 0; i < array.Length; i++)
    {
        output += (i < array.Length - 1) ? $"{array[i]}," : $"{array[i]}]";
    }
    Console.WriteLine(output);
}

void PrintArray2(int[] array)
{
    Console.WriteLine("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.WriteLine($"{array[i]}, ");
        }
        else
        {
            Console.WriteLine($"{array[i]}]");
        }
    }
}
int[] arr = RandomArray(8);
PrintArray2(arr);