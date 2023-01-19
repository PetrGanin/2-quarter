// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] FillArrayRandom(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100,1000);
    }
    return array;
}

int [] array = new int [9];
FillArrayRandom(array);

Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(String.Join(",", array));

int caunt = 0;
for(int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        caunt++;
    }

}
Console.WriteLine("Количество четных чисел в массиве:  ");
Console.Write(caunt);