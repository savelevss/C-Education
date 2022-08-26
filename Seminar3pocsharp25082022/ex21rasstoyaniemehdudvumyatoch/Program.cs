// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

double GetNum5()
{
    Console.Write("Введите координату X для точки A ");
    int xa = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату Y для точки A ");
    int ya = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату X для точки B ");
    int xb = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату Y для точки B ");
    int yb = Convert.ToInt32 (Console.ReadLine());
    int xc = xa;
    int yc = yb;
    int AC = (ya-yb);
    int BC = (xa-xb);
    double AB = Math.Sqrt(AC*AC + BC*BC);
    Console.Write("Расстояние между A и B в 2D пространстве равно ");
    return AB;  
      
}
try
{       
       Console.WriteLine(GetNum5());
}
catch 
{
    Console.WriteLine("Нужно вводить только целые числа ");
}
