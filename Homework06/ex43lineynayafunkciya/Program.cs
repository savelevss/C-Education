// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите первый коэффициент первой прямой ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй коэффициент первой прямой ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первый коэффициент второй прямой ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй коэффициент второй прямой ");
double b2 = Convert.ToInt32(Console.ReadLine());
double y = 1;
double x = 1;
Console.WriteLine($"Первое линейное уравнение y = {k1}x+{b1} ");
Console.WriteLine($"Второе линейное уравнение y = {k2}x+{b2} ");

if (k1==k2&&b1==b2) 
{
    Console.WriteLine("Прямые совпадают");
}
else if (k1==k2)
{
      Console.WriteLine("Прямые параллельны");
}
else 
{
    x=(b2-b1)/(k1-k2);
    y=(k1*(b2-b1))/(k1-k2)+b1;
}
Console.WriteLine($" x = {x}");
Console.WriteLine($" y = {y}");
