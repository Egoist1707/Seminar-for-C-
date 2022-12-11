// Задача №1:Нахождение максимального из трёх вводных чисел.

Console.WriteLine("Start");

int a = 2; // вариант №2 а = 44, вариант №3 а = 22
int b = 3; // вариант №2 b = 5, вариант №3 b = 3
int c = 7; // вариант №2 c = 78, вариант №3 c = 9

int max = a;

if (b > a) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
Console.WriteLine("End");