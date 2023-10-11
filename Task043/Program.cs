//  Задача 43: Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int GetUserInputInt(string msg)
{
    Console.Write(msg);
    int intNum = Convert.ToInt32(Console.ReadLine());
    return intNum;
}

double[] PointOfIntersect(double k1, double b1, double k2, double b2)
{
    double[] arr = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    arr[0] = Math.Round(x, 2, MidpointRounding.AwayFromZero);
    arr[1] = Math.Round(y, 2, MidpointRounding.AwayFromZero);
    return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i == arr.Length - 1 ? $"{arr[i]})" : $"({arr[i]}; ");
    }
}

Console.WriteLine("Программа для определения точки пересечения двух прямых вида y = kx + b");
Console.WriteLine("");
double k01 = GetUserInputInt("Для первой прямой введите k1: ");
double b01 = GetUserInputInt("Для первой прямой введите b1: ");
double k02 = GetUserInputInt("Для второй прямой введите k2: ");
double b02 = GetUserInputInt("Для второй прямой введите b2: ");

if (k01 == k02 && b01 == b02)  Console.WriteLine("Прямые совпадают");
else if (k01 == k02)  Console.WriteLine("Прямые параллельны и не имеют точек пересечения");
else 
{
     Console.WriteLine("");    
    double[] resultPoint = PointOfIntersect(k01, b01, k02, b02);
     Console.Write($"k1 = {k01}, b1 = {b01}, k2 = {k02}, b2 = {b02} -> ");
    PrintArray(resultPoint);
}

