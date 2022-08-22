//12. Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли наименьшее число кратным наибольшему. 
//Если  наибольшее не кратно наименьшему, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

Random rd = new Random();
string Task(int input1, int input2)
        {
            int max = input1;
            int min = input2;
            if (input1>input2)
            {
                max=input2;
                min=input1;
            }
            int ostatok = min%max;
            if (ostatok==0) 
            {
                return ("кратно");
            }
            else 
            {
                return ($"не кратно, остаток {ostatok}");
            }
        }
    int a = rd.Next(10,1000);
    int b = rd.Next(10,1000);
    Console.WriteLine ($"Случайные числа сгенерировались " + $"{a}, {b}");
    Console.WriteLine (Task(a,b));


