// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число > ");
int value1 = Convert.ToInt32(Console.ReadLine());
int isEven = value1 % 2;
if (isEven == 0)
{
    System.Console.WriteLine($"Введенное число {value1} является четным");
}
else
{
    System.Console.WriteLine($"Введенное число {value1} является не четным");
}