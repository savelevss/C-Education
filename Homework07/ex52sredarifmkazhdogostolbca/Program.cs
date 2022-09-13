// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double Middle(int[,] arr)
{
    double mid = 0;
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum=(sum+arr[j,i]);
        }
        mid = sum/arr.GetLength(0);
        sum = 0;
        
        Console.WriteLine($"Среднее арифметическое столбца {i+1} = {mid}"); 
            
    }
    return mid;
}
    


Console.WriteLine("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] mas = FillArray(m,n);
PrintArray(mas);
Console.WriteLine();
Console.WriteLine(Middle(mas));
