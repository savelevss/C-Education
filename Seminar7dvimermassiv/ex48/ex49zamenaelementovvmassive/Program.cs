// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] FillArray(int m, int n)
{
int [,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
    for (int j = 0; j < n; j++)
        {
        array[i,j] = new Random().Next (1,10);
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

int [,] Change(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
        {
        if (i%2==1&&j%2==1) 
        {
            arr[i,j] = arr[i,j]*arr[i,j];
        }
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
Console.WriteLine();
int [,] zamena = Change(mas);
PrintArray(zamena);
