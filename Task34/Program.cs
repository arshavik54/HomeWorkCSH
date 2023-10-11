// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2


int[] CreateCustomArray(int size, int min, int max)
{
int[] arr = new int[size];
Random rnd = new();
for (int i =0; i < size; i++){
    arr[i] = rnd.Next(min, max);
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

int EvenDigits(int[] arr)
{    
int count = 0;    
for (int i = 0; i < arr.Length; i++)
{
if (arr[i] % 2 == 0) count ++;
}
return count;
}  

Console.Write("[");
int[] randArr = CreateCustomArray(4, 100, 999);
PrintOut(randArr);
int result = EvenDigits(randArr);
Console.WriteLine($"]-> {result}");

