// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

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


double MaxDigit(double[] arr, double maxNum)
{
     Double max = maxNum;
     for (double i = 0; i < arr.Length; i++)
     {
         if (i > max) i = max;
     }
    return max;
}

double MinDigit(double[] arr, double minNum)
{
     Double min = minNum;
     for (double i = 0; i < arr.Length; i++)
     {
         if (i < min) i = min;
     }
    return min;
}
double DifferenceDigits(double MaxNum, double MinNum, double result)
{
    result = MaxNum - MinNum;
    return result;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]:F2}; ");     // F2 - знаки после запятой
    }
    Console.Write($"{arr[^1]:F2}] {MaxDigit} - {MinDigit} -> {DifferenceDigits}");// ^1 последний элемент массива
}
   
double[] randArr  = CreateArrarRndDouble(6, 1, 10);
PrintArrayDouble(randArr);





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