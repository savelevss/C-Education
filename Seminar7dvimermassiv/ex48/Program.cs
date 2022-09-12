// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5 

// int[,] FillArray(int m, int n)
// {
// int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//     for (int j = 0; j < n; j++)
//         {
//         array[i,j] = i+j;
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] table)
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
// Console.WriteLine("Введите количество строк двумерного массива ");
// int m= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов двумерного массива ");
// int n= Convert.ToInt32(Console.ReadLine());
// int [,] mas = FillArray(m,n);
// PrintArray(mas);

//Подзадача. Упордочить массив случайных чисел


int[,] FillArray(int m, int n)
{
int [,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
    for (int j = 0; j < n; j++)
        {
        array[i,j] = new Random().Next (1,100);
        }
    }
    return array;
}
void PrintArray(int[,] table)
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
int[,] SortArray(int [,] arr)
{
int [,] arr = new int[m,n];
int minPosition = arr[i,j];    
    for (int i = 0; i < m; i++)
    {
    for (int j = 0; j < n; j++)
        {
        if (arr [i,j]<arr[minPosition]) minPosition = arr[i,j];
        }
    }
    return arr;
}





Console.WriteLine("Введите количество строк двумерного массива ");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива ");
int n= Convert.ToInt32(Console.ReadLine());
int [,] mas = FillArray(m,n);
PrintArray(mas);
