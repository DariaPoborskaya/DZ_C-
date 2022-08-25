// Задача 36: 
//1. Задайте одномерный массив, заполненный случайными числами. 
//2. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int SumEvenPosition(int size, int min, int max)
{
    int[] array = new int[size];
    int sumPos = 0;


    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}"); 
    
        if (i % 2 != 1)
        {
            sumPos = sumPos + array[i];
        }
    }
    Console.WriteLine("]");
    return sumPos;
    
}
int sum = SumEvenPosition(size, -10, 10);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sum}");