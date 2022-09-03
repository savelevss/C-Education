// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// for (int i = 0; i < N; ++i) 
// {
// array[i] = new Random().Next(100, 1000);
// }
// Console.Write("[");
// for (int i = 0; i < N - 1; ++i) 
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine(array[N - 1] + "]");
// int count = 0;
// for (int i = 0; i < N - 1; ++i)
// {
//     if (array[i] % 2==0)
//     {
//         count = count+1;
//     }
// }
// Console.Write(count);


Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(100, 1000);
    }
    return array;
}

void printArray(int[] Array)
{
    foreach (int i in Array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("");
}

printArray(arr);

double chet = 0;
for (int i = 0; i < N; i++)
{
    if (arr[i] % 2==0)
    {
        chet = chet+1;
    }
}
Console.WriteLine(chet);
