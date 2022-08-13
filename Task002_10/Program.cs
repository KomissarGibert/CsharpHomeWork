/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5, 782 -> 8, 918 -> 1*/

Console.Write("Задайте 3х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n >= 100 && n <=999 || n <= -100 && n >=-999)
{
    int n2 = n / 10;
    int nSearch = n2 % 10;
    Console.WriteLine("Вторая цифра заданного числа " + nSearch);
    Console.WriteLine(n);
}
else 
{
   Console.WriteLine("Вы ввели не 3х значное число\nИли некорректное число");
   Console.WriteLine(n);
}
