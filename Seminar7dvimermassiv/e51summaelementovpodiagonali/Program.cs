//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.


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

int  DiagonalSum(int [,] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    for (int j = 0; j < arr.GetLength(1); j++)
        {
        if (i==j) 
        {
            sum = sum + arr[i,j];
        }
        }       
    }
    return sum;
}

Console.WriteLine("Введите количество строк двумерного массива ");
int m= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива ");
int n= Convert.ToInt32(Console.ReadLine());
int [,] mas = FillArray(m,n);
PrintArray(mas);
Console.WriteLine(DiagonalSum(mas));

