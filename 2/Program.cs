﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите перве число > ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число > ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите треть число > ");
int value3 = Convert.ToInt32(Console.ReadLine());

int max = value1;
if (max < value2)
{
    max = value2;
}
if (max < value3)
{
    max = value3;
}
System.Console.WriteLine($"Из введенных чисел {value1}, {value2}, {value3} максимальным является {max}");