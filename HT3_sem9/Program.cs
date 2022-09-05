// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int num1, int num2)
{
  if (num1 == 0) return num2 + 1;
  else if (num2 == 0) return AkkermanFunction(num1 - 1, 1);
  else return AkkermanFunction(num1 - 1, AkkermanFunction(num1, num2 - 1));
}

int functAkk = AkkermanFunction(m, n);
Console.WriteLine($"Функция Аккермана = {functAkk} ");