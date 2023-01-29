// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// void FillArrayWithRandom(int[,] matrix, int m, int n)
// {
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             matrix[i,j] = new Random().Next(0, 11);
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     void FillArraysqr(int[,] matrix, int m, int n)
// {
//     for(int i = 0; i < m; i++)
//     {
//         for(int j = 0; j < n; j++)
//         {
//             if(i==j)
//             {
//                 matrix[i,j] = matrix[i,j]* matrix[i,j];
//                 // Console.Write(matrix[i,j] + " ");
//             }
            
//             Console.Write(matrix[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix, m, n);

void fill2Array(int[,] array, int m, int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i,j] = new Random().Next(-10, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int PrintMainLine(int[,] array, int n, int m)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if(i == j) sum += array[i, j];
        }
    }
    return sum;
}

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n,m];
int sum = 0;

fill2Array(array, n, m);

sum = PrintMainLine(array, n, m);

Console.WriteLine(sum);