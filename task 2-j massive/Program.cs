// double[,] a = new double[1,7];
// Random B = new Random();
// for (int i = 0; i < 1; i++)
// {
//     for (int j = 0; j < 7; j++)
//     {
//         a[i, j] = B.NextDouble() * 10; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
//         Console.Write("{0,9:F1}", a[i,j]);
//     }
//     Console.WriteLine();
// }

int [,] massive = new int [3,4];
void FillArray(int[,] massive)
{
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j<massive.GetLength(1); j++)
        {
            Console.Write($"{massive[i,j]}  ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine();
FillArray(massive);

void FillArrayRandom(int[,] rand){
    for(int i = 0; i < massive.GetLength(0); i++)
    {
        for(int j = 0; j<massive.GetLength(1); j++)
        {
            rand[i,j] = new Random().Next(1);
        }
    }

}
FillArray(massive);
Console.WriteLine();
FillArrayRandom(massive);