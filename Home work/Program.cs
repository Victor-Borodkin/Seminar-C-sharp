﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2)
// {
//     Console.Write($"max = {number1}");
// }
// else if(number1 < number2)
// {
//     Console.Write($"max = {number2}");
// } 
// else
// {
//     Console.Write("Числа равны");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int number3 = Convert.ToInt32(Console.ReadLine());

// if(number1 > number2 && number1 > number3)
// {
//     Console.Write($"max = {number1}");
// }
// else if(number2 > number1 && number2 > number3)
// {
//     Console.Write($"max = {number2}");
// } 
// else
// {
//     Console.Write($"max = {number3}");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if(number % 2 == 0)
// {
//     Console.Write("да");
// }
// else
// {
//     Console.Write("нет");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int counter = 1;
// while(counter <= number)
// {
//     if(counter % 2 == 0)
//     {
//         Console.Write($"{counter}");
//         counter++;
//     }
//     else
//     {
//         counter++;
//     }
// }