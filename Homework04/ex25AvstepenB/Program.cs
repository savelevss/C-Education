﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int A1 = A;
int N = 1;
while(N < B)
{
    A=A*A1;
    N++;
}
Console.Write("Число A в степени B = ");

Console.WriteLine(A);
