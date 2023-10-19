// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateMatrix(int rows, int columns, int minValue, int maxValue) //Метод, который создает двумерный массив
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(minValue, maxValue);

        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //Метод, который выводит двумерный массив в консоль
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SwapColumnsRowsMatrix(int[,] matrix) //Метод, который меняет столбцы со строками
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
}



int[,] customMatrix = CreateMatrix(4, 4, 0, 10);
PrintMatrix(customMatrix);
Console.WriteLine("Swapping Columns and Rows");
if (customMatrix.GetLength(0) == customMatrix.GetLength(1))
{
    SwapColumnsRowsMatrix(customMatrix);
    PrintMatrix(customMatrix);
}
else
    Console.WriteLine("Swapping impossible");