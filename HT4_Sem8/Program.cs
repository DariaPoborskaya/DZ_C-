// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateMatrixRndInt(int length, int heigth, int wingth, int min, int max)
{
    int[,,] matrix = new int[length, heigth, wingth];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int g = 0; g < matrix.GetLength(2); g++)
            {
                matrix[i, j, g] = new Random().Next(min, max + 1);
            }
        }

    }

    return matrix;
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"X({i}) Y({j}) ");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write( $"Z({k})={matrix[i,j,k]}; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,,] array3D = CreateMatrixRndInt(2, 2, 2, 10, 100);
PrintMatrix(array3D);