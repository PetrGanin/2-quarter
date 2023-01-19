// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.7; 7.2; 2.1; 7.8] -> 5.7

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

 double[] massive = new double[] {3.5, 2.4, 6.4, 10.4, 3.6, 5.7, 4.6};
 double nambermax = 0;
 double nambermin = 10;
 int caunt = 0;
 double namber = 0;

for( int i = 0; i < massive.Length; i++)
{
    if(massive[i] > nambermax)
    {
        nambermax = massive[i];
    }
caunt++;
}
for( int i = 0; i < massive.Length; i++)
{
    if(massive[i] < nambermin)
    {
        nambermin = massive[i];
    }
caunt++;
}

namber = nambermax - nambermin;
Console.WriteLine("максимальное значение: " + nambermax);
Console.WriteLine("Минимальное значение: " + nambermin);
Console.Write("Разница между максимальным и минимальным значением: ");
Console.Write(nambermax - nambermin);


