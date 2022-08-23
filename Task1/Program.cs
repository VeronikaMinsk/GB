//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

Console.WriteLine("введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x > y)
{
    Console.Write("большее число: ");
    Console.WriteLine(x);
    Console.Write("меньшее число: ");
    Console.WriteLine(y);
}
else if (x < y)
{
    Console.Write("большее число: ");
    Console.WriteLine(y);
    Console.Write("меньшее число: ");
    Console.WriteLine(x);
}
else if (x == y)
{
    Console.Write("числа равны");
 
}

