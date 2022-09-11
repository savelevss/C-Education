// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 5
// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4


Console.WriteLine("Введите целое число");
int M = Convert.ToInt32(Console.ReadLine());              
int count = 0;

while (M > 0)
{
    Console.Write("Введите число:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    M--;
}
Console.WriteLine($"Количество чисел больше 0: {count}");