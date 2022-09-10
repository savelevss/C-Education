// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 5
// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел ");
int M = Convert.ToInt32(Console.ReadLine());
int []arr = new int[M];
for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число ");
    arr [i] = Convert.ToInt32(Console.ReadLine());
    
}


