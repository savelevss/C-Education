//разворот одномерного массива

int n=9;
void PrintArray(int[] arr)
{
    for(int i = 0; i < n; i++)
    {
        if (i!=arr.Length-1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}");
    }
}

int [] numbers = new int[n];
for(int i = 0; i < n; i++)
{
    numbers[i] = new Random().Next(0,100);
}
PrintArray(numbers);
Console.WriteLine();
int buf;
for(int i = 0; i < n/2; i++)
{
    buf = numbers[i];
    numbers[i] = numbers[n-1-i];
    numbers[n-1-i] = buf;
}
PrintArray(numbers);
