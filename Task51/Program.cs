// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] GenerateRandom2DArray0100(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 100);
        }
    }


    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}

int MainDiagonalSumElem(int[,] matrix)
{
    int result = 0;
    // int min = matrix.GetLength(0);
    // if (min > matrix.GetLength(1)) min = matrix.GetLength(1);

    //  for (int i = 0; i < min; i++)
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result += matrix[i, i];
    }
    return result;
}

int m = 6;
int n = 2;
int[,] randomMatrix = GenerateRandom2DArray0100(m, n);
Print2DArray(randomMatrix);
int sum = MainDiagonalSumElem(randomMatrix);
Console.WriteLine($"Sum of the elements: {sum}");


