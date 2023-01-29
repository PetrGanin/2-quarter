// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
// Создание массива

// Спиральное заполнение массива
void SpiralFillarray(int[,] array)

{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int count = 1;
    for (int i = 0; i <= rows / 2; i++)
    {
        for (int j = i; j < columns - i; j++) //первой строки
        {
            if (array[i, j] == 0) array[i, j] = count++;
        }
        for (int k = i + 1; k < rows - i; k++) // последнего столбца
        {
            if (array[k, columns - 1 - i] == 0) array[k, columns - 1 - i] = count++;
        }
        for (int l = columns - 1 - i; l >= 0; l--) // последней строки
        {
            if (array[rows - 1 - i, l] == 0) array[rows - 1 - i, l] = count++;
        }
        for (int n = rows - 1 - i; n > 0; n--) //первого столбца
        {
            if (array[n, i] == 0) array[n, i] = count++;
        }
    }

}
int[,] Array = new int[3, 3];

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
SpiralFillarray(Array);
PrintArray(Array);

