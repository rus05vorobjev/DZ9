﻿/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/
Console.Write("Введите число больше 1: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Вывод чисел: ");
void NumberCounter (int number)
{

    if (number == 0) return;
    
    Console.Write("{0,2}", number);
    NumberCounter (number - 1);
}
    
    

NumberCounter(number);