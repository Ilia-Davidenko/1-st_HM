using System;
using static System.Console;

int x = new Random().Next(0, 999);
WriteLine($"Первое число {x}");
int y = new Random().Next(0, 999);
WriteLine($"Второе число {y}");
int z = new Random().Next(0, 999);
WriteLine($"Третье число {z}");
int max = x;

if (y > max)
{
    max = y;
}
if (z > max)
{
    max = z;
}
WriteLine($"Максимальное число {max}");