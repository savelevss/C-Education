// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), \
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int GetNum4()
{
 Console.Write("Введите координату x ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите координату y ");
    int y = int.Parse(Console.ReadLine());
    int res;
    if (x>0 && y>0) res = 1;
    else if (x<0 && y>0) res = 2;
    else if (x<0 && y<0) res = 3;
    else if (x>0 && y<0) res = 4;
    else res=0;
    return res;
}
try
{
   
    Console.WriteLine(GetNum4());
}
catch 
{
    Console.WriteLine("Нужно вводить только целые числа ");
}