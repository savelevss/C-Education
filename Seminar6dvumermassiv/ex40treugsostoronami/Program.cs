//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон

bool TrianglePossible(int a, int b, int c)
{
    return (a<b+c&&b<a+c&&c<a+b);
}
void ex40()
{
    Console.Write("Введите число a ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число b ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число c ");
    int c = Convert.ToInt32(Console.ReadLine());
    Console.Write($"{a},{b},{c} - треугольник ");
    if(!TrianglePossible(a,b,c))
    {
    Console.Write("не ");
    }
    Console.WriteLine("существует.");
}

ex40();