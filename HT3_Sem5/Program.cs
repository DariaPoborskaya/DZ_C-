// Задача 38: 
//1. Задайте массив вещественных чисел. 
//2. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

//Метод на создание массива вещественных чисел

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
            Console.Write($"{Math.Round(array[i], 2)}, ");
        else Console.Write($"{Math.Round(array[i], 2)}");
    }
    Console.WriteLine("]");
}

// Поиск макс значения

// double DifMaxMin(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//             Console.WriteLine(max);
//         }
//         if (array[i] < max)
//         {
//             min = array[i];
//             Console.WriteLine(min);
//         }
//     }
//     return max;

// }



//Поиск мин значения
// double MinValues(double[] array)
// {
//     double min = array[0];
//     double max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < max) min = array[i];
//     }
//     return min;
// }


double[] arr = CreateArrayRndDouble(7, 1, 99);
PrintArray(arr);

double maxNum = arr[0];
double minNum = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (maxNum < arr[i])
    {
        maxNum = arr[i];
    }
    if (minNum > arr[i])
    {
        minNum = arr[i];
    }
}

double diffRes = maxNum - minNum;

Console.WriteLine($"Максимальное число массива: {Math.Round(maxNum, 2)}");
Console.WriteLine($"Минимальное число массива: {Math.Round(minNum, 2)}");
Console.WriteLine($"Разница между максимальным и минимальным числами массива:{Math.Round(diffRes, 2)}");


