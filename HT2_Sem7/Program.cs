// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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

Console.WriteLine("Введите размерность массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = CreateMtrixRndInt(m, n, 1, 10);
PrintMatrix(array2d);

Console.WriteLine("Введите координаты");
int numberRow = Convert.ToInt32(Console.ReadLine());
int numberCol = Convert.ToInt32(Console.ReadLine());
if (numberRow > m && numberCol > n)
    Console.WriteLine("такого числа нет");
else
{
    object element = array2d.GetValue(numberRow, numberCol);
    Console.WriteLine($"Элемент массива: {element}");
}


 




