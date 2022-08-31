// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMtrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }

    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3},");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("] ");
    }
}

void SrArif(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double srAr = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            srAr = srAr + matrix[j, i];
        }
        srAr = Math.Round(srAr / matrix.GetLength(0), 1);
        Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {srAr}");
    }
}

int[,] array2d = CreateMtrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);

Console.WriteLine();
SrArif(array2d);


