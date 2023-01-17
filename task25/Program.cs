// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (без использования Math.Pow)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
long A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
long B = Convert.ToInt32(Console.ReadLine());
long count = 1;
long C = 1;
while (count < A)
{
    count++;
}
while (C < B)
{
    A = A * count;
    C++;
}
Console.WriteLine(A);
