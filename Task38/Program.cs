// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateCustomArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

double MaxDigit(double[] arr, double number)
{
     Double Max = number;
     for (double i = 0; i < arr.Length; i++)
     if (i > Max) i = Max;
    return Max;
}

double MinDigit(double[] arr, double number)
{
     Double Min = number;
     for (double i = 0; i < arr.Length; i++)
     if (i < Min) i = Min;
    return Min;
}

double Difference(int maxdigit, int mindigit)
{
maxdigit = MaxDigit; mindigit = MinDigit;
difference = Difference; 

}
void PrintArrayDouble(double[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}:F1, ");
    }
    Console.Write($"{arr[^1]}]:F1 {MaxDigit} - {MinDigit} -> {Difference}");// ^1 последний элемент массива
}


double[] CreateArrarRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

// double[] CreateArrarRndDouble(int size, int min, int max)
// {
// double[] arr = new double[size];
// Random rnd = new Random();

// for (int i = 0; i < size; i++)
// {
// arr[i] = rnd.NextDouble() * (max - min) + min;
// }

// return arr;
// }

// void PrintArrayDouble(double[] arr)
// {
// Console.Write("[");
// for (int i = 0; i < arr.Length; i++)
// {
// if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
// else Console.Write($"{arr[i]}");
// }
// Console.WriteLine("]");
// }