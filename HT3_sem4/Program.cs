// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]  

int []array = {1, 2, 5, 7, 19, 6, 1, 33};

void PrintArray(int []arr)
{
    int count = arr.Length;//в нашем случае count = 8
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

PrintArray(array);
