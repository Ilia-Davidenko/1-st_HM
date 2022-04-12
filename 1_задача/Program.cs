using System;
using static System.Console;

WriteLine("Введите первое число");
int x = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int y = Convert.ToInt32(ReadLine());

if (x > y)
{
    WriteLine($"Большее число {x}, меньшее {y}");
}
else WriteLine($"Большее число {y}, меньшее {x}");