// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] FillArrayRandom (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(11,200);

    } 
    return array;
}
int [] array = new int [8];
FillArrayRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(String.Join(",",array));

int caunt =0;

for( int i = 0; i < array.Length; i++)
{
    if(array[i] > 10 && array[i] < 99)
    {
    caunt++;
    }
    
}
Console.WriteLine(caunt);