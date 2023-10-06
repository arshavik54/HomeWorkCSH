// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int UserNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateCustomArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new();
    for (int i =0; i < size; i++){
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}

void PrintArrayInt(int[] arr) //Метод, который выводит массив
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[^1]}]");
}

int[] DuplicateArray(int[] array)
{
    int size = array.Length;
    int[] duplicateArray = new int[size];
    for (int i =0; i < size; i++)
    {
       duplicateArray[i] = array[i];
    }
    return duplicateArray;
}

Console.WriteLine("Create Array");
int userSize = UserNumber("Enter the size of array");
int userMin = UserNumber("Enter the min digit for range");
int userMax = UserNumber("Enter the max digit for range");
int[] userArray = CreateCustomArray(userSize, userMin, userMax);
PrintArrayInt(userArray);
int[] newArray = DuplicateArray(userArray);
// newArray[1] = 2000;
PrintArrayInt(newArray);