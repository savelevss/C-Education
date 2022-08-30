// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите целое натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int sumDigit = 0;
Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}
Console.WriteLine(sumDigit);


