// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string RangeCoordinates(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти");
int quater = Convert.ToInt32(Console.ReadLine());

string rangeCoordinates = RangeCoordinates(quater);

string result = rangeCoordinates != null
                ? $"Диапазон координат для указанной четверти, {rangeCoordinates}"
                : "Введен некоррекнтый номер четверти";

Console.WriteLine(result);

