// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


string SequenceRec(int M, int N)
{
    if (N==M-1) return String.Empty;
    return SequenceRec(M, N-1)+ " " + Convert.ToString(N);
}
try
{
    Console.Write("Введите число M:   ");
    string M = Console.ReadLine();
    int count1 = Convert.ToInt32(M);
    Console.Write("Введите число N:   ");
    string N = Console.ReadLine();
    int count2 = Convert.ToInt32(N);
    Console.WriteLine(SequenceRec(count1,count2));
}
catch
{
    Console.WriteLine("Введите натуральное число!");
}