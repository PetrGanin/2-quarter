// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumLength(int begin, int end)
{
    if (end == begin)
    {
        return end;
    }
    return begin + SumLength(begin + 1, end);
}


Console.Write("Введите меньшее число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write("Введите большее число: ");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел: " + SumLength(N, M));