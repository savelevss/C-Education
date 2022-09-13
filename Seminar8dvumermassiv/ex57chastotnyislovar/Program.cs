// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int [] FrequencyDictionary(int[,] table)
{
    int[] array = new int[10];
    for (int i = 0; i < table.GetLength(0); i++)
    {
    for (int j = 0; j < table.GetLength(1); j++)
        {
        array [table[i,j]]+=1;
        }
    }
    return array;
}

void PrintArray1(int[] table)
{
    for (int i = 0; i < table.Length; i++)
       {
        if (table[i]>0)
        Console.WriteLine($"{i} встречается  {table[i]} раз");
        }
    Console.WriteLine();
}

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] table = new int [rows,cols];
FillArray(table);
PrintArray(table);
Console.WriteLine();
PrintArray1(FrequencyDictionary(table));
