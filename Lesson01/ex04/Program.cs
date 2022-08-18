// Написать программу, которая на вход принимает число N, и выводит числа в диапазоне от -N до N


Console.Write("Введите число  ");
int x = int.Parse(Console.ReadLine());
int count = 0;
while (count<x+x+1)
{
Console.Write(-x+count);
count++;
}




