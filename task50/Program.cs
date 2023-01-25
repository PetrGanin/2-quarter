// задача 50; Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArrayRealNamber(int[,] array, int m, int n)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (i == m && j == n)
            {
                Console.Write("число под номером индексов: " + array[i, j]);
                return;
            }
            else if (m >= 4 || n >= 4)
            {
                Console.WriteLine("такого элемента не существует");
                return;
            }
        }
    }
}

int[,] matrix = new int[4, 4];
FillArrayWithRandom(matrix);

Console.Write("Введите номер индекса строки:" + " ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер индекса столбца:" + " ");
int n = Convert.ToInt32(Console.ReadLine());
ArrayRealNamber(matrix, m, n);

