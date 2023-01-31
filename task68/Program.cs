﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int FunAkkerman(int m,int n)
{
    if(m == 0)
    {
     return n+1;
    }
    else if(m > 0 && n == 0)
    {
    return FunAkkerman(m - 1, 1);
    }
    else
    {
        return FunAkkerman(m-1, FunAkkerman(m, n-1));
    }
}
Console.WriteLine("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());


int result = (FunAkkerman(m,n));
Console.WriteLine(FunAkkerman(m,n));
