// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


    
Console.Write("Введите число M:   ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N:   ");
int n = Convert.ToInt32(Console.ReadLine());
    
Console.WriteLine($"Сумма элементов от {m} до {n} = {SumRec(m, n)}");

int SumRec(int m, int n)
{
    if (m == n)  return n;
    return n + SumRec(m, n - 1);
}

