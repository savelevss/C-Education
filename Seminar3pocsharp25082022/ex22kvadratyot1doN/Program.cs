// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

void SquareTableN()
{
    Console.Write("Введите целое число ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N>0)
    {
        for (int i = 1; i<(N+1); i++)
        {
            Console.Write ($"{i*i}, ");
        }
    }
    else
    {
        Console.Write("Введите положительные числа");
    }
}
try 
{
    SquareTableN();
}
catch
{
    Console.Write("Введите только положительные числа");
}
