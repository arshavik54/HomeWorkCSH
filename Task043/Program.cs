//  Задача 43: Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int GetUserInputInt(string msg)
{
    Write(msg);
    int intNum = Convert.ToInt32(ReadLine());
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
        Write(i == arr.Length - 1 ? $"{arr[i]})" : $"({arr[i]}; ");
    }
}

WriteLine("Программа для определения точки пересечения двух прямых вида y = kx + b");
WriteLine("");
double k01 = GetUserInputInt("Для первой прямой введите угловой коэффициент k1: ");
double b01 = GetUserInputInt("Для первой прямой введите коэффициент b1: ");
double k02 = GetUserInputInt("Для второй прямой введите угловой коэффициент k2: ");
double b02 = GetUserInputInt("Для второй прямой введите коэффициент b2: ");

if (k01 == k02 && b01 == b02) WriteLine("Прямые совпадают");
else if (k01 == k02) WriteLine("Прямые параллельны и не имеют точек пересечения");
else 
{
    WriteLine("");    
    double[] resultPoint = PointOfIntersect(k01, b01, k02, b02);
    Write($"k1 = {k01}, b1 = {b01}, k2 = {k02}, b2 = {b02} -> ");
    PrintArray(resultPoint);
}

