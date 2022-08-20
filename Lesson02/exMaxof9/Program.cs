int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}





int a1 = 15212;
int b1 = 221211;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 313;

//int max1 = Max(a1,b1,c1); второй вариант решения
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);

//if (b1 > max) max = b1;  первый вариант решения
//if (c1 > max) max = c1;

//if (a2 > max) max = a2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = a3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

int max = Max(              //Третий вариант решения (через функцию)
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));
Console.WriteLine(max);


