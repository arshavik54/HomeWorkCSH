// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
// {
//     //                              0       1
//     double[,] matrix = new double[rows, columns]; // rows = 3, columns = 4
//     Random rnd = new Random();

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             matrix[i, j] = rnd.NextDouble();
//         }
//     }

//     return matrix;
// }

// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j], 5:F1} ");
//         }
//         Console.WriteLine("  |");
//     }

// }

// double[,] array2d = CreateMatrixRndDouble(3, 4, -10, 10);
// PrintMatrix(array2d);


// Вариант С Автотеста


 static double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) 
{
    //                                          0       1
    double[,] matrix = new double[m, n]; // rows = 3, columns = 4
    Random rnd = new Random();

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.NextDouble();
        }
    }
    return matrix;
}

void PrintMatrix (int row0, int row1, int row2, int column0, int column1, int column2, int column3)
{
     for (int i = 0; row0 < [2](0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++);
    }
    return;
}

//   // Не удаляйте и не меняйте метод Main! 
 static void Main(string[] args)
 {
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) 
    {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);
    }
 }
       // Выберем случайные индексы трех элементов матрицы array
       double CreateArrayRowColDouble(int row1, int col1, int row2, int col2, int  row3, int col3)
       {
        double[] array = new double[row1, col1, row2, col2, row3, col3]; 
       }
    
        int row1 = new Random().Next(-2);
        int col1 = new Random().Next(0,5);
        int row2 = new Random().Next(8);
        int col2 = new Random().Next(-3);
        int row3 = new Random().Next(-7,8);
        int col3 = new Random().Next(7);
        

        // Проверяем, являются ли выбранные элементы дробными числами
    
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

       
    

       

        // Если два из трех элементов не являются дробными числами, то бросаем исключение

        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }

    m = 3;
    n = 4;
    minLimitRandom = -10;
    maxLimitRandom = 10;
    double[,] result = CreateCustomMatrix(m, n, minLimitRandom, maxLimitRandom);
    PrintArray(result);

