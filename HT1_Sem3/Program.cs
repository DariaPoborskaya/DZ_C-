// Задача 19
// Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
//  if (n >= 100 && n < 100000)
//  {
//     int ShowFerstDigit(int num
//     )
//  }

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1 = number;
int num2 = 0;
while (number > 0)
{
    int dig = number % 10;
    num2 = num2 * 10 + dig;
    number = number / 10;
}
if (num1 == num2) Console.WriteLine("Число является полиндромом");
else Console.WriteLine("Число не является полиндромом");
// if (number >= 100 && number < 100000)
// else Console.WriteLine("Введите корректное число");      