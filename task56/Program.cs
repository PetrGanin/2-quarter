// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] Smooth = new int[4, 4];
void ArrayRandom(int[,] array)
{
    for (int i = 0; i < Smooth.GetLength(0); i++)
    {
        for (int j = 0; j < Smooth.GetLength(1); j++)
        {
            Smooth[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
ArrayRandom(Smooth);
PrintArray(Smooth);
int min = 100;
int Sum = 0;
for (int rows = 0; rows < Smooth.GetLength(0); rows++)
{
    for (int columns = 0; columns < Smooth.GetLength(1); columns++)
    {
        Sum = Sum + Smooth[rows, columns];
    }
    Console.WriteLine($"Сумма строки по индексу {rows} = {Sum}");
    if(min > Sum)
    {
        min = Sum;
    }
    Sum = 0;
}
Console.WriteLine();
Console.WriteLine("Минимальная сумма строки: "+ min);