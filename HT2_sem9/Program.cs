// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int sum = m;

void PrintSum(int num1, int num2, int summ)
{
  summ = summ + num2;
  if (num2 <= num1)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSum(num1, num2 - 1, summ);
}

if (m > n) 
{
  m = n; 
  n = sum;
}

PrintSum(m, n, sum = 0);