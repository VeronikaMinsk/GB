// Задача 5: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

for (int y = -1 * x; y <= x; y += 1)
Console.WriteLine(y);
