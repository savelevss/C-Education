// необязательная задача Написать программу сортировки массива от большего к меньшему. 
//Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.

Console.WriteLine("Введите целое натуральное число");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[N];
for(int i=0; i<N; i++)
{
    arr[i] = new Random().Next(0,100);
    
}


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}



PrintArray(arr);
SelectionSort (arr);

PrintArray(arr);
