// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = 1;

void Number( int N, int M)
{

    if(N == M+1)
    {
        return;
    }
    Number(N+1, M);
    Console.Write(N + " ");
}
Number(n,m);