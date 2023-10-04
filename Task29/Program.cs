// Задача 29: Напишите программу, которая 
// 1. задаёт массив из 8 элементов и 
// 3. выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] RandomArray(int arrLength)
{
    int[] arr = new int[arrLength];
    for (int i = 0; i < arrLength; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}



void PrintArray2(int[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]},");
        }
        else 
        {
            Console.Write($"{array[i]} -> [{RandomArray}]");
        } 
    }
}
int[] arr = RandomArray(8);
PrintArray2(arr);
