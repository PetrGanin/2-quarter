// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите четвертое число: ");
int d = Convert.ToInt32(Console.ReadLine());

int index = 0; 

// double d = double.Parse(s);

// double x = Convert.ToDouble(Console.ReadLine());
int [] array = new int [4];
 
array[0] = a;
array[1] = b;
array[2] = c;
array[3] = d;

Console.WriteLine(string.Join(", ", array));

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    index++;
}
Console.Write("Количество положительных элементов в массиве: ");
Console.Write(index);