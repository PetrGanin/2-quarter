// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] FillArrayRandom (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);

    } 
    return array;
}
int [] array = new int [5];
FillArrayRandom(array);
Console.WriteLine("Ваш случайный массив: ");
Console.WriteLine(String.Join(",",array));

int newLength = array.Length/2 + array.Length%2;
int [] newarray = new int[newLength];
for( int i = 0; i < array.Length/2; i++)
{
    newarray[i] = array[i]* array[array.Length -1 - i];
}
if(array.Length%2 > 0) // среднее значение индекса нечетного массива записываем в конец массива без изменение из массива array.
{
    newarray[newarray.Length -1] = array[array.Length/2];
}
Console.Write("ваш получившийся массив: ");
Console.Write(String.Join(",", newarray));
// int arrayplus = 0;
// int arrayminus = -1;
// int arrayFill = 0;

// for(int i = 0; i < newLength; i++);{
//     if(array.Length/2){
//         arrayFill = (array[0] * array[-1]);
//         arrayplus = array[0]++;
//         arrayminus = array[-1]--;
//         Console.Write(arrayFill + ',');
//     }
// }
