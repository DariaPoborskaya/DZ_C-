// Напишите программу, которая 
// 1. принимает на вход число (N) и 
// 2. выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintCube(int a)
{
    for ( int i=1; i<=a; i++)
    Console.WriteLine($"{i} -> {i*i*i}");
}
if (number < 1)
{
        Console.WriteLine("Введите число больше 1");
        return;
}
PrintCube(number);