// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

// void FillArrayWithRandom(int[,] matrix)
// {
//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// int a = 0;
// int b = 0;
// int c = 0;
// int d = 0;
// int e = 0;
// int f = 0;
// int g = 0;
// int m = 0;
// int n = 0;



// int[,] matrix = new int[4, 4];
// FillArrayWithRandom(matrix);
//     for (int i = 0; i < 4; i++)
//     {
//         for (int j = 0; j < 4; j++)
//         {
//             if(1 == matrix[i,j])
//             {
//                 a++;
                
//             }
            
//             else if(2 == matrix[i,j])
//             {
//                 b++;
                
//             }
            
//             else if(3 == matrix[i,j])
//             {
//                 c++;
    
//             }
//             else if(4 == matrix[i,j])
//             {
//                 d++;
                
//             }
//              else if(5 == matrix[i,j])
//             {
//                 e++;
                
//             }
//              else if(6 == matrix[i,j])
//             {
//                 f++;
                
//             }
//               else if(7 == matrix[i,j])
//             {
//                 g++;
//             }
//              else if(8 == matrix[i,j])
//             {
//                 m++;
//             }
//              else if(9 == matrix[i,j])
//             {
//                 n++;
//             }
//         }
//         Console.WriteLine();
//     }
// Console.WriteLine(a);
// Console.WriteLine("Двоек встречается: " + b);

void FillArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }

    }
}

void PrintArrayWithRandom(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
FillArrayWithRandom(matrix);
PrintArrayWithRandom(matrix);

int count = 0;
for (int k = 0; k < 10; k++)
{
    count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(matrix[i,j] == k)
            {
                count++;
            }
        }
    }
    if(count > 0)
    {
        Console.WriteLine($"Кол-во повторений для {k} = {count}");
    }
}