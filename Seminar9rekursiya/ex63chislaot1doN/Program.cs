// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"




string SequenceRec(int N)
{
    if (N==0) return String.Empty;
    return SequenceRec(N-1) + " " + Convert.ToString(N);
}

Console.Write("Введите число:   ");
string N = Console.ReadLine();
int count = Convert.ToInt32(N);
Console.WriteLine(SequenceRec(count));