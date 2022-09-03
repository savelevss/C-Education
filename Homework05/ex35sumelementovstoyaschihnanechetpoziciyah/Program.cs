// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(1, 10);
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

int sum = 0;
for (int i = 0; i < N; i++)
{
    if (i%2!=0)
    {
        sum = sum+arr[i];
    }
}
Console.WriteLine(sum);
