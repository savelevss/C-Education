// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Filltable(int [,] table)
{
    Random random = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
    for (int j = 0; j < table.GetLength(1); j++)
        {
        table[i,j] = new Random().Next (1,10);
        }
    }
}
void Printtable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
    for (int j = 0; j < table.GetLength(1); j++)
        {
        Console.Write(table[i,j] + "\t" );
        }
    Console.WriteLine();
    }
}






Console.WriteLine("Введите размер квадратного массива ");
int sizeTable = Convert.ToInt32(Console.ReadLine());


int [,] table = new int [sizeTable,sizeTable];
Filltable(table);
Printtable(table);
Console.WriteLine();
int minsum = 100;
int indexLine = 0;

int MinSum(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum = sum + table[i, j];        
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }
    return indexLine;
}
Console.Write("Номер строки с минимальной суммой элементов - ");
Console.WriteLine(MinSum(table));