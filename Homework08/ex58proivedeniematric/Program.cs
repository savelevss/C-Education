// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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


int [,] tableA = new int [sizeTable,sizeTable];
Filltable(tableA);
Console.WriteLine("Матрица - А");
Printtable(tableA);
Console.WriteLine();
int [,] tableB = new int [sizeTable,sizeTable];
Filltable(tableB);
Console.WriteLine("Матрица - B");
Printtable(tableB);
Console.WriteLine();
int[,] tableC = new int[sizeTable, sizeTable];
int[,] MultiMatrix(int[,] tableA, int[,] tableB)
{
    
    for (int i = 0; i < tableA.GetLength(0); i++)
    {
        for (int j = 0; j < tableA.GetLength(0); j++)
        {
            for (int k = 0; k < tableA.GetLength(0); k++)
            {
                tableC[i, j] = tableC[i, j] + (tableA[i, k] * tableB[k, j]);
            }
        }
        
    }
    return tableC;
}

Console.WriteLine("Произведение матриц А*В");
MultiMatrix(tableA,tableB);
Printtable(tableC);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// void Filltable(int [,] table)
// {
//     Random random = new Random();
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//     for (int j = 0; j < table.GetLength(1); j++)
//         {
//         table[i,j] = new Random().Next (1,10);
//         }
//     }
// }
// void Printtable(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//     for (int j = 0; j < table.GetLength(1); j++)
//         {
//         Console.Write(table[i,j] + "\t" );
//         }
//     Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите размер квадратного массива ");
// int sizeTable = Convert.ToInt32(Console.ReadLine());


// int [,] tableA = new int [sizeTable,sizeTable];
// Filltable(tableA);
// Console.WriteLine("Матрица - А");
// Printtable(tableA);
// Console.WriteLine();
// int [,] tableB = new int [sizeTable,sizeTable];
// Filltable(tableB);
// Console.WriteLine("Матрица - B");
// Printtable(tableB);
// Console.WriteLine();

// int[,] tableC = new int[sizeTable, sizeTable];

// for (int i = 0; i < tableC.GetLength(0); i++)
// {
//     for (int j = 0; j < tableC.GetLength(0); j++)
//     {
//         for (int k = 0; k < tableC.GetLength(0); k++)
//         {
//             tableC[i, j] = tableC[i, j] + (tableA[i, k] * tableB[k, j]);
//         }
//     }
// }




// Console.WriteLine("Произведение матриц А*В");
// Printtable(tableC);