// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int arraySize = 123;
int[] array = new int[arraySize];
for (int i = 0; i < arraySize; ++i) {
array[i] = new Random().Next(-100, 100);
}
int count = 0;
for (int i = 0; i < arraySize - 1; ++i) {
Console.Write($"{array[i]}, ");
}
Console.WriteLine(array[arraySize - 1]);
for (int i = 0; i < arraySize; ++i) {
if (array[i] >= 10 && array[i] <= 99) {
count++;
}
}
Console.WriteLine($"Количество элементов в промежутке [10, 99] - {count}");