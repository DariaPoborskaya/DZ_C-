// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
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

// void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix)
// {
//     int[,] resultMatrix = new int[firstMartrix.GetLength(0), secondMartrix.GetLength(1)];

//     for (int i = 0; i < firstMartrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMartrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMartrix.GetLength(1); k++)
//             {
//                 sum += firstMartrix[i, k] * secondMartrix[k, j];
//             }
//             resultMatrix[i, j] = sum;
//             Console.WriteLine($"Произведение двух матриц: {resultMatrix}");
//         }
//     }
// }



int[,] firstMatr = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(firstMatr);
Console.WriteLine();
int[,] secondMatr = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(secondMatr);

int[,] resultMatrix = new int[firstMatr.GetLength(0), secondMatr.GetLength(1)];

for (int i = 0; i < firstMatr.GetLength(0); i++)
{
    for (int j = 0; j < secondMatr.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < firstMatr.GetLength(1); k++)
        {
            sum += firstMatr[i, k] * secondMatr[k, j];
        }
        resultMatrix[i, j] = sum;
    }
}

Console.WriteLine("Произведение двух матриц: ");
PrintMatrix(resultMatrix);



