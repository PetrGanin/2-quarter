
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] FillArrRandom(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(0,100);
    }
    return array;
}

int [] array = new int [9];
FillArrRandom(array);

Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(String.Join(",", array));
int sum = 0;

for( int i = 0; i < array.Length; i+=2)
{
    sum = array[i] + sum;
}

Console.WriteLine("сумма нечетных позиций массива: " + sum);