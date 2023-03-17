﻿// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число для M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число для N: ");
int N = Convert.ToInt32(Console.ReadLine());


int PrintSum(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.WriteLine(PrintSum(M, N));

