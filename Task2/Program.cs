//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.

Console.WriteLine("введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;
if (y > x) max = y;
if (z > y) max = z;

Console.Write("наибольшее число: ");
Console.WriteLine(max);
