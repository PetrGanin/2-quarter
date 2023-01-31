// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// void PrintNumbers(int number)
// {
//     if(number == 0)
//     {
//         return;
//     }
//     PrintNumbers(number - 1);
//     Console.Write(number + " ");
// }

// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// PrintNumbers(N);

void MNArray( int numbers1, int numbers2)
{
    if( numbers1 == numbers2 -1)
    {
    return; 
    }
MNArray(numbers1 -1, numbers2);
Console.Write(numbers1 + " ");
}
Console.WriteLine("Введите число m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n:");
int n = Convert.ToInt32(Console.ReadLine());
MNArray(m,n);