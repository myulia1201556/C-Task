﻿// Напишите программу, которая на вход 
// принимает два числа и выдаёт, какое 
// число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

    if (a > b)
    {
        Console.Write($"Максимальное число {a} и минимальное число {b}");
    }
    else if (a == b)
    {
        Console.Write($"Числа {a} и {b} равны");
    }
    else if (b > a)
    {
        Console.Write($"Максимальное число {b} и минимальное число {a}");
    }
