// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void FillArrayWithRandom(double[,] matrix)
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

void ArithmeticMean(double [,] matrix, double a, double b, double v, double g)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            if (j == 0 && i <= 4)
            {
                a += matrix[i, j]/4;
            }
            else if (j == 1 && i <= 4)
            {
                b += matrix[i, j]/4;
            }
            else if (j == 2 && i <= 4)
            {
                v += matrix[i, j]/4;
            }
            else if (j == 3 && i <= 4)
            {
                g += matrix[i, j]/4;
            }
        }
    }
    Console.WriteLine("среднее орефметическое столбца индекса 0: " + a);
    Console.WriteLine("среднее орефметическое столбца индекса 1: " + b);
    Console.WriteLine("среднее орефметическое столбца индекса 2: " + v);
    Console.WriteLine("среднее орефметическое столбца индекса 3: " + g);
}

double[,] matrix = new double [4, 4];
double a = 0;
double b = 0;
double v = 0;
double g = 0;

FillArrayWithRandom(matrix);
ArithmeticMean(matrix, a, b, v, g);