// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(1, 100);
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

double zadacha(int[] array)
{
        int max = array[0];
   
    for (int i = 0; i < N; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                
            }
        }

        int min = array[0];
    
    for (int i = 0; i < N; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            
        }
           
    }
       double diff = 0;
    foreach(int i in array)
    {
        diff += i;
    }
    diff = max - min;
    double answer = diff;
    return answer;
}
printArray(arr);
double answer = zadacha(arr);

Console.WriteLine(answer);

