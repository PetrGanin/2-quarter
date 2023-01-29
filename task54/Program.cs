// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] ArrayRandom(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0,10);
        }
    }
    return result;
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

Console.Write("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = ArrayRandom(rows, columns);
PrintArray(array);

Console.WriteLine();

for (int k = 0; k < rows; k++)    //сортировка массива по убыванию
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if(array[k, j] > array[k, j - 1])
            {
                int temp = array[k, j];
                array[k, j] = array[k, j - 1];
                array[k, j - 1] = temp;
            }
        }
    }
}
PrintArray(array);