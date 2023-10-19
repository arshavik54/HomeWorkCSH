// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] GenerateRandomMatrix(int rows, int cols, int min, int max)
{
    int[,] matrix = new int[rows, cols];
    Random rand = new();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    string divider = string.Empty;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        divider += "------";
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} |");
        }
        Console.WriteLine();
        Console.WriteLine(divider);
    }
}

void SwapMatrixFirstLastRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int[,] rndMatrx = GenerateRandomMatrix(4, 5, 0, 10);
PrintMatrix(rndMatrx);
SwapMatrixFirstLastRow(rndMatrx);
Console.WriteLine();
PrintMatrix(rndMatrx);