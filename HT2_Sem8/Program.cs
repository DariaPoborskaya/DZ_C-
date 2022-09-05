// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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

// int SumRow(int[,] matrix, int row)
// {
//     int sumRow = matrix[row, 0];
//     for (int j = 1; j < matrix.GetLength(1); j++)
//     {
//         sumRow += matrix[row, j];
//     }
//     return sumRow;
// }


int[,] array2d = CreateMtrixRndInt(2, 4, 1, 10);
PrintMatrix(array2d);

int sum = 0;
int index = 0;
for (int i = 0; i < array2d.GetLength(0); i++)
{
    int temp = 0;
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        temp += array2d[i, j];
    }
    if (temp > sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine();
for (int i = 0; i < array2d.GetLength(1); i++)
{
    Console.Write(array2d[index+1, i]);
}
Console.WriteLine();

