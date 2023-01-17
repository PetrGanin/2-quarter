// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (A>0)
// {
//     A=A/10;
//     count++;
// }
// Console.WriteLine(count);

// Console.WriteLine("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = A.ToString().Length;
// Console.WriteLine(B);

// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

// int Sum(int namber){
//     int sum = 1;
//     for(int i = 1; i <= namber; i++)
//     {
//         sum*=i;
//     }
//     return sum;
// }
// Console.WriteLine("Введите число");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Sum(A));

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int []arr = new int [8];
// int[] FillArr(int[] array)
// {
//     for(int i =0; i<array.Length; i++)
//     {
//         array[i] =new Random().Next(0,2);
//     }
//     return array;
// }

// void PrintArr(int[] array){
//     for(int i = 0; i <= array.Length; i++){
//         Console.WriteLine(array[i]);
//     }
// }
// FillArr(arr);
// PrintArr(arr);


// 30 задача "Более простой способ":
int [] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array [i] = new Random().Next(0,2);
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}
