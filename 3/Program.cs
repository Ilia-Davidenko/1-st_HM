using System;
using static System.Console;

int x = new Random().Next(0, 9999);
WriteLine(x);
if (x%2 == 0)
{
    WriteLine("число четное");
}
else WriteLine("число НЕ четное");