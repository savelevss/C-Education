// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// double GetNum6()
// {
   
    Console.Write("Введите координату X для точки A ");
    int xa = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату Y для точки A ");
    int ya = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату Z для точки A ");
    int za = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату X для точки B ");
    int xb = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату Y для точки B ");
    int yb = Convert.ToInt32 (Console.ReadLine());
    Console.Write("Введите координату Z для точки B ");
    int zb = Convert.ToInt32 (Console.ReadLine());
    
    double AB = Math.Sqrt((xb-xa)^2+(yb-ya)^2+(zb-za)^2);
    Console.WriteLine(AB);
    // Console.Write("Расстояние между A и B в 3D пространстве равно ");
    // return AB;
    // }
// try
// {       
//        Console.WriteLine(GetNum6());
// }
// catch 
// {
//     Console.WriteLine("Нужно вводить только целые числа ");
//}