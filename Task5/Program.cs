//Задача 7: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

int a1 = x % 10;
Console.WriteLine(a1);