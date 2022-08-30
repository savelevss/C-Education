// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int N = 8;
int [] numbers = new int[N];
for(int i=0; i<N; i++)
{
    numbers[i] = new Random().Next(-100,100);
    if (i!=N-1) Console.Write($"{numbers[i]}, ");
    else Console.WriteLine($"{numbers[i]}");
}