﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число");
int N = 0;
N = Convert.ToInt32(Console.ReadLine());
int score = 1;
       while (score < N)
       {
        Console.Write(score+1 +" ");
        score+= 2;
       }
