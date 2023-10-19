// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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


int[] FindLowestValueRowCol(int[,] matrix)
{
    int rowNum = 0;
    int colNum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[rowNum, colNum])
            {
                rowNum = i;
                colNum = j;
            }
        }
    }
    return new int[] { rowNum, colNum };
}

int[,] MatrixRowColDelByCoords(int[,] matrix, int rowTodel, int colTodel)
{
    int[,] resMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];

    int row = 0;
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        if (i == rowTodel) row++;
        int col = 0;
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            if (j == colTodel) col++;
            resMatrix[i, j] = matrix[row, col];
            col++;
        }
        row++;
    }
    return resMatrix;
}

int[,] rndMtrx = GenerateRandomMatrix(4, 3, 0, 10);
PrintMatrix(rndMtrx);
int[] coords = FindLowestValueRowCol(rndMtrx);
Console.WriteLine($"row {coords[0]} col {coords[1]} min val = {rndMtrx[coords[0], coords[1]]}");
int[,] resMtrx = MatrixRowColDelByCoords(rndMtrx, coords[0], coords[1]);
PrintMatrix(resMtrx);