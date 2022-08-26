// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

void InterPoint(double num1, double numb1, double num2, double numb2)
{
    double x = (num2 - num1) / (numb1 - numb2);
    double y = (numb2 * x + num2);
    
    if (numb1 == numb2) Console.WriteLine("прямые параллельны");
    else  Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}

InterPoint(b1, k1, b2, k2);
  
