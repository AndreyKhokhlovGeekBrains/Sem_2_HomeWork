﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int myNum = Convert.ToInt32(Console.ReadLine());
int result = myNum % 100 / 10;
Console.WriteLine($"Вторая цифра в веденном числе {myNum} = {result}");
