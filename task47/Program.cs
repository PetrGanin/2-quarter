// Задача 47. Задайте двумерный массив мазмером mxn, заполненный случайными вещественными числами.
// m=3,n=4;dopolnil

// double[,] real = new double[3, 5];
// Random random = new Random();
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         real[i, j] = Math.Round(new Random().NextDouble(),2);
//         Console.Write(real[i, j]);
//     }
//     Console.WriteLine();
// }

void FillArrayWithRandom(double[,] realnamber, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            realnamber[i,j] = Math.Round(new Random().NextDouble(),2);
            Console.Write(realnamber[i,j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
double [,] realnamber = new double[m,n];
FillArrayWithRandom(realnamber, m, n);

