﻿// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.

string s_a = Console.ReadLine()!;
int a = int.Parse(s_a);

if (a == 1)
{
    Console.WriteLine("Monday");
}
else if (a == 2)
{
    Console.WriteLine("Tuesday");
}
else if (a == 3)
{
    Console.WriteLine("Wednesday");
}
else if (a == 4)
{
    Console.WriteLine("Thursday");
}
else if (a == 5)
{
    Console.WriteLine("Friday");
}
else if (a == 6)
{
    Console.WriteLine("Saturday");
}
else if (a == 7)
{
    Console.WriteLine("Sunday");
}
else
{
    Console.WriteLine("Wrong number");
}
