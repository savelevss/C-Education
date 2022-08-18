// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//             5 -> Пятница

Console.Write("Введите число дня недели ");
int x = int.Parse(Console.ReadLine());

if (x==1)
Console.WriteLine("Это понедельник");

if (x==2)
Console.WriteLine("Это вторник");

if (x==3)
Console.WriteLine("Это среда");

if (x==4)
Console.WriteLine("Это четверг");

if (x==5)
Console.WriteLine("Это пятница");

if (x==6)
Console.WriteLine("Это суббота");

if (x==7)
Console.WriteLine("Это воскресенье");
else 
Console.WriteLine("Введите число от 1 до 7");