// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


void FillArray(int [,] table)
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
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] table = new int [rows,cols];
FillArray(table);
PrintArray(table);

int [,] newTable = new int[rows,cols];
for (int i = 0; i<cols;i++)
    for (int j = 0; j<rows;j++)
    {
        newTable [i,j] = table [j,i]; 
    }
    Console.WriteLine("Разворот: ");
    PrintArray(newTable);
    