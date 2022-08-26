// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




Console.Write("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());

int firstpare = number / 1000;
Console.WriteLine(firstpare);

int lastpare = number%100;
Console.WriteLine(lastpare);

int A = firstpare/10;
Console.WriteLine(A);
int B = lastpare/10;
Console.WriteLine(B);
int N = B*10+A;
Console.WriteLine(N);
if (N == lastpare)
Console.WriteLine("Число палиндром!");
else 
Console.WriteLine("Число не палиндром!");




