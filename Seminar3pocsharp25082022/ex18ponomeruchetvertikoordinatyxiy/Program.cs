// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

string GetNum4()
{
    string res = "";
    Console.Write("Введите номер четверти ");
    int quart = int.Parse(Console.ReadLine());
    if      (quart == 1) res = "x>0 & y>0";
    else if (quart == 2) res = "x<0 & y>0";
    else if (quart == 3) res = "x<0 & y<0";
    else if (quart == 4) res = "x>0 & y<0";
    else                 res = "Введите число от 1 до 4";
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
