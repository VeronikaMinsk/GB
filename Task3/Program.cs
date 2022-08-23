//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным

Console.WriteLine("введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 0)
Console.WriteLine("четное число ");  
else
 Console.WriteLine("нечетное число ");
