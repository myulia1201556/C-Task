// Задача 4. 
//Напишите программу, которая принимает 
// на вход три числа и выдаёт максимальное
//  из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if ((a > b) && (a > c))
{
    Console.Write($"Максимальное число {a} ");
}
else if ((b > a) && (b > c))
{
    Console.Write($"Максимальное число {b} ");
}
else if ((c > a) && (c > b))
{
    Console.Write($"Максимальное число {c} ");
}
else if (a == b)
{
    Console.Write($"Максимальное число {a} и {b} равны");
}
else if (a == c)
{
    Console.Write($"Максимальное число {a} и {c} равны");
}
else if (b == c)
{
    Console.Write($"Максимальное число {b} и {c} равны");
}

