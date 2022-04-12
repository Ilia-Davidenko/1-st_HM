using System;
using static System.Console;

int x = new Random().Next(0, 999);
WriteLine($"Первое число {x}");
int y = new Random().Next(0, 999);
WriteLine($"Второе число {y}");

if (x > y)
{
    WriteLine($"Большее число {x}, меньшее {y}");
}
else WriteLine($"Большее число {y}, меньшее {x}");