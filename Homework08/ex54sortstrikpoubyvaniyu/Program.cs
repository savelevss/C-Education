// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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



void SortTableRows(int[,] table)
{
  for (int i = 0; i < table.GetLength(0); i++)
  {
    for (int j = 0; j < table.GetLength(1); j++)
    {
      for (int k = 0; k < table.GetLength(1) - 1; k++)
      {
        if (table[i, k] > table[i, k + 1])
        {
          int temporary = table[i, k + 1];
          table[i, k + 1] = table[i, k];
          table[i, k] = temporary;
        }
      }
    }
  }
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] table = new int [rows,cols];
Filltable(table);
Printtable(table);
Console.WriteLine("Массив после сортировки строк");
SortTableRows(table);
Printtable(table);

