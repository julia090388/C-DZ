﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, 
// а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите число A : ");
int numberA = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
    System.Console.WriteLine("max = B min = A");
}
else
{
    System.Console.WriteLine("max = A min = B");
}