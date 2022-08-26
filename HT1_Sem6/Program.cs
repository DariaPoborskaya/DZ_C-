// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] numbers = StringToNum(Console.ReadLine());
PrintArray(numbers);
int amount = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        amount++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 = {amount}");


int[] StringToNum(string num)
{
    int count = 1;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < num.Length; i++)
    {
        string temp = "";

        while (num[i] != ',')
        {
        if(i != num.Length - 1)
        {
            temp += num[i].ToString();
            i++;
        }
        else
        {
            temp += num[i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}