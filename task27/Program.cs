// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Console.WriteLine("Введите число: ");
// int namber = Convert.ToInt32(Console.ReadLine());
// int A = 0;
// int B = 0;
// int C = 0;
// C = namber%10;
// A = namber/100;
// B = (namber%100)/10;
// Console.WriteLine(A+B+C);

Console.WriteLine("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = 0;
while (A > 0)
{
 
   B = B + A % 10;
   A = A /10 ;
 
}
 Console.WriteLine(B);