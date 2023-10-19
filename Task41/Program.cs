// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

int GetUserInput(string str)
 {
    Console.Write(str);
    Console.ReadLine();
    return Convert.ToInt32(Console.ReadLine());
 }

int[] CreateArray( int numbers)
{
    int[] arr = new int[numbers];
    for (int i = 0; i < arr.Length; i++){
    arr[i] = GetUserInput("Введите {i + 1} элемент");
    }
    return arr;
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length - 1; i++)
{
Console.Write($"{arr[i]}, ");
}
Console.Write($"{arr[^1]}");
}

 int CountPositiveNumbers(int[] arr)
 {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
 }

int numbers = GetUserInput("Введите колличество элементов >");
int[] arr;
arr = CreateArray(numbers);
int result = CountPositiveNumbers(arr);
Console.WriteLine($"колличество чисел больше 0 -> {result}");



// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// Console.WriteLine($"Кол-во элементов > 0: {count}");