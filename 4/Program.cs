using System;
using static System.Console;

WriteLine("Введите число");
int x = Convert.ToInt32(ReadLine());
int count = 1;

while (count <= x)
{
    if (count % 2 == 0)
    {
        WriteLine(count);
        count++;
    }
    else count++;
}